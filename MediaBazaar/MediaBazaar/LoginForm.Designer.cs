namespace MediaBazaar
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.autoLabelEmail = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(297, 402);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 42);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.MouseHover += new System.EventHandler(this.BtnLogin_MouseHover);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(239, 271);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(288, 29);
            this.tbEmail.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPassword.Location = new System.Drawing.Point(239, 345);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(288, 29);
            this.tbPassword.TabIndex = 5;
            // 
            // autoLabelEmail
            // 
            this.autoLabelEmail.DX = 110;
            this.autoLabelEmail.DY = -25;
            this.autoLabelEmail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabelEmail.ForeColor = System.Drawing.Color.White;
            this.autoLabelEmail.Gap = 5;
            this.autoLabelEmail.LabeledControl = this.tbEmail;
            this.autoLabelEmail.Location = new System.Drawing.Point(349, 246);
            this.autoLabelEmail.Name = "autoLabelEmail";
            this.autoLabelEmail.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabelEmail.Size = new System.Drawing.Size(70, 23);
            this.autoLabelEmail.TabIndex = 7;
            this.autoLabelEmail.Text = "Email";
            this.autoLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabelPassword
            // 
            this.autoLabelPassword.DX = 90;
            this.autoLabelPassword.DY = -25;
            this.autoLabelPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.autoLabelPassword.ForeColor = System.Drawing.Color.White;
            this.autoLabelPassword.Gap = 5;
            this.autoLabelPassword.LabeledControl = this.tbPassword;
            this.autoLabelPassword.Location = new System.Drawing.Point(329, 320);
            this.autoLabelPassword.Name = "autoLabelPassword";
            this.autoLabelPassword.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
            this.autoLabelPassword.Size = new System.Drawing.Size(113, 23);
            this.autoLabelPassword.TabIndex = 8;
            this.autoLabelPassword.Text = "Password";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(740, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaBazaar.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(287, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 467);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.autoLabelPassword);
            this.Controls.Add(this.autoLabelEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelEmail;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelPassword;
        private System.Windows.Forms.Button btnClose;
    }
}