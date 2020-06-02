namespace MediaBazaar.Forms
{
    partial class WorkerShiftsPerMonthForm
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
            this.btnSetShift = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEvening = new System.Windows.Forms.RadioButton();
            this.rbAfternoon = new System.Windows.Forms.RadioButton();
            this.rbMorning = new System.Windows.Forms.RadioButton();
            this.lblMonth = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbWage = new System.Windows.Forms.TextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.tbWorkersNeeded = new System.Windows.Forms.TextBox();
            this.lblWorkersNeeded = new System.Windows.Forms.Label();
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
            this.btnClose.Location = new System.Drawing.Point(261, -3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(12, 17);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(220, 30);
            this.lblHeading.TabIndex = 13;
            this.lblHeading.Text = "Add shifts for month";
            // 
            // btnSetShift
            // 
            this.btnSetShift.BackColor = System.Drawing.Color.Maroon;
            this.btnSetShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetShift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetShift.ForeColor = System.Drawing.Color.White;
            this.btnSetShift.Location = new System.Drawing.Point(17, 424);
            this.btnSetShift.Name = "btnSetShift";
            this.btnSetShift.Size = new System.Drawing.Size(264, 47);
            this.btnSetShift.TabIndex = 22;
            this.btnSetShift.Text = "Add shifts";
            this.btnSetShift.UseVisualStyleBackColor = false;
            this.btnSetShift.Click += new System.EventHandler(this.BtnSetShift_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEvening);
            this.groupBox1.Controls.Add(this.rbAfternoon);
            this.groupBox1.Controls.Add(this.rbMorning);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 145);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shifts";
            // 
            // rbEvening
            // 
            this.rbEvening.AutoSize = true;
            this.rbEvening.Location = new System.Drawing.Point(19, 110);
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
            this.rbAfternoon.Location = new System.Drawing.Point(19, 75);
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
            this.rbMorning.Location = new System.Drawing.Point(19, 40);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(83, 24);
            this.rbMorning.TabIndex = 0;
            this.rbMorning.TabStop = true;
            this.rbMorning.Text = "Morning";
            this.rbMorning.UseVisualStyleBackColor = true;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(13, 68);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(99, 20);
            this.lblMonth.TabIndex = 20;
            this.lblMonth.Text = "Select Month:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(18, 96);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(263, 27);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 2, 0, 0, 0, 0);
            // 
            // tbWage
            // 
            this.tbWage.Location = new System.Drawing.Point(17, 209);
            this.tbWage.Name = "tbWage";
            this.tbWage.Size = new System.Drawing.Size(264, 26);
            this.tbWage.TabIndex = 28;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.BackColor = System.Drawing.Color.Transparent;
            this.lblWage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.ForeColor = System.Drawing.Color.Snow;
            this.lblWage.Location = new System.Drawing.Point(13, 185);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(52, 21);
            this.lblWage.TabIndex = 27;
            this.lblWage.Text = "Wage:";
            // 
            // tbWorkersNeeded
            // 
            this.tbWorkersNeeded.Location = new System.Drawing.Point(17, 155);
            this.tbWorkersNeeded.Name = "tbWorkersNeeded";
            this.tbWorkersNeeded.Size = new System.Drawing.Size(264, 26);
            this.tbWorkersNeeded.TabIndex = 26;
            // 
            // lblWorkersNeeded
            // 
            this.lblWorkersNeeded.AutoSize = true;
            this.lblWorkersNeeded.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkersNeeded.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkersNeeded.ForeColor = System.Drawing.Color.Snow;
            this.lblWorkersNeeded.Location = new System.Drawing.Point(13, 131);
            this.lblWorkersNeeded.Name = "lblWorkersNeeded";
            this.lblWorkersNeeded.Size = new System.Drawing.Size(129, 21);
            this.lblWorkersNeeded.TabIndex = 25;
            this.lblWorkersNeeded.Text = "Workers Needed:";
            // 
            // WorkerShiftsPerMonthForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(311, 483);
            this.Controls.Add(this.tbWage);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.tbWorkersNeeded);
            this.Controls.Add(this.lblWorkersNeeded);
            this.Controls.Add(this.btnSetShift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerShiftsPerMonthForm";
            this.Text = "WorkerShiftsPerMonthForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSetShift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEvening;
        private System.Windows.Forms.RadioButton rbAfternoon;
        private System.Windows.Forms.RadioButton rbMorning;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbWage;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.TextBox tbWorkersNeeded;
        private System.Windows.Forms.Label lblWorkersNeeded;
    }
}