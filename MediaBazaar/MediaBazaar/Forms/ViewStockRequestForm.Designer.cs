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
            this.lbAdmin = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.lbAdmin.Location = new System.Drawing.Point(213, 87);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(56, 21);
            this.lbAdmin.TabIndex = 0;
            this.lbAdmin.Text = "label1";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.lbDepartment.Location = new System.Drawing.Point(475, 87);
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
            this.btnClose.Location = new System.Drawing.Point(757, 0);
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
            this.lbProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProducts.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 21;
            this.lbProducts.Location = new System.Drawing.Point(306, 166);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(349, 231);
            this.lbProducts.TabIndex = 19;
            // 
            // ViewStockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbAdmin);
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

        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbProducts;
    }
}