namespace MediaBazaar
{
    partial class EditEmployeeForm
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
            this.lblEditEmployee = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEditShifts = new System.Windows.Forms.Button();
            this.btnAssignShfitsPerMonth = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tbSalary = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dtbBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.tbPhone = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(755, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblEditEmployee
            // 
            this.lblEditEmployee.AutoSize = true;
            this.lblEditEmployee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmployee.ForeColor = System.Drawing.Color.Snow;
            this.lblEditEmployee.Location = new System.Drawing.Point(270, 7);
            this.lblEditEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.lblEditEmployee.Name = "lblEditEmployee";
            this.lblEditEmployee.Size = new System.Drawing.Size(200, 37);
            this.lblEditEmployee.TabIndex = 11;
            this.lblEditEmployee.Text = "Edit Employee";
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(171, 541);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(172, 49);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.BtnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.BtnEdit_MouseLeave);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(404, 541);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(172, 49);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.BtnRemove_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.BtnRemove_MouseLeave);
            // 
            // btnEditShifts
            // 
            this.btnEditShifts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShifts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShifts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditShifts.Location = new System.Drawing.Point(171, 608);
            this.btnEditShifts.Name = "btnEditShifts";
            this.btnEditShifts.Size = new System.Drawing.Size(172, 63);
            this.btnEditShifts.TabIndex = 26;
            this.btnEditShifts.Text = "Assign Shift \r\n(day)";
            this.btnEditShifts.UseVisualStyleBackColor = true;
            this.btnEditShifts.Visible = false;
            this.btnEditShifts.Click += new System.EventHandler(this.BtnEditShifts_Click);
            // 
            // btnAssignShfitsPerMonth
            // 
            this.btnAssignShfitsPerMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignShfitsPerMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignShfitsPerMonth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignShfitsPerMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAssignShfitsPerMonth.Location = new System.Drawing.Point(404, 608);
            this.btnAssignShfitsPerMonth.Name = "btnAssignShfitsPerMonth";
            this.btnAssignShfitsPerMonth.Size = new System.Drawing.Size(172, 63);
            this.btnAssignShfitsPerMonth.TabIndex = 27;
            this.btnAssignShfitsPerMonth.Text = "Assign Shift (month)";
            this.btnAssignShfitsPerMonth.UseVisualStyleBackColor = true;
            this.btnAssignShfitsPerMonth.Visible = false;
            this.btnAssignShfitsPerMonth.Click += new System.EventHandler(this.BtnAssignShfitsPerMonth_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Snow;
            this.lblSalary.Location = new System.Drawing.Point(166, 385);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(63, 25);
            this.lblSalary.TabIndex = 45;
            this.lblSalary.Text = "Salary";
            // 
            // tbSalary
            // 
            this.tbSalary.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbSalary.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbSalary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(171, 413);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(407, 33);
            this.tbSalary.TabIndex = 44;
            // 
            // dtbBirthday
            // 
            this.dtbBirthday.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbBirthday.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbBirthday.Location = new System.Drawing.Point(171, 341);
            this.dtbBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dtbBirthday.Name = "dtbBirthday";
            this.dtbBirthday.Size = new System.Drawing.Size(407, 33);
            this.dtbBirthday.TabIndex = 43;
            this.dtbBirthday.Value = new System.DateTime(2020, 4, 2, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(166, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(166, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(166, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(166, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(166, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name";
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDepartments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.ItemHeight = 25;
            this.cbDepartments.Location = new System.Drawing.Point(171, 483);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(407, 33);
            this.cbDepartments.TabIndex = 37;
            this.cbDepartments.Visible = false;
            // 
            // tbPhone
            // 
            this.tbPhone.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbPhone.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(171, 269);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(407, 33);
            this.tbPhone.TabIndex = 36;
            // 
            // tbEmail
            // 
            this.tbEmail.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbEmail.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(171, 200);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(407, 33);
            this.tbEmail.TabIndex = 35;
            // 
            // tbName
            // 
            this.tbName.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(171, 129);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(407, 33);
            this.tbName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(164, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Role";
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
            this.cbRole.Location = new System.Drawing.Point(169, 65);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(407, 33);
            this.cbRole.TabIndex = 46;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.dtbBirthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAssignShfitsPerMonth);
            this.Controls.Add(this.btnEditShifts);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblEditEmployee);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployee";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tbSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEditEmployee;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEditShifts;
        private System.Windows.Forms.Button btnAssignShfitsPerMonth;
        private System.Windows.Forms.Label lblSalary;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbSalary;
        private System.Windows.Forms.DateTimePicker dtbBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepartments;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbPhone;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbEmail;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRole;
    }
}