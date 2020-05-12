namespace MediaBazaar.Forms
{
    partial class ViewStockRequestForm
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.lblQuantityTag = new System.Windows.Forms.Label();
            this.lblProductTag = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblWorkerTag = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnFulfillRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(592, -11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 69);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Black", 15F);
            this.lbHeader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbHeader.Location = new System.Drawing.Point(136, 29);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(329, 41);
            this.lbHeader.TabIndex = 20;
            this.lbHeader.Text = "StockRequest Details";
            // 
            // lblQuantityTag
            // 
            this.lblQuantityTag.AutoSize = true;
            this.lblQuantityTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityTag.ForeColor = System.Drawing.Color.White;
            this.lblQuantityTag.Location = new System.Drawing.Point(140, 258);
            this.lblQuantityTag.Name = "lblQuantityTag";
            this.lblQuantityTag.Size = new System.Drawing.Size(280, 38);
            this.lblQuantityTag.TabIndex = 37;
            this.lblQuantityTag.Text = "Requested quantity:";
            // 
            // lblProductTag
            // 
            this.lblProductTag.AutoSize = true;
            this.lblProductTag.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblProductTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTag.ForeColor = System.Drawing.Color.White;
            this.lblProductTag.Location = new System.Drawing.Point(136, 130);
            this.lblProductTag.Name = "lblProductTag";
            this.lblProductTag.Size = new System.Drawing.Size(255, 38);
            this.lblProductTag.TabIndex = 36;
            this.lblProductTag.Text = "Requested roduct:";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantity.ForeColor = System.Drawing.Color.White;
            this.lblItemQuantity.Location = new System.Drawing.Point(141, 310);
            this.lblItemQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(275, 32);
            this.lblItemQuantity.TabIndex = 35;
            this.lblItemQuantity.Text = "Requested quantity";
            // 
            // lblWorkerTag
            // 
            this.lblWorkerTag.AutoSize = true;
            this.lblWorkerTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerTag.ForeColor = System.Drawing.Color.White;
            this.lblWorkerTag.Location = new System.Drawing.Point(140, 389);
            this.lblWorkerTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkerTag.Name = "lblWorkerTag";
            this.lblWorkerTag.Size = new System.Drawing.Size(302, 38);
            this.lblWorkerTag.TabIndex = 34;
            this.lblWorkerTag.Text = "Requested by worker:";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.ForeColor = System.Drawing.Color.White;
            this.lblWorker.Location = new System.Drawing.Point(141, 441);
            this.lblWorker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(239, 32);
            this.lblWorker.TabIndex = 32;
            this.lblWorker.Text = "Requested by worker";
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(137, 181);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(259, 34);
            this.lblItemName.TabIndex = 29;
            this.lblItemName.Text = "Requested product";
            // 
            // btnFulfillRequest
            // 
            this.btnFulfillRequest.BackColor = System.Drawing.Color.Maroon;
            this.btnFulfillRequest.FlatAppearance.BorderSize = 0;
            this.btnFulfillRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFulfillRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFulfillRequest.ForeColor = System.Drawing.Color.White;
            this.btnFulfillRequest.Location = new System.Drawing.Point(143, 559);
            this.btnFulfillRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnFulfillRequest.Name = "btnFulfillRequest";
            this.btnFulfillRequest.Size = new System.Drawing.Size(342, 73);
            this.btnFulfillRequest.TabIndex = 39;
            this.btnFulfillRequest.Text = "Fulfill Stock Request";
            this.btnFulfillRequest.UseVisualStyleBackColor = false;
            this.btnFulfillRequest.Click += new System.EventHandler(this.BtnFulfillRequest_Click);
            // 
            // ViewStockRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(657, 755);
            this.Controls.Add(this.btnFulfillRequest);
            this.Controls.Add(this.lblQuantityTag);
            this.Controls.Add(this.lblProductTag);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.lblWorkerTag);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewStockRequestForm";
            this.Text = "ViewStockRequestForm";
            this.Load += new System.EventHandler(this.ViewStockRequestForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewStockRequestForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewStockRequestForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewStockRequestForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lblQuantityTag;
        private System.Windows.Forms.Label lblProductTag;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblWorkerTag;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnFulfillRequest;
    }
}