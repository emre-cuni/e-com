using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static e_com.SqlProcess;

namespace e_com
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlProcess sqlProcess = new SqlProcess();
        StringBuilder loginEmail = new StringBuilder();
        StringBuilder loginPassword = new StringBuilder();
        bool control;
        StringBuilder registerName = new StringBuilder();
        StringBuilder registerSurname = new StringBuilder();
        StringBuilder registerMail = new StringBuilder();
        StringBuilder registerPassword = new StringBuilder();
        StringBuilder registerBirthday = new StringBuilder();
        StringBuilder registerCredit = new StringBuilder();
        string query;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLoginMail.Text != string.Empty && textBoxLoginPassword.Text != string.Empty)
                {
                    loginEmail.Append(textBoxLoginMail.Text);
                    loginPassword.Append(textBoxLoginPassword.Text);
                    query = "Select * From Table_Customer";
                    sqlProcess.SqlReader(query);

                    foreach (string customer in sqlProcess.customerList)
                    {
                        if (loginEmail.ToString() == customer.Substring(0, customer.IndexOf("-")).Trim() && loginPassword.ToString() == customer.Substring(customer.IndexOf("-") + 1).Trim()) //girilen kullanıcı bilgileri db'de var mı yok mu kontrol eder
                        {
                            control = true; // giriş yaptıktan sonra hatalı giriş mesajı vermemesi için true değeri atanır
                            FormMain formMain = new FormMain();
                            this.Hide();
                            formMain.ShowDialog();
                            break;
                        }
                    }
                    loginEmail.Clear();
                    loginPassword.Clear();
                    if (!control)
                        MessageBox.Show("Hatalı E-Mail veya Hatalı Parola!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        this.Close();
                }
                else
                {
                    MessageBox.Show("E-Mail ve Parolanızı Girmelisiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "ButtonLogin Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxRegisterName.Text != string.Empty && textBoxRegisterSurname.Text != string.Empty && textBoxRegisterMail.Text != string.Empty && textBoxRegisterPassword.Text != string.Empty && maskedTextBoxRegisterBirthDate.Text != string.Empty && maskedTextBoxRegisterCreditCard.Text != string.Empty)
                {
                    registerName.Append(textBoxRegisterName.Text);
                    registerSurname.Append(textBoxRegisterSurname.Text);
                    registerMail.Append(textBoxRegisterMail.Text);
                    registerPassword.Append(textBoxRegisterPassword.Text);
                    registerBirthday.Append(maskedTextBoxRegisterBirthDate.Text);
                    registerCredit.Append(maskedTextBoxRegisterCreditCard.Text);

                    query = $"INSERT INTO Table_Customer(name,surname,mail,password,birthday,creditCard) VALUES ('" + registerName + "','" + registerSurname + "','" + registerMail + "','" + registerPassword + "','" + registerBirthday + "','" + registerCredit + "')";
                    if (sqlProcess.SqlWriter(query))
                        MessageBox.Show("kayıt eklendi");
                    else
                        MessageBox.Show("kayıt  eklenemedi");
                }
                else
                    MessageBox.Show("Boş Bırakamazsınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "ButtonRegister Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (!sqlProcess.SqlConn(sqlProcess.connString))
            {
                this.Enabled = false;
                MessageBox.Show("SQL Bağlantısı Kurulamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

            textBoxRegisterName.Text = "Emrecan";
            textBoxRegisterSurname.Text = "Cüni";
            textBoxRegisterMail.Text = "cuniemre@gmail.com";
            textBoxRegisterPassword.Text = "1967";
            maskedTextBoxRegisterBirthDate.Text = "11.02.2023";
            maskedTextBoxRegisterCreditCard.Text = "6152341967615246";
        }
    }
}
