using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_com_Admin_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string connectionString = "Server=.;Database=e-com;User Id=Cuni;Password=123456;";
        StringBuilder productName = new StringBuilder();
        StringBuilder productBrand = new StringBuilder();
        StringBuilder productDescription = new StringBuilder();
        StringBuilder productSupCategory = new StringBuilder();
        StringBuilder productSubCategory = new StringBuilder();
        StringBuilder productPrice = new StringBuilder();
        StringBuilder imagePath = new StringBuilder();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Resim Seç";
                openFileDialog1.Filter = "Jpeg Dosyaları(*.jpeg)|*.jpeg|Jpg Dosyaları(*.jpg)|*.jpg|Png Dosyaları(*.png)|*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagePath.Append(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Resim Seç Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegisterProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //Ürün bilgileri alınır
                productName.Append(textBoxProductName.Text);
                productBrand.Append(textBoxProductBrand.Text);
                productDescription.Append(textBoxProductDescription.Text);
                productSupCategory.Append(textBoxProductSupCategory.Text);
                productSubCategory.Append(textBoxProductSubCategory.Text);                
                productPrice.Append(textBoxProductPrice.Text);

                //seçilen fotoğraf byte array'e çevrilir
                FileStream fileStream = new FileStream(imagePath.ToString(), FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] image = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();

                //Sql Bağlantısı Açılır
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                //kayıt sorgusu oluşturulur
                SqlCommand command = new SqlCommand("Insert Into Table_Product(productName, productBrand, productDescription, productSupCategory, productSubCategory, productPrice, productPhoto) Values(@name, @brand, @description, @supCategory, @subCategory, @price, @photo)", sqlConnection);
                command.Parameters.Add("@name",SqlDbType.NVarChar, productName.Length).Value = productName.ToString();
                command.Parameters.Add("@brand", SqlDbType.NVarChar, productBrand.Length).Value = productBrand.ToString();
                command.Parameters.Add("@description", SqlDbType.NVarChar, productDescription.Length).Value = productDescription.ToString();
                command.Parameters.Add("@supCategory", SqlDbType.NVarChar, productSupCategory.Length).Value = productSupCategory.ToString();
                command.Parameters.Add("@subCategory", SqlDbType.NVarChar, productSubCategory.Length).Value = productSubCategory.ToString();
                command.Parameters.Add("@price", SqlDbType.NVarChar, productPrice.Length).Value = productPrice.ToString();
                command.Parameters.Add("@photo", SqlDbType.Image, image.Length).Value = image;
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Kayıt Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //değişkenler temizlenir
                productName.Clear();
                productBrand.Clear();
                productDescription.Clear();
                productSupCategory.Clear();
                productSubCategory.Clear();
                productPrice.Clear();
                imagePath.Clear();
                pictureBox1.Image = null;
                textBoxProductName.Text = string.Empty;
                textBoxProductBrand.Text = string.Empty;
                textBoxProductDescription.Text = string.Empty;
                textBoxProductSupCategory.Text = string.Empty;
                textBoxProductSubCategory.Text = string.Empty;
                textBoxProductPrice.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
