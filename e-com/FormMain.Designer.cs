namespace e_com
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.buttonPriceFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.groupBoxTrade = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBoxPrice.SuspendLayout();
            this.groupBoxTrade.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBoxPrice);
            this.panel1.Controls.Add(this.groupBoxTrade);
            this.panel1.Controls.Add(this.groupBoxCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 744);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "ürün ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.buttonPriceFilter);
            this.groupBoxPrice.Controls.Add(this.label1);
            this.groupBoxPrice.Controls.Add(this.textBoxMaxPrice);
            this.groupBoxPrice.Controls.Add(this.textBoxMinPrice);
            this.groupBoxPrice.ForeColor = System.Drawing.Color.White;
            this.groupBoxPrice.Location = new System.Drawing.Point(3, 570);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(243, 65);
            this.groupBoxPrice.TabIndex = 2;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Fiyat Aralığı:";
            // 
            // buttonPriceFilter
            // 
            this.buttonPriceFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPriceFilter.ForeColor = System.Drawing.Color.Black;
            this.buttonPriceFilter.Location = new System.Drawing.Point(189, 12);
            this.buttonPriceFilter.Name = "buttonPriceFilter";
            this.buttonPriceFilter.Size = new System.Drawing.Size(44, 43);
            this.buttonPriceFilter.TabIndex = 2;
            this.buttonPriceFilter.Text = "";
            this.buttonPriceFilter.UseVisualStyleBackColor = true;
            this.buttonPriceFilter.Click += new System.EventHandler(this.buttonPriceFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(112, 26);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(71, 24);
            this.textBoxMaxPrice.TabIndex = 0;
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(7, 26);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(71, 24);
            this.textBoxMinPrice.TabIndex = 0;
            this.textBoxMinPrice.Text = "Placeholder yap";
            // 
            // groupBoxTrade
            // 
            this.groupBoxTrade.Controls.Add(this.checkedListBox1);
            this.groupBoxTrade.ForeColor = System.Drawing.Color.White;
            this.groupBoxTrade.Location = new System.Drawing.Point(3, 346);
            this.groupBoxTrade.Name = "groupBoxTrade";
            this.groupBoxTrade.Size = new System.Drawing.Size(243, 210);
            this.groupBoxTrade.TabIndex = 1;
            this.groupBoxTrade.TabStop = false;
            this.groupBoxTrade.Text = "Marka:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 24);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(230, 175);
            this.checkedListBox1.TabIndex = 0;
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.treeView1);
            this.groupBoxCategory.ForeColor = System.Drawing.Color.White;
            this.groupBoxCategory.Location = new System.Drawing.Point(3, 53);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(243, 279);
            this.groupBoxCategory.TabIndex = 0;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Kategori:";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.treeView1.Location = new System.Drawing.Point(6, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(231, 250);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(214, 214);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(256, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(729, 744);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(985, 744);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            this.groupBoxTrade.ResumeLayout(false);
            this.groupBoxCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.Button buttonPriceFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.GroupBox groupBoxTrade;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ImageList imageList1;
    }
}