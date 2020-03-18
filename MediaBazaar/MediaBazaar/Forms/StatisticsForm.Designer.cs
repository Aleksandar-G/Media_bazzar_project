namespace MediaBazaar.Forms
{
    partial class StatisticsForm
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
            this.btnStatWorkersByDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.btnProductsByDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(742, -3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 55);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnStatWorkersByDepartment
            // 
            this.btnStatWorkersByDepartment.BackColor = System.Drawing.Color.Maroon;
            this.btnStatWorkersByDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatWorkersByDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatWorkersByDepartment.ForeColor = System.Drawing.Color.White;
            this.btnStatWorkersByDepartment.Location = new System.Drawing.Point(12, 227);
            this.btnStatWorkersByDepartment.Name = "btnStatWorkersByDepartment";
            this.btnStatWorkersByDepartment.Size = new System.Drawing.Size(260, 47);
            this.btnStatWorkersByDepartment.TabIndex = 14;
            this.btnStatWorkersByDepartment.Text = "Workers by department\r\n";
            this.btnStatWorkersByDepartment.UseVisualStyleBackColor = false;
            this.btnStatWorkersByDepartment.Click += new System.EventHandler(this.BtnStatWorkersByDepartment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "Media Bazaar Statistics";
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.BackColor = System.Drawing.Color.Maroon;
            this.cmbDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartments.ForeColor = System.Drawing.Color.White;
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(12, 105);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(260, 28);
            this.cmbDepartments.TabIndex = 18;
            // 
            // btnProductsByDepartment
            // 
            this.btnProductsByDepartment.BackColor = System.Drawing.Color.Maroon;
            this.btnProductsByDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductsByDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsByDepartment.ForeColor = System.Drawing.Color.White;
            this.btnProductsByDepartment.Location = new System.Drawing.Point(12, 314);
            this.btnProductsByDepartment.Name = "btnProductsByDepartment";
            this.btnProductsByDepartment.Size = new System.Drawing.Size(260, 47);
            this.btnProductsByDepartment.TabIndex = 19;
            this.btnProductsByDepartment.Text = "Products by department";
            this.btnProductsByDepartment.UseVisualStyleBackColor = false;
            this.btnProductsByDepartment.Click += new System.EventHandler(this.BtnProductsByDepartment_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.btnProductsByDepartment);
            this.Controls.Add(this.cmbDepartments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatWorkersByDepartment);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStatWorkersByDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.Button btnProductsByDepartment;
    }
}