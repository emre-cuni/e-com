using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_com
{
    public partial class FormCompleteShopping : Form
    {
        public FormCompleteShopping()
        {
            InitializeComponent();
        }

        StringBuilder code = new StringBuilder();
        StringBuilder creditCard = new StringBuilder();
        string query = null;
        public string email { get; set; }
        SqlProcess sqlProcess = new SqlProcess();
        int verifyCode = 0, controlVerifyCode = 0;
        public double totalPrice;
        public bool completeShop = false;

        private void buttonSendCode_Click(object sender, EventArgs e) // doğrulama kodunu mail olarak gönderir
        {
            try
            {
                creditCard.Append(textBoxCreditCard.Text);

                query = $"Select * From Table_Customer Where mail = '{email}' And creditCard = '{creditCard}'";
                
                if (sqlProcess.SqlControl(query)) // girilen kart geçerli kullanıcınınsa
                {
                    MailMessage mailMessage = new MailMessage();
                    SmtpClient smtpClient = new SmtpClient();
                    Random random = new Random();

                    for (int i = 0; i < 6; i++) // doğrulama kodu oluşturulur
                        code.Append(random.Next(10));
                    verifyCode = int.Parse(code.ToString());

                    smtpClient.Credentials = new NetworkCredential("ecom.destek@outlook.com", "4146ecomdestek");
                    smtpClient.Port = 587;
                    smtpClient.Host = "smtp-mail.outlook.com";
                    smtpClient.EnableSsl = true;

                    //mail hazırlanır
                    mailMessage.To.Add(email);
                    mailMessage.From = new MailAddress("ecom.destek@outlook.com");
                    mailMessage.Subject = "e-com Doğrulama Kodu";
                    mailMessage.Body = $"{creditCard.ToString().Substring(12)} İle Biten Kartınızla e-com Firmasından ₺{totalPrice} Tutarında Yaptığınız İşlem İçin Doğrulama Kodunuz: {verifyCode}\n\nİşlem Tarihi:{DateTime.Now}";
                    smtpClient.Send(mailMessage);

                    MessageBox.Show("Doğrulama Kodu Gönderildi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    buttonConfirmOrder.Enabled = true;
                    textBoxVerifyCode.Enabled = true;
                }
                else // girilen kart geçerli kullanıcının değilse
                    MessageBox.Show("Kart Numaranızı Kontrol Ediniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Kod Gönderme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCompleteShopping_Load(object sender, EventArgs e)
        {
            if (!sqlProcess.SqlConn(sqlProcess.connString)) // veri tabanı kontrolü yapılır
            {
                Enabled = false;
                MessageBox.Show("SQL Bağlantısı Kurulamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            try
            {
                controlVerifyCode = int.Parse(textBoxVerifyCode.Text);

                if (controlVerifyCode == verifyCode)
                {
                    MessageBox.Show("Siparişiniz Alındı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    completeShop = true;
                    Close();
                }
                else
                    MessageBox.Show("Kodlar Eşleşmiyor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Siparişi Onayla Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
