namespace MediaBazaar.Forms
{
    partial class ViewWorkshiftsForm
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
            this.cbWorkers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flpShifts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(707, -6);
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
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(226, 40);
            this.lblHeading.TabIndex = 13;
            this.lblHeading.Text = "View workshifts";
            // 
            // cbWorkers
            // 
            this.cbWorkers.BackColor = System.Drawing.Color.Maroon;
            this.cbWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWorkers.Font = new System.Drawing.Font("Segoe UI Emoji", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWorkers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbWorkers.Location = new System.Drawing.Point(19, 105);
            this.cbWorkers.Name = "cbWorkers";
            this.cbWorkers.Size = new System.Drawing.Size(286, 36);
            this.cbWorkers.TabIndex = 14;
            this.cbWorkers.SelectedIndexChanged += new System.EventHandler(this.CbWorkers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select user";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkBox);
            this.panel.Controls.Add(this.dateTimePicker);
            this.panel.Location = new System.Drawing.Point(319, 79);
            this.panel.Margin = new System.Windows.Forms.Padding(1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(379, 71);
            this.panel.TabIndex = 16;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(18, 26);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(109, 34);
            this.checkBox.TabIndex = 4;
            this.checkBox.Text = "Monthly";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(154, 24);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(162, 35);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // flpShifts
            // 
            this.flpShifts.AutoScroll = true;
            this.flpShifts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpShifts.Location = new System.Drawing.Point(19, 166);
            this.flpShifts.Margin = new System.Windows.Forms.Padding(0);
            this.flpShifts.Name = "flpShifts";
            this.flpShifts.Size = new System.Drawing.Size(661, 345);
            this.flpShifts.TabIndex = 3;
            this.flpShifts.WrapContents = false;
            // 
            // ViewWorkshiftsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(768, 631);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.flpShifts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWorkers);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewWorkshiftsForm";
            this.Text = "ViewWorkshiftsForm";
            this.Load += new System.EventHandler(this.ViewWorkshiftsForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cbWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.FlowLayoutPanel flpShifts;
    }
}