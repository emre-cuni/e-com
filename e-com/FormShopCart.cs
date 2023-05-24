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

namespace e_com
{
    public partial class FormShopCart : Form
    {
        public FormShopCart()
        {
            InitializeComponent();
        }

        public Dictionary<string, Tuple<int, double, Image>> shopCart = new Dictionary<string, Tuple<int, double, Image>>();
        double totalPrice;

        private void FormShopCart_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var shop in shopCart)
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
                name.Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                name.Size = new Size(468, 25);
                price.Location = new Point(138, 115);
                price.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));


                panel.Size = new Size(533, 150);
                panel.BackColor = Color.FromArgb(61, 61, 61);
               

                flowLayoutPanel1.Controls.Add(panel);

                totalPrice += (shop.Value.Item2 * shop.Value.Item1);
                
            }
            labelTotal.Text = "₺" + totalPrice;
        }

        private void buttonCompleteShopping_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
