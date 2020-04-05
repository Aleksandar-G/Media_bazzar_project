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
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.cbWorkshifts = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbPhone = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnEditShifts = new System.Windows.Forms.Button();
            this.btnAssignShfitsPerMonth = new System.Windows.Forms.Button();
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
            this.btnClose.Location = new System.Drawing.Point(1007, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 55);
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
            this.lblEditEmployee.Location = new System.Drawing.Point(365, 38);
            this.lblEditEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.lblEditEmployee.Name = "lblEditEmployee";
            this.lblEditEmployee.Size = new System.Drawing.Size(246, 46);
            this.lblEditEmployee.TabIndex = 11;
            this.lblEditEmployee.Text = "Edit Employee";
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDepartments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.ItemHeight = 32;
            this.cbDepartments.Location = new System.Drawing.Point(225, 384);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(541, 40);
            this.cbDepartments.TabIndex = 12;
            // 
            // cbWorkshifts
            // 
            this.cbWorkshifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkshifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWorkshifts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkshifts.FormattingEnabled = true;
            this.cbWorkshifts.ItemHeight = 32;
            this.cbWorkshifts.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbWorkshifts.Location = new System.Drawing.Point(225, 457);
            this.cbWorkshifts.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkshifts.Name = "cbWorkshifts";
            this.cbWorkshifts.Size = new System.Drawing.Size(541, 40);
            this.cbWorkshifts.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(225, 516);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(230, 60);
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
            this.btnRemove.Location = new System.Drawing.Point(536, 516);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(230, 60);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.BtnRemove_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.BtnRemove_MouseLeave);
            // 
            // tbPhone
            // 
            this.tbPhone.BeforeTouchSize = new System.Drawing.Size(541, 39);
            this.tbPhone.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(225, 318);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(541, 39);
            this.tbPhone.TabIndex = 24;
            this.tbPhone.Text = "Phone";
            this.tbPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbPhone_MouseClick);
            // 
            // tbEmail
            // 
            this.tbEmail.BeforeTouchSize = new System.Drawing.Size(541, 39);
            this.tbEmail.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(225, 247);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(541, 39);
            this.tbEmail.TabIndex = 23;
            this.tbEmail.Text = "Email";
            this.tbEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbEmail_MouseClick);
            // 
            // tbName
            // 
            this.tbName.BeforeTouchSize = new System.Drawing.Size(541, 39);
            this.tbName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(225, 180);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(541, 39);
            this.tbName.TabIndex = 22;
            this.tbName.Text = "Name";
            this.tbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbName_MouseClick);
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.ItemHeight = 32;
            this.cbRole.Items.AddRange(new object[] {
            "Worker",
            "Administrator",
            "Manager"});
            this.cbRole.Location = new System.Drawing.Point(225, 112);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(541, 40);
            this.cbRole.TabIndex = 25;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.CbRole_SelectedIndexChanged);
            // 
            // btnEditShifts
            // 
            this.btnEditShifts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShifts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShifts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditShifts.Location = new System.Drawing.Point(225, 598);
            this.btnEditShifts.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditShifts.Name = "btnEditShifts";
            this.btnEditShifts.Size = new System.Drawing.Size(230, 77);
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
            this.btnAssignShfitsPerMonth.Location = new System.Drawing.Point(536, 598);
            this.btnAssignShfitsPerMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssignShfitsPerMonth.Name = "btnAssignShfitsPerMonth";
            this.btnAssignShfitsPerMonth.Size = new System.Drawing.Size(230, 77);
            this.btnAssignShfitsPerMonth.TabIndex = 27;
            this.btnAssignShfitsPerMonth.Text = "Assign Shift (month)";
            this.btnAssignShfitsPerMonth.UseVisualStyleBackColor = true;
            this.btnAssignShfitsPerMonth.Visible = false;
            this.btnAssignShfitsPerMonth.Click += new System.EventHandler(this.BtnAssignShfitsPerMonth_Click);
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.btnAssignShfitsPerMonth);
            this.Controls.Add(this.btnEditShifts);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbWorkshifts);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.lblEditEmployee);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployee";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEditEmployee;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.ComboBox cbWorkshifts;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbPhone;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbEmail;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnEditShifts;
        private System.Windows.Forms.Button btnAssignShfitsPerMonth;
    }
}