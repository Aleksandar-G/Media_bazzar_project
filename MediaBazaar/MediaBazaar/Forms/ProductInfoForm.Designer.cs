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
            this.lblItemDepartment = new System.Windows.Forms.Label();
            this.lblProductTag = new System.Windows.Forms.Label();
            this.lblDepartmentTag = new System.Windows.Forms.Label();
            this.lblDescriptionTag = new System.Windows.Forms.Label();
            this.lblQuantityTag = new System.Windows.Forms.Label();
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblBuyingPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinQuantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(331, -2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 48);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Info";
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(25, 105);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(259, 34);
            this.lblItemName.TabIndex = 17;
            this.lblItemName.Text = "ItemName";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(27, 405);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(305, 77);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "ItemDescription";
            // 
            // lblItemDepartment
            // 
            this.lblItemDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDepartment.ForeColor = System.Drawing.Color.White;
            this.lblItemDepartment.Location = new System.Drawing.Point(26, 178);
            this.lblItemDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemDepartment.Name = "lblItemDepartment";
            this.lblItemDepartment.Size = new System.Drawing.Size(275, 32);
            this.lblItemDepartment.TabIndex = 23;
            this.lblItemDepartment.Text = "ItemDepartment";
            // 
            // lblProductTag
            // 
            this.lblProductTag.AutoSize = true;
            this.lblProductTag.BackColor = System.Drawing.Color.Transparent;
            this.lblProductTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTag.ForeColor = System.Drawing.Color.White;
            this.lblProductTag.Location = new System.Drawing.Point(24, 80);
            this.lblProductTag.Name = "lblProductTag";
            this.lblProductTag.Size = new System.Drawing.Size(89, 25);
            this.lblProductTag.TabIndex = 24;
            this.lblProductTag.Text = "Product:";
            // 
            // lblDepartmentTag
            // 
            this.lblDepartmentTag.AutoSize = true;
            this.lblDepartmentTag.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentTag.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentTag.Location = new System.Drawing.Point(25, 153);
            this.lblDepartmentTag.Name = "lblDepartmentTag";
            this.lblDepartmentTag.Size = new System.Drawing.Size(125, 25);
            this.lblDepartmentTag.TabIndex = 25;
            this.lblDepartmentTag.Text = "Department:";
            // 
            // lblDescriptionTag
            // 
            this.lblDescriptionTag.AutoSize = true;
            this.lblDescriptionTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTag.ForeColor = System.Drawing.Color.White;
            this.lblDescriptionTag.Location = new System.Drawing.Point(26, 369);
            this.lblDescriptionTag.Name = "lblDescriptionTag";
            this.lblDescriptionTag.Size = new System.Drawing.Size(119, 25);
            this.lblDescriptionTag.TabIndex = 26;
            this.lblDescriptionTag.Text = "Description:";
            // 
            // lblQuantityTag
            // 
            this.lblQuantityTag.AutoSize = true;
            this.lblQuantityTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityTag.ForeColor = System.Drawing.Color.White;
            this.lblQuantityTag.Location = new System.Drawing.Point(26, 296);
            this.lblQuantityTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityTag.Name = "lblQuantityTag";
            this.lblQuantityTag.Size = new System.Drawing.Size(94, 25);
            this.lblQuantityTag.TabIndex = 30;
            this.lblQuantityTag.Text = "Quantity:";
            // 
            // lblPriceTag
            // 
            this.lblPriceTag.AutoSize = true;
            this.lblPriceTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTag.ForeColor = System.Drawing.Color.White;
            this.lblPriceTag.Location = new System.Drawing.Point(26, 219);
            this.lblPriceTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceTag.Name = "lblPriceTag";
            this.lblPriceTag.Size = new System.Drawing.Size(129, 25);
            this.lblPriceTag.TabIndex = 29;
            this.lblPriceTag.Text = "Buying Price:";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantity.ForeColor = System.Drawing.Color.White;
            this.lblItemQuantity.Location = new System.Drawing.Point(26, 328);
            this.lblItemQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(70, 21);
            this.lblItemQuantity.TabIndex = 28;
            this.lblItemQuantity.Text = "Quantity";
            // 
            // lblBuyingPrice
            // 
            this.lblBuyingPrice.AutoSize = true;
            this.lblBuyingPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyingPrice.ForeColor = System.Drawing.Color.White;
            this.lblBuyingPrice.Location = new System.Drawing.Point(27, 251);
            this.lblBuyingPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyingPrice.Name = "lblBuyingPrice";
            this.lblBuyingPrice.Size = new System.Drawing.Size(75, 21);
            this.lblBuyingPrice.TabIndex = 27;
            this.lblBuyingPrice.Text = "ItemPrice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Minimum Quantity:";
            // 
            // lblMinQuantity
            // 
            this.lblMinQuantity.AutoSize = true;
            this.lblMinQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinQuantity.ForeColor = System.Drawing.Color.White;
            this.lblMinQuantity.Location = new System.Drawing.Point(176, 328);
            this.lblMinQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinQuantity.Name = "lblMinQuantity";
            this.lblMinQuantity.Size = new System.Drawing.Size(70, 21);
            this.lblMinQuantity.TabIndex = 31;
            this.lblMinQuantity.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Selling Price:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.ForeColor = System.Drawing.Color.White;
            this.lblSellingPrice.Location = new System.Drawing.Point(176, 251);
            this.lblSellingPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(75, 21);
            this.lblSellingPrice.TabIndex = 33;
            this.lblSellingPrice.Text = "ItemPrice";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(378, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMinQuantity);
            this.Controls.Add(this.lblQuantityTag);
            this.Controls.Add(this.lblPriceTag);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.lblBuyingPrice);
            this.Controls.Add(this.lblDescriptionTag);
            this.Controls.Add(this.lblDepartmentTag);
            this.Controls.Add(this.lblProductTag);
            this.Controls.Add(this.lblItemDepartment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfoForm";
            this.Text = "ProductInfo";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductInfoForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProductInfoForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProductInfoForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemDepartment;
        private System.Windows.Forms.Label lblProductTag;
        private System.Windows.Forms.Label lblDepartmentTag;
        private System.Windows.Forms.Label lblDescriptionTag;
        private System.Windows.Forms.Label lblQuantityTag;
        private System.Windows.Forms.Label lblPriceTag;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblBuyingPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSellingPrice;
    }
}