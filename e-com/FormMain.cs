using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace e_com
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Button button;
        Panel panel;
        PictureBox pictureBox;
        System.Windows.Forms.Label labelProductName;
        System.Windows.Forms.Label labelProductPrice;
        string query = null;
        SqlProcess sqlProcess = new SqlProcess();
        public byte[] photo;
        FormShopCart formShopCart = new FormShopCart();
        double minPrice = 0, maxPrice;

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (!sqlProcess.SqlConn(sqlProcess.connString)) // veritabanı kontrolü yapılır
                {
                    this.Enabled = false;
                    MessageBox.Show("SQL Bağlantısı Kurulamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                query = "Select * From Table_Product";
                ListProducts(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "FormMain Load Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelDescription_Click(object sender, EventArgs e)
        {
            try
            {
                Panel panel = null;
                PictureBox pictureBox = null;
                System.Windows.Forms.Label label;
                FormDescription formDescription = new FormDescription();
                int indis = 0;

                if (sender.GetType() == typeof(Panel)) //panel'den tıklandıysa panel'in tag'ı index olarak alınır
                {
                    panel = (Panel)sender;
                    indis = int.Parse(panel.Tag.ToString());
                }
                else if (sender.GetType() == typeof(PictureBox)) //pictureBox'tan tıklandıysa pictureBox'ın tag'ı index olarak alınır
                {
                    pictureBox = (PictureBox)sender;
                    indis = int.Parse(pictureBox.Image.Tag.ToString());
                }
                else if (sender.GetType() == typeof(System.Windows.Forms.Label)) //label'dan tıklandıysa label'ın tag'ı index olarak alınır
                {
                    label = (System.Windows.Forms.Label)sender;
                    indis = int.Parse(label.Tag.ToString());
                }
                formDescription.pictureBox1.Image = imageList1.Images[indis];
                formDescription.labelName.Text = sqlProcess.dataSet.Tables[0].Rows[indis]["productName"].ToString();
                formDescription.labelBrand.Text = sqlProcess.dataSet.Tables[0].Rows[indis]["productBrand"].ToString();
                formDescription.labelPrice.Text = sqlProcess.dataSet.Tables[0].Rows[indis]["productPrice"].ToString();
                formDescription.labelDescription.Text = sqlProcess.dataSet.Tables[0].Rows[indis]["productDescription"].ToString();
                formDescription.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Panel Click Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                string price = sqlProcess.dataSet.Tables[0].Rows[int.Parse(button.Tag.ToString())]["productPrice"].ToString();

                double total = double.Parse(price);
                photo = (byte[])sqlProcess.dataSet.Tables[0].Rows[int.Parse(button.Tag.ToString())]["productPhoto"];
                MemoryStream memoryStream = new MemoryStream(photo);

                if (!formShopCart.shopCart.ContainsKey(button.Name))
                    formShopCart.shopCart.Add(button.Name, Tuple.Create(1, total, Image.FromStream(memoryStream)));
                else
                    formShopCart.shopCart[button.Name] = Tuple.Create(2, total, Image.FromStream(memoryStream));

                MessageBox.Show("Ürün Sepete Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                memoryStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Sepete Ekle Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonPriceFilter_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                double.TryParse(textBoxMinPrice.Text, out minPrice);
                double.TryParse(textBoxMaxPrice.Text, out maxPrice);
                
                if(minPrice > maxPrice)
                {
                    double temp = maxPrice;
                    maxPrice = minPrice;
                    minPrice = temp;
                    textBoxMinPrice.Text = minPrice.ToString();
                    textBoxMaxPrice.Text = maxPrice.ToString();
                }
                if (maxPrice == 0)
                    maxPrice = double.MaxValue;
                MessageBox.Show(minPrice + "\n" + maxPrice);
                query = $"Select * From Table_Product Where productPrice >= '{minPrice}' And productPrice <= '{maxPrice}'";
                ListProducts(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Ücret Filtre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear(); //listelenen ürünler temizlenir 
                if (treeView1.SelectedNode.Parent == null) //istenilen kategorideki ürünlerin listelenmesi için sql sorgusu hazırlanır
                    query = $"Select * From Table_Product Where productSupCategory = '{treeView1.SelectedNode.Text}'";
                else
                    query = $"Select * From Table_Product Where productSubCategory = '{treeView1.SelectedNode.Text}'";

                ListProducts(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Kategori Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListProducts(string filterQuery) // ürünleri listeleyen metod
        {
            try
            {
                sqlProcess.SqlGetProduct(filterQuery);
                for (int i = 0; i < sqlProcess.dataSet.Tables[0].Rows.Count; i++)
                {
                    photo = (byte[])sqlProcess.dataSet.Tables[0].Rows[i]["productPhoto"];
                    MemoryStream memoryStream = new MemoryStream(photo);

                    panel = new Panel();
                    pictureBox = new PictureBox();
                    labelProductName = new System.Windows.Forms.Label();
                    labelProductPrice = new System.Windows.Forms.Label();
                    button = new Button();

                    //ürün fotoğrafı eklenir
                    pictureBox.Image = Image.FromStream(memoryStream);

                    imageList1.Images.Add(pictureBox.Image);
                    //imageList1.Images[i].Tag = pictureBox.Image;

                    //ürün adının label'a yazılır
                    labelProductName.Text = sqlProcess.dataSet.Tables[0].Rows[i]["productName"].ToString();
                    //ürün fiyatı label'a yazılır
                    labelProductPrice.Text = "₺" + sqlProcess.dataSet.Tables[0].Rows[i]["productPrice"].ToString();

                    //ürün bilgileri panele eklenir
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(labelProductName);
                    panel.Controls.Add(labelProductPrice);
                    panel.Controls.Add(button);

                    //panel ayarları yapılır
                    panel.Size = new Size(234, 362);
                    panel.Location = new Point(274, 321);
                    panel.BackColor = Color.FromArgb(46, 46, 46);
                    panel.Tag = i;
                    panel.Click += new EventHandler(panelDescription_Click);

                    //picturebox ayarları yapılır
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image.Tag = i;
                    pictureBox.Location = new Point(10, 13);
                    pictureBox.Size = new Size(214, 214);
                    pictureBox.Click += new EventHandler(panelDescription_Click);

                    //label ayarları yapılır
                    labelProductName.Location = new Point(4, 234);
                    labelProductName.Size = new Size(468, 18);
                    labelProductName.ForeColor = Color.White;
                    labelProductName.Tag = i;
                    labelProductName.Click += new EventHandler(panelDescription_Click);
                    labelProductPrice.Location = new Point(7, 281);
                    labelProductPrice.Size = new Size(81, 18);
                    labelProductPrice.ForeColor = Color.Green;
                    labelProductPrice.Tag = i;
                    labelProductPrice.Click += new EventHandler(panelDescription_Click);

                    //button ayarları yapılır
                    button.Text = "Sepete Ekle";
                    button.Location = new Point(10, 312);
                    button.Size = new Size(214, 37);
                    button.BackColor = Color.Orange;
                    button.ForeColor = Color.White;
                    button.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                    button.Tag = i;
                    button.Name = labelProductName.Text;
                    button.Click += new EventHandler(buttonAddToCart_Click);

                    //panel layoutpanel'e eklenir
                    flowLayoutPanel1.Controls.Add(panel);

                    //kategorilerin eklenmesi
                    string productSupCategory = sqlProcess.dataSet.Tables[0].Rows[i]["productSupCategory"].ToString().Trim();
                    string productSubCategory = sqlProcess.dataSet.Tables[0].Rows[i]["productSubCategory"].ToString().Trim();

                    bool parentNodeExists = false;
                    bool childeNodeExists = false;
                    foreach (TreeNode node in treeView1.Nodes)
                    {
                        if (node.Text == productSupCategory)
                        {
                            parentNodeExists = true;
                            // Alt kategoriyi kontrol etmek için alt düğümleri dolaş
                            foreach (TreeNode childNode in node.Nodes)
                            {
                                if (childNode.Text == productSubCategory)
                                    childeNodeExists = true;
                            }
                            break;
                        }
                    }

                    if (!parentNodeExists)
                        treeView1.Nodes.Add(productSupCategory);

                    // Yeni alt kategoriyi ekle
                    TreeNode parentNode = treeView1.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text == productSupCategory);
                    if (!childeNodeExists)
                        parentNode.Nodes.Add(productSubCategory);

                    //markaların eklenmesi
                    string brand = sqlProcess.dataSet.Tables[0].Rows[i]["productBrand"].ToString().Trim();
                    if (!checkedListBox1.Items.Contains(brand)) // aynı markadan başka ürün ekleyip bunu kontrol et
                        checkedListBox1.Items.Add(brand);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "ListProducts Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                query = "Select * From Table_Product ";
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, !checkedListBox1.GetItemChecked(checkedListBox1.SelectedIndex));

                
                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    query += "Where";
                    foreach (string title in checkedListBox1.CheckedItems)
                    {
                        if (checkedListBox1.CheckedItems[0].ToString() == title)
                            query += $" productBrand = '{title}'";
                        else
                            query += $" Or productBrand = '{title}'";
                    }
                        
                }
                MessageBox.Show(query);
                ListProducts(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Marka Seçimi Hatası");
            }
        }
    }
}
