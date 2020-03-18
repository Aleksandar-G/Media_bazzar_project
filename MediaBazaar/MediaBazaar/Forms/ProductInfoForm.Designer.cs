namespace MediaBazaar.Forms
{
    partial class ProductInfoForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(331, -2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 55);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Info";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(43, 129);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(99, 25);
            this.lblItemName.TabIndex = 17;
            this.lblItemName.Text = "ItemName";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(43, 220);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(145, 25);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "ItemDescription";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.White;
            this.lblItemPrice.Location = new System.Drawing.Point(43, 311);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(91, 25);
            this.lblItemPrice.TabIndex = 19;
            this.lblItemPrice.Text = "ItemPrice";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantity.ForeColor = System.Drawing.Color.White;
            this.lblItemQuantity.Location = new System.Drawing.Point(43, 402);
            this.lblItemQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(84, 25);
            this.lblItemQuantity.TabIndex = 20;
            this.lblItemQuantity.Text = "Quantity";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(386, 478);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfoForm";
            this.Text = "ProductInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemQuantity;
    }
}