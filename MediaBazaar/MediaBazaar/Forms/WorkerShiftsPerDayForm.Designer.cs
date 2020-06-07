namespace MediaBazaar.Forms
{
    partial class WorkerShiftsPerDayForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEvening = new System.Windows.Forms.RadioButton();
            this.rbAfternoon = new System.Windows.Forms.RadioButton();
            this.rbMorning = new System.Windows.Forms.RadioButton();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.lbSelectedShifts = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWorkersNeeded = new System.Windows.Forms.Label();
            this.tbWorkersNeeded = new System.Windows.Forms.TextBox();
            this.tbWage = new System.Windows.Forms.TextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(412, -2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(9, 12);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(97, 30);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Heading";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(14, 75);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(141, 27);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 2, 0, 0, 0, 0);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(10, 52);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 20);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbEvening);
            this.groupBox1.Controls.Add(this.rbAfternoon);
            this.groupBox1.Controls.Add(this.rbMorning);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(140, 129);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift";
            // 
            // rbEvening
            // 
            this.rbEvening.AutoSize = true;
            this.rbEvening.Location = new System.Drawing.Point(14, 89);
            this.rbEvening.Margin = new System.Windows.Forms.Padding(2);
            this.rbEvening.Name = "rbEvening";
            this.rbEvening.Size = new System.Drawing.Size(79, 24);
            this.rbEvening.TabIndex = 2;
            this.rbEvening.TabStop = true;
            this.rbEvening.Text = "Evening";
            this.rbEvening.UseVisualStyleBackColor = true;
            // 
            // rbAfternoon
            // 
            this.rbAfternoon.AutoSize = true;
            this.rbAfternoon.Location = new System.Drawing.Point(14, 61);
            this.rbAfternoon.Margin = new System.Windows.Forms.Padding(2);
            this.rbAfternoon.Name = "rbAfternoon";
            this.rbAfternoon.Size = new System.Drawing.Size(94, 24);
            this.rbAfternoon.TabIndex = 1;
            this.rbAfternoon.TabStop = true;
            this.rbAfternoon.Text = "Afternoon";
            this.rbAfternoon.UseVisualStyleBackColor = true;
            // 
            // rbMorning
            // 
            this.rbMorning.AutoSize = true;
            this.rbMorning.Location = new System.Drawing.Point(14, 32);
            this.rbMorning.Margin = new System.Windows.Forms.Padding(2);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(83, 24);
            this.rbMorning.TabIndex = 0;
            this.rbMorning.TabStop = true;
            this.rbMorning.Text = "Morning";
            this.rbMorning.UseVisualStyleBackColor = true;
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.Maroon;
            this.btnAddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShift.ForeColor = System.Drawing.Color.White;
            this.btnAddShift.Location = new System.Drawing.Point(15, 361);
            this.btnAddShift.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(140, 38);
            this.btnAddShift.TabIndex = 18;
            this.btnAddShift.Text = "Add shift";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.BtnSetShift_Click);
            // 
            // lbSelectedShifts
            // 
            this.lbSelectedShifts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedShifts.FormattingEnabled = true;
            this.lbSelectedShifts.ItemHeight = 19;
            this.lbSelectedShifts.Location = new System.Drawing.Point(189, 75);
            this.lbSelectedShifts.Margin = new System.Windows.Forms.Padding(2);
            this.lbSelectedShifts.Name = "lbSelectedShifts";
            this.lbSelectedShifts.Size = new System.Drawing.Size(211, 270);
            this.lbSelectedShifts.TabIndex = 19;
            this.lbSelectedShifts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbSelectedShifts_MouseDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(260, 361);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 38);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblWorkersNeeded
            // 
            this.lblWorkersNeeded.AutoSize = true;
            this.lblWorkersNeeded.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkersNeeded.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkersNeeded.ForeColor = System.Drawing.Color.Snow;
            this.lblWorkersNeeded.Location = new System.Drawing.Point(12, 114);
            this.lblWorkersNeeded.Name = "lblWorkersNeeded";
            this.lblWorkersNeeded.Size = new System.Drawing.Size(129, 21);
            this.lblWorkersNeeded.TabIndex = 21;
            this.lblWorkersNeeded.Text = "Workers Needed:";
            // 
            // tbWorkersNeeded
            // 
            this.tbWorkersNeeded.Location = new System.Drawing.Point(16, 138);
            this.tbWorkersNeeded.Name = "tbWorkersNeeded";
            this.tbWorkersNeeded.Size = new System.Drawing.Size(139, 20);
            this.tbWorkersNeeded.TabIndex = 22;
            // 
            // tbWage
            // 
            this.tbWage.Location = new System.Drawing.Point(16, 186);
            this.tbWage.Name = "tbWage";
            this.tbWage.Size = new System.Drawing.Size(139, 20);
            this.tbWage.TabIndex = 24;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.BackColor = System.Drawing.Color.Transparent;
            this.lblWage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.ForeColor = System.Drawing.Color.Snow;
            this.lblWage.Location = new System.Drawing.Point(12, 162);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(52, 21);
            this.lblWage.TabIndex = 23;
            this.lblWage.Text = "Wage:";
            // 
            // WorkerShiftsPerDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(456, 410);
            this.Controls.Add(this.tbWage);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.tbWorkersNeeded);
            this.Controls.Add(this.lblWorkersNeeded);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbSelectedShifts);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WorkerShiftsPerDayForm";
            this.Text = "WorkerShiftsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.ListBox lbSelectedShifts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbEvening;
        private System.Windows.Forms.RadioButton rbAfternoon;
        private System.Windows.Forms.RadioButton rbMorning;
        private System.Windows.Forms.Label lblWorkersNeeded;
        private System.Windows.Forms.TextBox tbWorkersNeeded;
        private System.Windows.Forms.TextBox tbWage;
        private System.Windows.Forms.Label lblWage;
    }
}