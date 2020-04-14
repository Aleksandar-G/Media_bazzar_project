namespace MediaBazaar
{
    partial class AddEmployeeForm
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
            this.lblAddDepartment = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbPhone = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtbBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tbSalary = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.tbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(759, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblAddDepartment
            // 
            this.lblAddDepartment.AutoSize = true;
            this.lblAddDepartment.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDepartment.ForeColor = System.Drawing.Color.Snow;
            this.lblAddDepartment.Location = new System.Drawing.Point(299, 19);
            this.lblAddDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddDepartment.Name = "lblAddDepartment";
            this.lblAddDepartment.Size = new System.Drawing.Size(203, 37);
            this.lblAddDepartment.TabIndex = 11;
            this.lblAddDepartment.Text = "Add Employee";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(320, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 48);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.BtnAdd_MouseLeave);
            // 
            // tbName
            // 
            this.tbName.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(202, 163);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(407, 33);
            this.tbName.TabIndex = 18;
            // 
            // tbEmail
            // 
            this.tbEmail.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbEmail.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(202, 234);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(407, 33);
            this.tbEmail.TabIndex = 19;
            // 
            // tbPhone
            // 
            this.tbPhone.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbPhone.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(202, 303);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(407, 33);
            this.tbPhone.TabIndex = 20;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.ItemHeight = 25;
            this.cbRole.Items.AddRange(new object[] {
            "Worker",
            "Administrator",
            "Manager"});
            this.cbRole.Location = new System.Drawing.Point(202, 90);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(407, 33);
            this.cbRole.TabIndex = 21;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.CbRole_SelectedIndexChanged);
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDepartments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.ItemHeight = 25;
            this.cbDepartments.Location = new System.Drawing.Point(202, 517);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(407, 33);
            this.cbDepartments.TabIndex = 24;
            this.cbDepartments.Visible = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Snow;
            this.lblRole.Location = new System.Drawing.Point(197, 62);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 25);
            this.lblRole.TabIndex = 25;
            this.lblRole.Text = "Role";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Snow;
            this.lblName.Location = new System.Drawing.Point(197, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 25);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Snow;
            this.lblEmail.Location = new System.Drawing.Point(197, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 25);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Snow;
            this.lblPhone.Location = new System.Drawing.Point(197, 275);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 25);
            this.lblPhone.TabIndex = 28;
            this.lblPhone.Text = "Phone";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Snow;
            this.lblDepartment.Location = new System.Drawing.Point(197, 489);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(112, 25);
            this.lblDepartment.TabIndex = 29;
            this.lblDepartment.Text = "Department";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.Snow;
            this.lblBirthday.Location = new System.Drawing.Point(197, 348);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(82, 25);
            this.lblBirthday.TabIndex = 30;
            this.lblBirthday.Text = "Birthday";
            // 
            // dtbBirthday
            // 
            this.dtbBirthday.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbBirthday.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbBirthday.Location = new System.Drawing.Point(202, 375);
            this.dtbBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dtbBirthday.Name = "dtbBirthday";
            this.dtbBirthday.Size = new System.Drawing.Size(407, 33);
            this.dtbBirthday.TabIndex = 31;
            this.dtbBirthday.Value = new System.DateTime(2020, 4, 2, 0, 0, 0, 0);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Snow;
            this.lblSalary.Location = new System.Drawing.Point(197, 419);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(63, 25);
            this.lblSalary.TabIndex = 33;
            this.lblSalary.Text = "Salary";
            // 
            // tbSalary
            // 
            this.tbSalary.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbSalary.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(202, 447);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(407, 33);
            this.tbSalary.TabIndex = 32;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(805, 620);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.dtbBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddDepartment);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.Text = "EditEmployee";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAddDepartment;
        private System.Windows.Forms.Button btnAdd;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbEmail;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbPhone;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtbBirthday;
        private System.Windows.Forms.Label lblSalary;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbSalary;
    }
}