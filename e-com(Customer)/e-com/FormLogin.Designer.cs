namespace e_com
{
    partial class FormLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRegister = new System.Windows.Forms.GroupBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.maskedTextBoxRegisterCreditCard = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRegisterBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxRegisterMail = new System.Windows.Forms.TextBox();
            this.textBoxRegisterSurname = new System.Windows.Forms.TextBox();
            this.textBoxRegisterName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxRegister.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogin.Controls.Add(this.label3);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxLoginPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxLoginMail);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Location = new System.Drawing.Point(6, 6);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(318, 331);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mail:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(80, 193);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(211, 35);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoginPassword.Location = new System.Drawing.Point(80, 149);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(211, 24);
            this.textBoxLoginPassword.TabIndex = 2;
            // 
            // textBoxLoginMail
            // 
            this.textBoxLoginMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoginMail.ForeColor = System.Drawing.Color.Silver;
            this.textBoxLoginMail.Location = new System.Drawing.Point(80, 106);
            this.textBoxLoginMail.Name = "textBoxLoginMail";
            this.textBoxLoginMail.Size = new System.Drawing.Size(211, 24);
            this.textBoxLoginMail.TabIndex = 1;
            this.textBoxLoginMail.Text = "(example@example.com)";
            this.textBoxLoginMail.Enter += new System.EventHandler(this.textBoxMail_Enter);
            this.textBoxLoginMail.Leave += new System.EventHandler(this.textBoxMail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Yap";
            // 
            // groupBoxRegister
            // 
            this.groupBoxRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegister.Controls.Add(this.textBoxRegisterPassword);
            this.groupBoxRegister.Controls.Add(this.label10);
            this.groupBoxRegister.Controls.Add(this.label9);
            this.groupBoxRegister.Controls.Add(this.label8);
            this.groupBoxRegister.Controls.Add(this.label7);
            this.groupBoxRegister.Controls.Add(this.label6);
            this.groupBoxRegister.Controls.Add(this.label5);
            this.groupBoxRegister.Controls.Add(this.label4);
            this.groupBoxRegister.Controls.Add(this.buttonRegister);
            this.groupBoxRegister.Controls.Add(this.maskedTextBoxRegisterCreditCard);
            this.groupBoxRegister.Controls.Add(this.maskedTextBoxRegisterBirthDate);
            this.groupBoxRegister.Controls.Add(this.textBoxRegisterMail);
            this.groupBoxRegister.Controls.Add(this.textBoxRegisterSurname);
            this.groupBoxRegister.Controls.Add(this.textBoxRegisterName);
            this.groupBoxRegister.Location = new System.Drawing.Point(7, 6);
            this.groupBoxRegister.Name = "groupBoxRegister";
            this.groupBoxRegister.Size = new System.Drawing.Size(318, 331);
            this.groupBoxRegister.TabIndex = 1;
            this.groupBoxRegister.TabStop = false;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(122, 168);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(183, 24);
            this.textBoxRegisterPassword.TabIndex = 3;
            this.textBoxRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Parola:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kart Numarası:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Soyisim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "İsim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(117, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kayıt Ol";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(122, 260);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(183, 35);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Kayıt Ol";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // maskedTextBoxRegisterCreditCard
            // 
            this.maskedTextBoxRegisterCreditCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxRegisterCreditCard.Location = new System.Drawing.Point(122, 230);
            this.maskedTextBoxRegisterCreditCard.Name = "maskedTextBoxRegisterCreditCard";
            this.maskedTextBoxRegisterCreditCard.Size = new System.Drawing.Size(183, 24);
            this.maskedTextBoxRegisterCreditCard.TabIndex = 5;
            // 
            // maskedTextBoxRegisterBirthDate
            // 
            this.maskedTextBoxRegisterBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxRegisterBirthDate.Location = new System.Drawing.Point(122, 199);
            this.maskedTextBoxRegisterBirthDate.Mask = "0000-00-00";
            this.maskedTextBoxRegisterBirthDate.Name = "maskedTextBoxRegisterBirthDate";
            this.maskedTextBoxRegisterBirthDate.Size = new System.Drawing.Size(183, 24);
            this.maskedTextBoxRegisterBirthDate.TabIndex = 4;
            this.maskedTextBoxRegisterBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxRegisterMail
            // 
            this.textBoxRegisterMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterMail.ForeColor = System.Drawing.Color.Silver;
            this.textBoxRegisterMail.Location = new System.Drawing.Point(122, 137);
            this.textBoxRegisterMail.Name = "textBoxRegisterMail";
            this.textBoxRegisterMail.Size = new System.Drawing.Size(183, 24);
            this.textBoxRegisterMail.TabIndex = 2;
            this.textBoxRegisterMail.Text = "(example@example.com)";
            this.textBoxRegisterMail.Enter += new System.EventHandler(this.textBoxMail_Enter);
            this.textBoxRegisterMail.Leave += new System.EventHandler(this.textBoxMail_Leave);
            // 
            // textBoxRegisterSurname
            // 
            this.textBoxRegisterSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterSurname.Location = new System.Drawing.Point(122, 106);
            this.textBoxRegisterSurname.Name = "textBoxRegisterSurname";
            this.textBoxRegisterSurname.Size = new System.Drawing.Size(183, 24);
            this.textBoxRegisterSurname.TabIndex = 1;
            // 
            // textBoxRegisterName
            // 
            this.textBoxRegisterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterName.Location = new System.Drawing.Point(122, 75);
            this.textBoxRegisterName.Name = "textBoxRegisterName";
            this.textBoxRegisterName.Size = new System.Drawing.Size(183, 24);
            this.textBoxRegisterName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageLogin);
            this.tabControl1.Controls.Add(this.tabPageRegister);
            this.tabControl1.Location = new System.Drawing.Point(22, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 374);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.Color.Turquoise;
            this.tabPageLogin.Controls.Add(this.groupBoxLogin);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 27);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(330, 343);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Giriş Yap";
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPageRegister.Controls.Add(this.groupBoxRegister);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 27);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(330, 343);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Kayıt Ol";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(383, 417);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxRegister.ResumeLayout(false);
            this.groupBoxRegister.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageRegister.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRegister;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegisterCreditCard;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegisterBirthDate;
        private System.Windows.Forms.TextBox textBoxRegisterMail;
        private System.Windows.Forms.TextBox textBoxRegisterSurname;
        private System.Windows.Forms.TextBox textBoxRegisterName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBoxLoginMail;
    }
}

