
namespace Demo_LOGIN_REGISTER
{
    partial class FormSendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSmtp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUSERNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPASSWORD = new System.Windows.Forms.TextBox();
            this.textTO = new System.Windows.Forms.TextBox();
            this.textCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(324, 57);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.White;
            this.lblTo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(189)))));
            this.lblTo.Location = new System.Drawing.Point(31, 52);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 15);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To:";
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.chkSSL);
            this.Setting.Controls.Add(this.label4);
            this.Setting.Controls.Add(this.textSmtp);
            this.Setting.Controls.Add(this.label3);
            this.Setting.Controls.Add(this.textPort);
            this.Setting.Controls.Add(this.label1);
            this.Setting.Controls.Add(this.textUSERNAME);
            this.Setting.Controls.Add(this.label2);
            this.Setting.Controls.Add(this.textPASSWORD);
            this.Setting.Controls.Add(this.btnSend);
            this.Setting.Location = new System.Drawing.Point(122, 290);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(439, 134);
            this.Setting.TabIndex = 2;
            this.Setting.TabStop = false;
            this.Setting.Text = "groupBox1";
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(324, 13);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(42, 17);
            this.chkSSL.TabIndex = 16;
            this.chkSSL.Text = "SSl";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(189)))));
            this.label4.Location = new System.Drawing.Point(190, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Smtp:";
            // 
            // textSmtp
            // 
            this.textSmtp.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.textSmtp.ForeColor = System.Drawing.Color.Black;
            this.textSmtp.Location = new System.Drawing.Point(239, 94);
            this.textSmtp.Name = "textSmtp";
            this.textSmtp.Size = new System.Drawing.Size(181, 28);
            this.textSmtp.TabIndex = 8;
            this.textSmtp.Text = "smtp.gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(189)))));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port:";
            // 
            // textPort
            // 
            this.textPort.BackColor = System.Drawing.Color.White;
            this.textPort.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPort.ForeColor = System.Drawing.Color.Black;
            this.textPort.Location = new System.Drawing.Point(97, 94);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(75, 28);
            this.textPort.TabIndex = 7;
            this.textPort.Text = "587";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // textUSERNAME
            // 
            this.textUSERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textUSERNAME.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.textUSERNAME.ForeColor = System.Drawing.Color.Black;
            this.textUSERNAME.Location = new System.Drawing.Point(97, 13);
            this.textUSERNAME.Name = "textUSERNAME";
            this.textUSERNAME.Size = new System.Drawing.Size(186, 28);
            this.textUSERNAME.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // textPASSWORD
            // 
            this.textPASSWORD.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.textPASSWORD.ForeColor = System.Drawing.Color.Black;
            this.textPASSWORD.Location = new System.Drawing.Point(97, 52);
            this.textPASSWORD.Name = "textPASSWORD";
            this.textPASSWORD.PasswordChar = '•';
            this.textPASSWORD.Size = new System.Drawing.Size(186, 28);
            this.textPASSWORD.TabIndex = 6;
            // 
            // textTO
            // 
            this.textTO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textTO.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.textTO.ForeColor = System.Drawing.Color.Black;
            this.textTO.Location = new System.Drawing.Point(122, 49);
            this.textTO.Name = "textTO";
            this.textTO.Size = new System.Drawing.Size(439, 28);
            this.textTO.TabIndex = 1;
            // 
            // textCC
            // 
            this.textCC.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.textCC.ForeColor = System.Drawing.Color.Black;
            this.textCC.Location = new System.Drawing.Point(122, 88);
            this.textCC.Name = "textCC";
            this.textCC.Size = new System.Drawing.Size(439, 28);
            this.textCC.TabIndex = 2;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.BackColor = System.Drawing.Color.White;
            this.lblCC.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(189)))));
            this.lblCC.Location = new System.Drawing.Point(31, 91);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(26, 15);
            this.lblCC.TabIndex = 0;
            this.lblCC.Text = "CC:";
            // 
            // textSubject
            // 
            this.textSubject.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.textSubject.ForeColor = System.Drawing.Color.Black;
            this.textSubject.Location = new System.Drawing.Point(122, 128);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(439, 28);
            this.textSubject.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.White;
            this.lblSubject.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(189)))));
            this.lblSubject.Location = new System.Drawing.Point(31, 131);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 15);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject:";
            // 
            // textMessage
            // 
            this.textMessage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.textMessage.ForeColor = System.Drawing.Color.Black;
            this.textMessage.Location = new System.Drawing.Point(122, 165);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMessage.Size = new System.Drawing.Size(439, 119);
            this.textMessage.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(189)))));
            this.lblMessage.Location = new System.Drawing.Point(31, 168);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(56, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message:";
            // 
            // FormSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 448);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.textCC);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.textTO);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.lblTo);
            this.Name = "FormSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send mail";
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.TextBox textTO;
        private System.Windows.Forms.TextBox textCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUSERNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPASSWORD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSmtp;
        private System.Windows.Forms.CheckBox chkSSL;
    }
}