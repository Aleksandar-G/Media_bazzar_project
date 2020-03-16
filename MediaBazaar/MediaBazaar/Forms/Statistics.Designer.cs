namespace MediaBazaar.Forms
{
    partial class Statistics
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatByDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.btnBestSeller = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(733, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 70);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaBazaar.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnStatByDepartment
            // 
            this.btnStatByDepartment.BackColor = System.Drawing.Color.Maroon;
            this.btnStatByDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatByDepartment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatByDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatByDepartment.Location = new System.Drawing.Point(0, 154);
            this.btnStatByDepartment.Name = "btnStatByDepartment";
            this.btnStatByDepartment.Size = new System.Drawing.Size(260, 47);
            this.btnStatByDepartment.TabIndex = 14;
            this.btnStatByDepartment.Text = "Statisics by department";
            this.btnStatByDepartment.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(218, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Media Bazaar Statistics";
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.BackColor = System.Drawing.Color.Maroon;
            this.cmbDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartments.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(0, 106);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(260, 28);
            this.cmbDepartments.TabIndex = 18;
            // 
            // btnBestSeller
            // 
            this.btnBestSeller.BackColor = System.Drawing.Color.Maroon;
            this.btnBestSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestSeller.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestSeller.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBestSeller.Location = new System.Drawing.Point(0, 207);
            this.btnBestSeller.Name = "btnBestSeller";
            this.btnBestSeller.Size = new System.Drawing.Size(260, 47);
            this.btnBestSeller.TabIndex = 19;
            this.btnBestSeller.Text = "Best-seller";
            this.btnBestSeller.UseVisualStyleBackColor = false;
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.BackColor = System.Drawing.Color.Maroon;
            this.btnLastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastWeek.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastWeek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLastWeek.Location = new System.Drawing.Point(0, 260);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(260, 47);
            this.btnLastWeek.TabIndex = 20;
            this.btnLastWeek.Text = "Last week summary";
            this.btnLastWeek.UseVisualStyleBackColor = false;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.btnLastWeek);
            this.Controls.Add(this.btnBestSeller);
            this.Controls.Add(this.cmbDepartments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatByDepartment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStatByDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.Button btnBestSeller;
        private System.Windows.Forms.Button btnLastWeek;
    }
}