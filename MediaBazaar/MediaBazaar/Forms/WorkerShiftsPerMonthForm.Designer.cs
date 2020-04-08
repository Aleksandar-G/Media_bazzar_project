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
            this.lbl = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.btnClose.Location = new System.Drawing.Point(281, -3);
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
            this.lblHeading.Size = new System.Drawing.Size(127, 40);
            this.lblHeading.TabIndex = 13;
            this.lblHeading.Text = "Heading";
            // 
            // btnSetShift
            // 
            this.btnSetShift.BackColor = System.Drawing.Color.Maroon;
            this.btnSetShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetShift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetShift.ForeColor = System.Drawing.Color.White;
            this.btnSetShift.Location = new System.Drawing.Point(19, 372);
            this.btnSetShift.Name = "btnSetShift";
            this.btnSetShift.Size = new System.Drawing.Size(212, 47);
            this.btnSetShift.TabIndex = 22;
            this.btnSetShift.Text = "Set shift";
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
            this.groupBox1.Location = new System.Drawing.Point(19, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 162);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shifts";
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
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(14, 92);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(217, 25);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "Assign shift (per month):\r\n";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(19, 120);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(212, 32);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 2, 0, 0, 0, 0);
            // 
            // WorkerShiftsPerMonthForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(330, 470);
            this.Controls.Add(this.btnSetShift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl);
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
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}