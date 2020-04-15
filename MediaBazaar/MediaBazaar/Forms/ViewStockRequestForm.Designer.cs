namespace MediaBazaar.Forms
{
    partial class ViewStockRequestForm
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
            this.lbDepartment = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.lbDepartment.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbDepartment.Location = new System.Drawing.Point(92, 83);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(58, 21);
            this.lbDepartment.TabIndex = 1;
            this.lbDepartment.Text = "label2";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(395, -7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProducts.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.lbProducts.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 21;
            this.lbProducts.Location = new System.Drawing.Point(95, 180);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(321, 252);
            this.lbProducts.TabIndex = 19;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lbHeader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbHeader.Location = new System.Drawing.Point(91, 19);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(219, 28);
            this.lbHeader.TabIndex = 20;
            this.lbHeader.Text = "StockRequest Details";
            // 
            // ViewStockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(438, 491);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStockRequestForm";
            this.Text = "ViewStockRequestForm";
            this.Load += new System.EventHandler(this.ViewStockRequestForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewStockRequestForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewStockRequestForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewStockRequestForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label lbHeader;
    }
}