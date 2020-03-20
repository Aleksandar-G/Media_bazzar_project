namespace MediaBazaar.Forms
{
    partial class StockRequestForm
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
            this.flpStockRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpStockRequests
            // 
            this.flpStockRequests.AutoScroll = true;
            this.flpStockRequests.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpStockRequests.Location = new System.Drawing.Point(61, 80);
            this.flpStockRequests.Margin = new System.Windows.Forms.Padding(0);
            this.flpStockRequests.Name = "flpStockRequests";
            this.flpStockRequests.Size = new System.Drawing.Size(653, 330);
            this.flpStockRequests.TabIndex = 16;
            this.flpStockRequests.WrapContents = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(756, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flpStockRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockRequestForm";
            this.Text = "StockRequestForm";
            this.Load += new System.EventHandler(this.StockRequestForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StockRequestForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StockRequestForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StockRequestForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpStockRequests;
        private System.Windows.Forms.Button btnClose;
    }
}