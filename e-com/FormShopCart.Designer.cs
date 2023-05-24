namespace e_com
{
    partial class FormShopCart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCompleteShopping = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCompleteShopping);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(557, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sepet Tutarı:";
            // 
            // buttonCompleteShopping
            // 
            this.buttonCompleteShopping.BackColor = System.Drawing.Color.Orange;
            this.buttonCompleteShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCompleteShopping.ForeColor = System.Drawing.Color.White;
            this.buttonCompleteShopping.Location = new System.Drawing.Point(6, 117);
            this.buttonCompleteShopping.Name = "buttonCompleteShopping";
            this.buttonCompleteShopping.Size = new System.Drawing.Size(196, 53);
            this.buttonCompleteShopping.TabIndex = 1;
            this.buttonCompleteShopping.Text = "Alışverişi Tamamla";
            this.buttonCompleteShopping.UseVisualStyleBackColor = false;
            this.buttonCompleteShopping.Click += new System.EventHandler(this.buttonCompleteShopping_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotal.Location = new System.Drawing.Point(15, 57);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(92, 31);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 497);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(541, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 497);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // FormShopCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(777, 497);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormShopCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormShopCart";
            this.Load += new System.EventHandler(this.FormShopCart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCompleteShopping;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Splitter splitter1;
    }
}