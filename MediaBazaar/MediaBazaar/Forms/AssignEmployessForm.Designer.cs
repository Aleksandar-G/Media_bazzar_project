namespace MediaBazaar.Forms
{
    partial class AssignEmployessForm
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
            this.clbWorkers = new System.Windows.Forms.CheckedListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lbAssignWorkers = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbWorkers
            // 
            this.clbWorkers.FormattingEnabled = true;
            this.clbWorkers.Location = new System.Drawing.Point(44, 110);
            this.clbWorkers.Name = "clbWorkers";
            this.clbWorkers.Size = new System.Drawing.Size(364, 214);
            this.clbWorkers.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAssign.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAssign.Location = new System.Drawing.Point(149, 361);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(159, 40);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Create";
            this.btnAssign.UseMnemonic = false;
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lbAssignWorkers
            // 
            this.lbAssignWorkers.AutoSize = true;
            this.lbAssignWorkers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbAssignWorkers.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAssignWorkers.Location = new System.Drawing.Point(87, 54);
            this.lbAssignWorkers.Name = "lbAssignWorkers";
            this.lbAssignWorkers.Size = new System.Drawing.Size(289, 25);
            this.lbAssignWorkers.TabIndex = 3;
            this.lbAssignWorkers.Text = "Assign workers to Department ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(424, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AssignEmployessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(466, 426);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbAssignWorkers);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.clbWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignEmployessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignEmployessForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AssignEmployessForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssignEmployessForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AssignEmployessForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.CheckedListBox clbWorkers;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lbAssignWorkers;
        private System.Windows.Forms.Button btnClose;
    }
}