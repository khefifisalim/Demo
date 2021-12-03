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


namespace Demo_LOGIN_REGISTER
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
     
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider() )
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public class Users
        {
            //[BsonId]
            public Guid Id { set; get; }
            public string UserName { set; get; }
            public string Email { set; get; }
            public string Password { set; get; }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                const string connect1 = "mongodb://localhost:27017";
                MongoClient mc = new MongoClient(connect1);
                var db = mc.GetDatabase("Demo");
                var collection = db.GetCollection<Users>("Users");
                


                var filter = Builders<Users>.Filter.Empty;
                bool user = false;

                foreach (var data in collection.Find(filter).ToListAsync().Result)
                {
                    if (textUserName.Text == data.UserName)
                    {
                        user = true;

                        if (Encrypt(textPassword.Text) == data.Password)
                        {
                            MessageBox.Show("Successfully connection");

                            new FormWelcome().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");

                        }
                    }
                }

                if (!user)
                {
                    MessageBox.Show("user not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid: " + ex.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textUserName.Text = "";
            textPassword.Text = "";
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '•';
            }
        }

        private void lbl_Account_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(this, e);
            }
        }
    }
}
