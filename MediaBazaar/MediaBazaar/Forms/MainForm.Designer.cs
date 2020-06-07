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
            this.btnAddWorkShiftsPerMonth = new System.Windows.Forms.Button();
            this.btnAddShiftsPerDay = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnViewStockRequests = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.btnViewWorkshifts = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.tbSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSearch)).BeginInit();
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
            this.navigation.Controls.Add(this.button1);
            this.navigation.Controls.Add(this.btnAddWorkShiftsPerMonth);
            this.navigation.Controls.Add(this.btnAddShiftsPerDay);
            this.navigation.Controls.Add(this.btnProducts);
            this.navigation.Controls.Add(this.btnViewStockRequests);
            this.navigation.Controls.Add(this.btnViewStatistics);
            this.navigation.Controls.Add(this.btnViewWorkshifts);
            this.navigation.Controls.Add(this.btnAddDepartment);
            this.navigation.Controls.Add(this.btnAddEmployee);
            this.navigation.Controls.Add(this.pictureBox1);
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.Margin = new System.Windows.Forms.Padding(0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(270, 724);
            this.navigation.TabIndex = 0;
            this.navigation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Navigation_MouseDown);
            this.navigation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Navigation_MouseMove);
            this.navigation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Navigation_MouseUp);
            // 
            // btnAddWorkShiftsPerMonth
            // 
            this.btnAddWorkShiftsPerMonth.BackColor = System.Drawing.Color.White;
            this.btnAddWorkShiftsPerMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWorkShiftsPerMonth.FlatAppearance.BorderSize = 0;
            this.btnAddWorkShiftsPerMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkShiftsPerMonth.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddWorkShiftsPerMonth.Location = new System.Drawing.Point(0, 259);
            this.btnAddWorkShiftsPerMonth.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddWorkShiftsPerMonth.Name = "btnAddWorkShiftsPerMonth";
            this.btnAddWorkShiftsPerMonth.Size = new System.Drawing.Size(270, 52);
            this.btnAddWorkShiftsPerMonth.TabIndex = 20;
            this.btnAddWorkShiftsPerMonth.Text = "Add Shifts per month";
            this.btnAddWorkShiftsPerMonth.UseVisualStyleBackColor = false;
            this.btnAddWorkShiftsPerMonth.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAddShiftsPerDay
            // 
            this.btnAddShiftsPerDay.BackColor = System.Drawing.Color.White;
            this.btnAddShiftsPerDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddShiftsPerDay.FlatAppearance.BorderSize = 0;
            this.btnAddShiftsPerDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShiftsPerDay.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddShiftsPerDay.Location = new System.Drawing.Point(0, 191);
            this.btnAddShiftsPerDay.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddShiftsPerDay.Name = "btnAddShiftsPerDay";
            this.btnAddShiftsPerDay.Size = new System.Drawing.Size(270, 52);
            this.btnAddShiftsPerDay.TabIndex = 19;
            this.btnAddShiftsPerDay.Text = "Add Shifts per day";
            this.btnAddShiftsPerDay.UseVisualStyleBackColor = false;
            this.btnAddShiftsPerDay.Click += new System.EventHandler(this.btnAddShiftsPerDay_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.White;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnProducts.Location = new System.Drawing.Point(0, 128);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(270, 49);
            this.btnProducts.TabIndex = 18;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // btnViewStockRequests
            // 
            this.btnViewStockRequests.BackColor = System.Drawing.Color.White;
            this.btnViewStockRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStockRequests.FlatAppearance.BorderSize = 0;
            this.btnViewStockRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStockRequests.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnViewStockRequests.Location = new System.Drawing.Point(0, 587);
            this.btnViewStockRequests.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewStockRequests.Name = "btnViewStockRequests";
            this.btnViewStockRequests.Size = new System.Drawing.Size(270, 52);
            this.btnViewStockRequests.TabIndex = 17;
            this.btnViewStockRequests.Text = "Stock Requests";
            this.btnViewStockRequests.UseVisualStyleBackColor = false;
            this.btnViewStockRequests.Click += new System.EventHandler(this.btnViewStockRequests_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.BackColor = System.Drawing.Color.White;
            this.btnViewStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStatistics.FlatAppearance.BorderSize = 0;
            this.btnViewStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatistics.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnViewStatistics.Location = new System.Drawing.Point(0, 654);
            this.btnViewStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(270, 56);
            this.btnViewStatistics.TabIndex = 16;
            this.btnViewStatistics.Text = "Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = false;
            this.btnViewStatistics.Click += new System.EventHandler(this.BtnViewStatistics_Click);
            // 
            // btnViewWorkshifts
            // 
            this.btnViewWorkshifts.BackColor = System.Drawing.Color.White;
            this.btnViewWorkshifts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewWorkshifts.FlatAppearance.BorderSize = 0;
            this.btnViewWorkshifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewWorkshifts.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnViewWorkshifts.Location = new System.Drawing.Point(0, 328);
            this.btnViewWorkshifts.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewWorkshifts.Name = "btnViewWorkshifts";
            this.btnViewWorkshifts.Size = new System.Drawing.Size(270, 52);
            this.btnViewWorkshifts.TabIndex = 18;
            this.btnViewWorkshifts.Text = "View Shifts";
            this.btnViewWorkshifts.UseVisualStyleBackColor = false;
            this.btnViewWorkshifts.Click += new System.EventHandler(this.BtnViewWorkshifts_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.White;
            this.btnAddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartment.FlatAppearance.BorderSize = 0;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddDepartment.Location = new System.Drawing.Point(0, 526);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(270, 48);
            this.btnAddDepartment.TabIndex = 15;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.White;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 463);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(270, 48);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaBazaar.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(88, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // flpEmployees
            // 
            this.flpEmployees.AutoScroll = true;
            this.flpEmployees.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEmployees.Location = new System.Drawing.Point(309, 128);
            this.flpEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(655, 569);
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
            // tbSearch
            // 
            this.tbSearch.BeforeTouchSize = new System.Drawing.Size(657, 29);
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(307, 84);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(657, 29);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.TextChanged += new System.EventHandler(this.TextBoxExt1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Employees";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.Location = new System.Drawing.Point(0, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 52);
            this.button1.TabIndex = 21;
            this.button1.Text = "Automatically Assign Shifts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(999, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.flpEmployees);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel navigation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.FlowLayoutPanel flpEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbSearch;
        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.Button btnViewStockRequests;
        private System.Windows.Forms.Button btnViewWorkshifts;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddWorkShiftsPerMonth;
        private System.Windows.Forms.Button btnAddShiftsPerDay;
        private System.Windows.Forms.Button button1;
    }
}