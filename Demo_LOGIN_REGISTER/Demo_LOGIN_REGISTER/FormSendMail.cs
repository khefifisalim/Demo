using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using log4net;
using System.Reflection;
using log4net.Config;
using System.IO;

namespace Demo_LOGIN_REGISTER
{
    public partial class FormSendMail : Form
    {
      
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormSendMail()
        {
            InitializeComponent();
            var logRepo = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepo, new FileInfo("Logger.config"));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress(textUSERNAME.Text, "B4Creation Software Solution Team");
            var toAddress = new MailAddress(textTO.Text, "B4Creation Software Solution Team");          
            string fromPassword = textPASSWORD.Text;
            string subject = textSubject.Text;
            string body = textMessage.Text;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Successfully send email");
                    log.Debug("Successfully send email");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    log.Debug(ex.Message);
                }
            }
        }

    }
}
       

