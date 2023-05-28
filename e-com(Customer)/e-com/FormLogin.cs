using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        StringBuilder registerName = new StringBuilder();
        StringBuilder registerSurname = new StringBuilder();
        StringBuilder registerMail = new StringBuilder();
        StringBuilder registerPassword = new StringBuilder();
        StringBuilder registerBirthday = new StringBuilder();
        StringBuilder registerCredit = new StringBuilder();
        bool control;
        string query;
        string customer;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //girilen mail ve parola boş olmadığını ve doğru formatta olduğunu kontrol eder
                if (textBoxLoginMail.Text != string.Empty && textBoxLoginPassword.Text != string.Empty && textBoxLoginMail.Text.Contains("@") && textBoxLoginMail.Text.Contains(".com"))
                {
                    loginEmail.Append(textBoxLoginMail.Text.ToLower());
                    loginPassword.Append(textBoxLoginPassword.Text.ToLower());

                    // girilen mail ve parolayla eşleşen kayıt veri tabanında olup olmadığı kontrol edilir
                    query = $"Select * From Table_Customer Where mail = '{loginEmail}' And password = '{loginPassword}'"; 
                    sqlProcess.SqlReader(query);
                    customer = sqlProcess.customer.ToString();

                    if (customer != string.Empty && loginEmail.ToString() == customer.Substring(0, customer.IndexOf("-")).Trim() && loginPassword.ToString() == customer.Substring(customer.IndexOf("-") + 1).Trim()) //girilen kullanıcı bilgileri db'de var mı yok mu kontrol eder
                    {
                        control = true; // giriş yaptıktan sonra hatalı giriş mesajı vermemesi için true değeri atanır
                        FormMain formMain = new FormMain();
                        formMain.email = loginEmail.ToString();
                        Hide();
                        formMain.ShowDialog();
                    }

                    loginEmail.Clear();
                    loginPassword.Clear();
                    if (!control)
                        MessageBox.Show("Hatalı E-Mail veya Hatalı Parola!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        Close();
                }
                else
                    MessageBox.Show("E-Mail ve Parolanızı Girmelisiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // textbox'ların boş olup olmamasını kontrol eder
                if (textBoxRegisterName.Text != string.Empty && textBoxRegisterSurname.Text != string.Empty && textBoxRegisterMail.Text != string.Empty && textBoxRegisterPassword.Text != string.Empty && maskedTextBoxRegisterBirthDate.Text != string.Empty && maskedTextBoxRegisterCreditCard.Text != string.Empty)
                {
                    if(!textBoxRegisterMail.Text.Contains("@") && !textBoxRegisterMail.Text.Contains(".com")) // mailin formatının doğru olup olmadığını kontrol eder
                    {
                        MessageBox.Show("Lütfen Geçerli Bir E-Mail Giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        goto finish;
                    }

                    registerName.Append(textBoxRegisterName.Text.ToLower());
                    registerSurname.Append(textBoxRegisterSurname.Text.ToLower());
                    registerMail.Append(textBoxRegisterMail.Text.ToLower());
                    registerPassword.Append(textBoxRegisterPassword.Text);
                    registerBirthday.Append(maskedTextBoxRegisterBirthDate.Text);
                    registerCredit.Append(maskedTextBoxRegisterCreditCard.Text);

                    query = $"Select * From Table_Customer Where mail = '{registerMail}'"; // girilen mail adresinin veri tabanında olup olmadığı kontrol edilir
                    if (sqlProcess.SqlControl(query))
                    {
                        MessageBox.Show("Girdiğiniz E-Mail Adresi Kayıtlıdır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        goto finish;
                    }

                    // girilen mail veri tabanında yoksa yeni kayıt yapılır
                    query = $"INSERT INTO Table_Customer(name,surname,mail,password,birthday,creditCard) VALUES ('" + registerName + "','" + registerSurname + "','" + registerMail + "','" + registerPassword + "','" + registerBirthday + "','" + registerCredit + "')";
                    if (sqlProcess.SqlWriter(query))
                    {
                        MessageBox.Show("Kayıt İşlemi Tamamlandı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        textBoxLoginMail.Text = registerMail.ToString();
                        textBoxLoginPassword.Text = registerPassword.ToString();
                        tabControl1.SelectedIndex = 0;
                    }
                    else
                        MessageBox.Show("Kayıt İşlemi Tamamlanamaddı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Boş Bırakamazsınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                finish:;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "ButtonRegister Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (!sqlProcess.SqlConn(sqlProcess.connString)) // form açılınca veritabanın bağlantısı yapılır.
            {
                Enabled = false;
                MessageBox.Show("SQL Bağlantısı Kurulamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e) //mail textboxlarına girilen değerin uygun formatta olup olmadığı kontrol edilir
        {
            try
            {
                TextBox textBox = (TextBox) sender;
                if (!textBox.Text.Contains("@") || !textBox.Text.Contains(".com"))
                    MessageBox.Show("Lütfen Geçerli Bir E-Mail Giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(textBox.Text == string.Empty)
                {
                    textBox.Text = "(example@example.com)";
                    textBox.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "Mail Kontrol Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Text = tabControl1.SelectedTab.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "Sekme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxMail_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "Mail Placeholder Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
