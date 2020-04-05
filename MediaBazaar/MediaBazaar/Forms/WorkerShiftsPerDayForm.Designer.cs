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
            this.btnSetShift = new System.Windows.Forms.Button();
            this.lbSelectedShifts = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbMorning = new System.Windows.Forms.RadioButton();
            this.rbAfternoon = new System.Windows.Forms.RadioButton();
            this.rbEvening = new System.Windows.Forms.RadioButton();
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
            this.btnClose.Location = new System.Drawing.Point(550, -2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 55);
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
            this.lblHeading.Location = new System.Drawing.Point(12, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(125, 38);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Heading";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(19, 112);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(187, 31);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 2, 0, 0, 0, 0);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(14, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(192, 25);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Assign shift (per day):\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEvening);
            this.groupBox1.Controls.Add(this.rbAfternoon);
            this.groupBox1.Controls.Add(this.rbMorning);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 162);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shifts";
            // 
            // btnSetShift
            // 
            this.btnSetShift.BackColor = System.Drawing.Color.Maroon;
            this.btnSetShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetShift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetShift.ForeColor = System.Drawing.Color.White;
            this.btnSetShift.Location = new System.Drawing.Point(19, 372);
            this.btnSetShift.Name = "btnSetShift";
            this.btnSetShift.Size = new System.Drawing.Size(187, 47);
            this.btnSetShift.TabIndex = 18;
            this.btnSetShift.Text = "Set shift";
            this.btnSetShift.UseVisualStyleBackColor = false;
            this.btnSetShift.Click += new System.EventHandler(this.BtnSetShift_Click);
            // 
            // lbSelectedShifts
            // 
            this.lbSelectedShifts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedShifts.FormattingEnabled = true;
            this.lbSelectedShifts.ItemHeight = 23;
            this.lbSelectedShifts.Location = new System.Drawing.Point(252, 112);
            this.lbSelectedShifts.Name = "lbSelectedShifts";
            this.lbSelectedShifts.Size = new System.Drawing.Size(280, 234);
            this.lbSelectedShifts.TabIndex = 19;
            this.lbSelectedShifts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbSelectedShifts_MouseDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(345, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 47);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // rbMorning
            // 
            this.rbMorning.AutoSize = true;
            this.rbMorning.Location = new System.Drawing.Point(19, 40);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(106, 29);
            this.rbMorning.TabIndex = 0;
            this.rbMorning.TabStop = true;
            this.rbMorning.Text = "Morning";
            this.rbMorning.UseVisualStyleBackColor = true;
            // 
            // rbAfternoon
            // 
            this.rbAfternoon.AutoSize = true;
            this.rbAfternoon.Location = new System.Drawing.Point(19, 75);
            this.rbAfternoon.Name = "rbAfternoon";
            this.rbAfternoon.Size = new System.Drawing.Size(118, 29);
            this.rbAfternoon.TabIndex = 1;
            this.rbAfternoon.TabStop = true;
            this.rbAfternoon.Text = "Afternoon";
            this.rbAfternoon.UseVisualStyleBackColor = true;
            // 
            // rbEvening
            // 
            this.rbEvening.AutoSize = true;
            this.rbEvening.Location = new System.Drawing.Point(19, 110);
            this.rbEvening.Name = "rbEvening";
            this.rbEvening.Size = new System.Drawing.Size(100, 29);
            this.rbEvening.TabIndex = 2;
            this.rbEvening.TabStop = true;
            this.rbEvening.Text = "Evening";
            this.rbEvening.UseVisualStyleBackColor = true;
            // 
            // WorkerShiftsPerDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbSelectedShifts);
            this.Controls.Add(this.btnSetShift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnSetShift;
        private System.Windows.Forms.ListBox lbSelectedShifts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbEvening;
        private System.Windows.Forms.RadioButton rbAfternoon;
        private System.Windows.Forms.RadioButton rbMorning;
    }
}