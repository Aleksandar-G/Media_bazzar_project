namespace MediaBazaar.Forms
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStatWorkersByDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductsByDepartment = new System.Windows.Forms.Button();
            this.btnSelledProductsByDepartment = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRevenuePerProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(745, -7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnStatWorkersByDepartment
            // 
            this.btnStatWorkersByDepartment.BackColor = System.Drawing.Color.Maroon;
            this.btnStatWorkersByDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatWorkersByDepartment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatWorkersByDepartment.ForeColor = System.Drawing.Color.White;
            this.btnStatWorkersByDepartment.Location = new System.Drawing.Point(12, 105);
            this.btnStatWorkersByDepartment.Name = "btnStatWorkersByDepartment";
            this.btnStatWorkersByDepartment.Size = new System.Drawing.Size(260, 47);
            this.btnStatWorkersByDepartment.TabIndex = 14;
            this.btnStatWorkersByDepartment.Text = "Workers by department\r\n";
            this.btnStatWorkersByDepartment.UseVisualStyleBackColor = false;
            this.btnStatWorkersByDepartment.Click += new System.EventHandler(this.BtnStatWorkersByDepartment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Media Bazaar Statistics";
            // 
            // btnProductsByDepartment
            // 
            this.btnProductsByDepartment.BackColor = System.Drawing.Color.Maroon;
            this.btnProductsByDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductsByDepartment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsByDepartment.ForeColor = System.Drawing.Color.White;
            this.btnProductsByDepartment.Location = new System.Drawing.Point(12, 158);
            this.btnProductsByDepartment.Name = "btnProductsByDepartment";
            this.btnProductsByDepartment.Size = new System.Drawing.Size(260, 47);
            this.btnProductsByDepartment.TabIndex = 19;
            this.btnProductsByDepartment.Text = "Products by department";
            this.btnProductsByDepartment.UseVisualStyleBackColor = false;
            this.btnProductsByDepartment.Click += new System.EventHandler(this.BtnProductsByDepartment_Click);
            // 
            // btnSelledProductsByDepartment
            // 
            this.btnSelledProductsByDepartment.BackColor = System.Drawing.Color.Maroon;
            this.btnSelledProductsByDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelledProductsByDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelledProductsByDepartment.ForeColor = System.Drawing.Color.White;
            this.btnSelledProductsByDepartment.Location = new System.Drawing.Point(12, 211);
            this.btnSelledProductsByDepartment.Name = "btnSelledProductsByDepartment";
            this.btnSelledProductsByDepartment.Size = new System.Drawing.Size(260, 47);
            this.btnSelledProductsByDepartment.TabIndex = 20;
            this.btnSelledProductsByDepartment.Text = "Sold products by department";
            this.btnSelledProductsByDepartment.UseVisualStyleBackColor = false;
            this.btnSelledProductsByDepartment.Click += new System.EventHandler(this.btnSelledProductsByDepartment_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(305, 76);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(465, 329);
            this.chart.TabIndex = 21;
            this.chart.Text = "chart1";
            this.chart.Visible = false;
            // 
            // btnRevenuePerProduct
            // 
            this.btnRevenuePerProduct.BackColor = System.Drawing.Color.Maroon;
            this.btnRevenuePerProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenuePerProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btnRevenuePerProduct.ForeColor = System.Drawing.Color.White;
            this.btnRevenuePerProduct.Location = new System.Drawing.Point(12, 264);
            this.btnRevenuePerProduct.Name = "btnRevenuePerProduct";
            this.btnRevenuePerProduct.Size = new System.Drawing.Size(260, 47);
            this.btnRevenuePerProduct.TabIndex = 22;
            this.btnRevenuePerProduct.Text = "Revenue Per Product";
            this.btnRevenuePerProduct.UseVisualStyleBackColor = false;
            this.btnRevenuePerProduct.Click += new System.EventHandler(this.btnRevenuePerProduct_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.btnRevenuePerProduct);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnSelledProductsByDepartment);
            this.Controls.Add(this.btnProductsByDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatWorkersByDepartment);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatisticsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatisticsForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StatisticsForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStatWorkersByDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductsByDepartment;
        private System.Windows.Forms.Button btnSelledProductsByDepartment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnRevenuePerProduct;
    }
}