﻿namespace MediaBazaar.Forms
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
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.lblQuantityTag = new System.Windows.Forms.Label();
            this.lblItemDepartment = new System.Windows.Forms.Label();
            this.lblProductTag = new System.Windows.Forms.Label();
            this.lblDepartmentTag = new System.Windows.Forms.Label();
            this.lblDescriptionTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(311, -1);
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
            this.label1.Size = new System.Drawing.Size(259, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Info";
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(48, 116);
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
            this.lblDescription.Location = new System.Drawing.Point(48, 297);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(275, 111);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "ItemDescription";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.White;
            this.lblItemPrice.Location = new System.Drawing.Point(54, 441);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(114, 32);
            this.lblItemPrice.TabIndex = 19;
            this.lblItemPrice.Text = "ItemPrice";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantity.ForeColor = System.Drawing.Color.White;
            this.lblItemQuantity.Location = new System.Drawing.Point(197, 441);
            this.lblItemQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(107, 32);
            this.lblItemQuantity.TabIndex = 20;
            this.lblItemQuantity.Text = "Quantity";
            // 
            // lblPriceTag
            // 
            this.lblPriceTag.AutoSize = true;
            this.lblPriceTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTag.ForeColor = System.Drawing.Color.White;
            this.lblPriceTag.Location = new System.Drawing.Point(53, 409);
            this.lblPriceTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceTag.Name = "lblPriceTag";
            this.lblPriceTag.Size = new System.Drawing.Size(89, 38);
            this.lblPriceTag.TabIndex = 21;
            this.lblPriceTag.Text = "Price:";
            // 
            // lblQuantityTag
            // 
            this.lblQuantityTag.AutoSize = true;
            this.lblQuantityTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityTag.ForeColor = System.Drawing.Color.White;
            this.lblQuantityTag.Location = new System.Drawing.Point(197, 409);
            this.lblQuantityTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityTag.Name = "lblQuantityTag";
            this.lblQuantityTag.Size = new System.Drawing.Size(140, 38);
            this.lblQuantityTag.TabIndex = 22;
            this.lblQuantityTag.Text = "Quantity:";
            // 
            // lblItemDepartment
            // 
            this.lblItemDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDepartment.ForeColor = System.Drawing.Color.White;
            this.lblItemDepartment.Location = new System.Drawing.Point(48, 209);
            this.lblItemDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemDepartment.Name = "lblItemDepartment";
            this.lblItemDepartment.Size = new System.Drawing.Size(275, 32);
            this.lblItemDepartment.TabIndex = 23;
            this.lblItemDepartment.Text = "ItemDepartment";
            // 
            // lblProductTag
            // 
            this.lblProductTag.AutoSize = true;
            this.lblProductTag.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblProductTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTag.ForeColor = System.Drawing.Color.White;
            this.lblProductTag.Location = new System.Drawing.Point(47, 78);
            this.lblProductTag.Name = "lblProductTag";
            this.lblProductTag.Size = new System.Drawing.Size(128, 38);
            this.lblProductTag.TabIndex = 24;
            this.lblProductTag.Text = "Product:";
            // 
            // lblDepartmentTag
            // 
            this.lblDepartmentTag.AutoSize = true;
            this.lblDepartmentTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentTag.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentTag.Location = new System.Drawing.Point(47, 171);
            this.lblDepartmentTag.Name = "lblDepartmentTag";
            this.lblDepartmentTag.Size = new System.Drawing.Size(185, 38);
            this.lblDepartmentTag.TabIndex = 25;
            this.lblDepartmentTag.Text = "Department:";
            // 
            // lblDescriptionTag
            // 
            this.lblDescriptionTag.AutoSize = true;
            this.lblDescriptionTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTag.ForeColor = System.Drawing.Color.White;
            this.lblDescriptionTag.Location = new System.Drawing.Point(47, 259);
            this.lblDescriptionTag.Name = "lblDescriptionTag";
            this.lblDescriptionTag.Size = new System.Drawing.Size(175, 38);
            this.lblDescriptionTag.TabIndex = 26;
            this.lblDescriptionTag.Text = "Description:";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(360, 511);
            this.Controls.Add(this.lblDescriptionTag);
            this.Controls.Add(this.lblDepartmentTag);
            this.Controls.Add(this.lblProductTag);
            this.Controls.Add(this.lblItemDepartment);
            this.Controls.Add(this.lblQuantityTag);
            this.Controls.Add(this.lblPriceTag);
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
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblPriceTag;
        private System.Windows.Forms.Label lblQuantityTag;
        private System.Windows.Forms.Label lblItemDepartment;
        private System.Windows.Forms.Label lblProductTag;
        private System.Windows.Forms.Label lblDepartmentTag;
        private System.Windows.Forms.Label lblDescriptionTag;
    }
}