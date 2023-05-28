using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace e_com
{
    public partial class FormShopCart : Form
    {
        public FormShopCart()
        {
            InitializeComponent();
        }

        public Dictionary<string, Tuple<int, double, Image>> shopCart = new Dictionary<string, Tuple<int, double, Image>>();
        double totalPrice = 0;
        FormCompleteShopping completeShopping = new FormCompleteShopping();
        public string email { get; set; }

        private void FormShopCart_Load(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();

                if (shopCart.Count == 0) // sepet boşsa
                {
                    flowLayoutPanel1.Visible = false;
                    Label label = new Label();
                    label.Text = "Sepetinizde Ürün Yok!";
                    label.Location = new Point(Width / 5, Height / 3);
                    label.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    label.Size = new Size(468, 25);
                    Controls.Add(label);
                    buttonCompleteShopping.Enabled = false;
                    goto finish;
                }

                //sepet boş değilse
                totalPrice = 0;
                
                foreach (var shop in shopCart)// sepetteki ürünler listelenir
                {
                    PictureBox pictureBox = new PictureBox();
                    Label name = new Label();
                    Label price = new Label();
                    Panel panel = new Panel();

                    pictureBox.Image = shop.Value.Item3;
                    name.Text = shop.Key;
                    price.Text = "₺" + (shop.Value.Item2 * shop.Value.Item1);

                    panel.Controls.Add(name);
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(price);

                    pictureBox.Location = new Point(7, 12);
                    pictureBox.Size = new Size(124, 124);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    name.Location = new Point(137, 12);
                    name.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                    name.Size = new Size(468, 25);
                    price.Location = new Point(138, 115);
                    price.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));

                    panel.Size = new Size(533, 150);
                    panel.BackColor = Color.FromArgb(61, 61, 61);

                    flowLayoutPanel1.Controls.Add(panel);

                    totalPrice += (shop.Value.Item2 * shop.Value.Item1); // sepet tutarı ekrana yazdırılır
                }
            finish:
                labelTotal.Text = "₺" + totalPrice;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Sepet Load Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCompleteShopping_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                completeShopping.email = email;
                completeShopping.totalPrice = totalPrice;
                completeShopping.ShowDialog();

                if (completeShopping.completeShop) // alışveriş tamamlandıysa sepet temizlenir
                {
                    shopCart.Clear(); 
                    totalPrice = 0;
                    labelTotal.Text = "₺0";
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Alışverişi Tamamla Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}