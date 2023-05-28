namespace e_com
{
    partial class FormCompleteShopping
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
            this.textBoxCreditCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVerifyCode = new System.Windows.Forms.TextBox();
            this.buttonConfirmOrder = new System.Windows.Forms.Button();
            this.buttonSendCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCreditCard
            // 
            this.textBoxCreditCard.Location = new System.Drawing.Point(171, 13);
            this.textBoxCreditCard.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCreditCard.Name = "textBoxCreditCard";
            this.textBoxCreditCard.Size = new System.Drawing.Size(148, 24);
            this.textBoxCreditCard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kart Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğrulama Kodu:";
            // 
            // textBoxVerifyCode
            // 
            this.textBoxVerifyCode.Enabled = false;
            this.textBoxVerifyCode.Location = new System.Drawing.Point(171, 112);
            this.textBoxVerifyCode.Name = "textBoxVerifyCode";
            this.textBoxVerifyCode.Size = new System.Drawing.Size(148, 24);
            this.textBoxVerifyCode.TabIndex = 3;
            // 
            // buttonConfirmOrder
            // 
            this.buttonConfirmOrder.Enabled = false;
            this.buttonConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConfirmOrder.Location = new System.Drawing.Point(171, 152);
            this.buttonConfirmOrder.Name = "buttonConfirmOrder";
            this.buttonConfirmOrder.Size = new System.Drawing.Size(148, 43);
            this.buttonConfirmOrder.TabIndex = 4;
            this.buttonConfirmOrder.Text = "Siparişi Onayla";
            this.buttonConfirmOrder.UseVisualStyleBackColor = true;
            this.buttonConfirmOrder.Click += new System.EventHandler(this.buttonConfirmOrder_Click);
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSendCode.Location = new System.Drawing.Point(171, 53);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(148, 43);
            this.buttonSendCode.TabIndex = 5;
            this.buttonSendCode.Text = "Kod Gönder";
            this.buttonSendCode.UseVisualStyleBackColor = true;
            this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_Click);
            // 
            // FormCompleteShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(360, 219);
            this.Controls.Add(this.buttonSendCode);
            this.Controls.Add(this.buttonConfirmOrder);
            this.Controls.Add(this.textBoxVerifyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCreditCard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCompleteShopping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.FormCompleteShopping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCreditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVerifyCode;
        private System.Windows.Forms.Button buttonConfirmOrder;
        private System.Windows.Forms.Button buttonSendCode;
    }
}