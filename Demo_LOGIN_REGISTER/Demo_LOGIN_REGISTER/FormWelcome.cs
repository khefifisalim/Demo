using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_LOGIN_REGISTER
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void btn_SendMail_Click(object sender, EventArgs e)
        {
            new FormSendMail().Show();
            this.Hide();
        }
    }
}
