namespace MediaBazaar
{
    partial class MainForm
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
            this.navigation = new System.Windows.Forms.Panel();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnViewStockRequests = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(955, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.SystemColors.WindowText;
            this.navigation.Controls.Add(this.btnViewStockRequests);
            this.navigation.Controls.Add(this.btnViewStatistics);
            this.navigation.Controls.Add(this.button1);
            this.navigation.Controls.Add(this.button2);
            this.navigation.Controls.Add(this.pictureBox1);
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.Margin = new System.Windows.Forms.Padding(0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(250, 450);
            this.navigation.TabIndex = 0;
            this.navigation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Navigation_MouseDown);
            this.navigation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Navigation_MouseMove);
            this.navigation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Navigation_MouseUp);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.BackColor = System.Drawing.Color.White;
            this.btnViewStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStatistics.FlatAppearance.BorderSize = 0;
            this.btnViewStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatistics.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnViewStatistics.Location = new System.Drawing.Point(0, 280);
            this.btnViewStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(250, 65);
            this.btnViewStatistics.TabIndex = 16;
            this.btnViewStatistics.Text = "View Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = false;
            this.btnViewStatistics.Click += new System.EventHandler(this.BtnViewStatistics_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(0, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 65);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Department";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button2.Location = new System.Drawing.Point(0, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 65);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add Employee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // flpEmployees
            // 
            this.flpEmployees.AutoScroll = true;
            this.flpEmployees.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEmployees.Location = new System.Drawing.Point(290, 102);
            this.flpEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(653, 330);
            this.flpEmployees.TabIndex = 16;
            this.flpEmployees.WrapContents = false;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmployees.Location = new System.Drawing.Point(558, 13);
            this.lblEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(137, 32);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "Employees";
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(262, 33);
            this.textBoxExt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt1.Location = new System.Drawing.Point(290, 59);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(655, 29);
            this.textBoxExt1.TabIndex = 17;
            this.textBoxExt1.Text = "Search";
            // 
            // btnViewStockRequests
            // 
            this.btnViewStockRequests.BackColor = System.Drawing.Color.White;
            this.btnViewStockRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStockRequests.FlatAppearance.BorderSize = 0;
            this.btnViewStockRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStockRequests.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnViewStockRequests.Location = new System.Drawing.Point(0, 356);
            this.btnViewStockRequests.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewStockRequests.Name = "btnViewStockRequests";
            this.btnViewStockRequests.Size = new System.Drawing.Size(250, 65);
            this.btnViewStockRequests.TabIndex = 17;
            this.btnViewStockRequests.Text = "View Stock Requests";
            this.btnViewStockRequests.UseVisualStyleBackColor = false;
            this.btnViewStockRequests.Click += new System.EventHandler(this.btnViewStockRequests_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaBazaar.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(78, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.textBoxExt1);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.flpEmployees);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel navigation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.Button btnViewStockRequests;
    }
}