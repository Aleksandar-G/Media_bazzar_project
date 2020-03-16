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
            this.cbWorkshifts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone)).BeginInit();
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
            this.btnAdd.Location = new System.Drawing.Point(327, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 48);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.BtnAdd_MouseLeave);
            // 
            // tbName
            // 
            this.tbName.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(202, 142);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(407, 33);
            this.tbName.TabIndex = 18;
            this.tbName.Text = "Name";
            this.tbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbDepartmentName_MouseClick);
            // 
            // tbEmail
            // 
            this.tbEmail.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbEmail.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(202, 197);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(407, 33);
            this.tbEmail.TabIndex = 19;
            this.tbEmail.Text = "Email";
            this.tbEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbEmail_MouseClick);
            // 
            // tbPhone
            // 
            this.tbPhone.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbPhone.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(202, 254);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(407, 33);
            this.tbPhone.TabIndex = 20;
            this.tbPhone.Text = "Phone";
            this.tbPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbPhone_MouseClick);
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
            "Manager",
            "Role"});
            this.cbRole.Location = new System.Drawing.Point(202, 87);
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
            this.cbDepartments.Items.AddRange(new object[] {
            "Department 1",
            "Department 2",
            "Department 3",
            "Department 4"});
            this.cbDepartments.Location = new System.Drawing.Point(202, 303);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(407, 33);
            this.cbDepartments.TabIndex = 24;
            this.cbDepartments.Visible = false;
            // 
            // cbWorkshifts
            // 
            this.cbWorkshifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkshifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWorkshifts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkshifts.FormattingEnabled = true;
            this.cbWorkshifts.ItemHeight = 25;
            this.cbWorkshifts.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbWorkshifts.Location = new System.Drawing.Point(202, 358);
            this.cbWorkshifts.Name = "cbWorkshifts";
            this.cbWorkshifts.Size = new System.Drawing.Size(407, 33);
            this.cbWorkshifts.TabIndex = 25;
            this.cbWorkshifts.Visible = false;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(805, 472);
            this.Controls.Add(this.cbWorkshifts);
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
        private System.Windows.Forms.ComboBox cbWorkshifts;
    }
}