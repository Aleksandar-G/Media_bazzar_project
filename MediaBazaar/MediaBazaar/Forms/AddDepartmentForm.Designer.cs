﻿namespace MediaBazaar
{
    partial class AddDepartmentForm
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
            this.cbAssignEmployees = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblWorkShift = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDepartmentName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.tbDepartmentName)).BeginInit();
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
            // lblAddDepartment
            // 
            this.lblAddDepartment.AutoSize = true;
            this.lblAddDepartment.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDepartment.ForeColor = System.Drawing.Color.Snow;
            this.lblAddDepartment.Location = new System.Drawing.Point(275, 47);
            this.lblAddDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddDepartment.Name = "lblAddDepartment";
            this.lblAddDepartment.Size = new System.Drawing.Size(234, 37);
            this.lblAddDepartment.TabIndex = 11;
            this.lblAddDepartment.Text = "Add Department";
            // 
            // cbAssignEmployees
            // 
            this.cbAssignEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssignEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAssignEmployees.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssignEmployees.FormattingEnabled = true;
            this.cbAssignEmployees.ItemHeight = 25;
            this.cbAssignEmployees.Location = new System.Drawing.Point(180, 274);
            this.cbAssignEmployees.Name = "cbAssignEmployees";
            this.cbAssignEmployees.Size = new System.Drawing.Size(407, 33);
            this.cbAssignEmployees.TabIndex = 13;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Snow;
            this.lblDepartment.Location = new System.Drawing.Point(326, 129);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(124, 30);
            this.lblDepartment.TabIndex = 14;
            this.lblDepartment.Text = "Department";
            // 
            // lblWorkShift
            // 
            this.lblWorkShift.AutoSize = true;
            this.lblWorkShift.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkShift.ForeColor = System.Drawing.Color.Snow;
            this.lblWorkShift.Location = new System.Drawing.Point(301, 241);
            this.lblWorkShift.Margin = new System.Windows.Forms.Padding(0);
            this.lblWorkShift.Name = "lblWorkShift";
            this.lblWorkShift.Size = new System.Drawing.Size(179, 30);
            this.lblWorkShift.TabIndex = 15;
            this.lblWorkShift.Text = "Assign Employees";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(306, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 48);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.BtnAdd_MouseLeave);
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.BeforeTouchSize = new System.Drawing.Size(407, 33);
            this.tbDepartmentName.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbDepartmentName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartmentName.Location = new System.Drawing.Point(180, 162);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(407, 33);
            this.tbDepartmentName.TabIndex = 18;
            this.tbDepartmentName.Text = "Name";
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDepartmentName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWorkShift);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.cbAssignEmployees);
            this.Controls.Add(this.lblAddDepartment);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDepartment";
            this.Text = "EditEmployee";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditEmployee_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tbDepartmentName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAddDepartment;
        private System.Windows.Forms.ComboBox cbAssignEmployees;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblWorkShift;
        private System.Windows.Forms.Button btnAdd;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbDepartmentName;
    }
}