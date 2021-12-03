using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using log4net;
using System.Reflection;
using log4net.Config;
using System.IO;

namespace Demo_LOGIN_REGISTER
{


    public partial class FormRegister : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormRegister()
        {
            InitializeComponent();
            var logRepo = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepo, new FileInfo("Logger.config"));

        }

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public class Users
        {
            [BsonId]
            public Guid Id { set; get; }
            public string UserName { set; get; }
            public string Email { set; get; }
            public string Password { set; get; }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try

            {
                // Connection & Creation Database with mongodb 
                const string connect1 = "mongodb://localhost:27017";
                MongoClient mc = new MongoClient(connect1);
                var db = mc.GetDatabase("Demo");
                var collection = db.GetCollection<Users>("Users");
                // Check if Mongo Server connected or not
                bool Server_Connected = db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(100); 
                // MessageBox.Show(Server_Connected.ToString());
                Users users = new Users();


                // Check fileds Not Null 
                if (textUserName.Text == "" && textEmail.Text == "" && textPassword.Text == "" && textComPassword.Text == "")
                {
                    MessageBox.Show("Please complete all fileds");
                    log.Debug("Please complete all fileds");
                }
                // Check Password 
                else if (textPassword.Text == textComPassword.Text)
                {
                    users.Id = Guid.NewGuid();
                    users.UserName = textUserName.Text;
                    users.Email = textEmail.Text;
                    users.Password = Encrypt(textPassword.Text);
                    
                    collection.InsertOne(users);
                    
                    MessageBox.Show("Your Account has been Successffuly Created ");
                    log.Debug("Your Account has been Successffuly Created");

                    textUserName.Text = "";
                    textEmail.Text = "";
                    textPassword.Text = "";
                    textComPassword.Text = "";


                }
                else
                {
                    MessageBox.Show("Your Password does not match");
                    log.Debug("Your Password does not match");
                    textPassword.Text = "";
                    textComPassword.Text = "";
                }
                //MessageBox.Show("Success");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Connect" + ex.Message);
                log.Debug("Failed To Connect" + ex.Message);
            }


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textUserName.Text = "";
            textEmail.Text = "";
            textPassword.Text = "";
            textComPassword.Text = "";
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textPassword.PasswordChar = '\0';
                textComPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '•';
                textComPassword.PasswordChar = '•';
            }
        }

        private void lbl_LOGIN_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void lbl_Account_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void textComPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Register_Click(this, e);
            }
        }
    }  
}
