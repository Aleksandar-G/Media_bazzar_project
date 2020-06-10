using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using MediaBazaar.Models;


namespace MediaBazaar.Forms
{
    public partial class StatisticsForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private User currentUser;

        public StatisticsForm(User currentUser)
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnProductsByDepartment.BackColor = ApplicationColors.Orange;
            this.btnStatWorkersByDepartment.BackColor = ApplicationColors.Orange;

            this.currentUser = currentUser;

        }
        public void CreateChart(SeriesChartType type, string gv_title, Dictionary<string, int> result, string seriesName)
        {

            this.chart.Series.Clear();
            this.chart.Legends.Clear();
            this.chart.Titles.Clear();

            Title title = new Title();
            title.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            title.ForeColor = Color.White;

            var series = new Series();
            series.Name = seriesName;
            series.ChartType = type;
            series.Color = ApplicationColors.PrimaryDark;
            series.BorderColor = Color.Transparent;

            if (type == SeriesChartType.Column)
            {
                title.Text = gv_title;

                foreach (var item in result)
                {
                    series.Points.AddXY(item.Key, item.Value);
                }
            }
            else
            {
                title.Text = gv_title;
                series.IsValueShownAsLabel = true;
                foreach (var item in result)
                {
                    series.Points.AddXY(item.Key, item.Value);
                }

            }

            ChartArea chartArea = new ChartArea("Workers by Dep");
            chartArea.BackColor = Color.White;

            Legend legend = new Legend("Workers");
            legend.BackColor = Color.White;
            legend.Font = new Font("Segoe UI", 9);
            legend.ForeColor = Color.Black;

            this.chart.Legends.Add(legend);
            this.chart.BackColor = ApplicationColors.Orange;
            this.chart.Titles.Add(title);
            this.chart.Series.Add(series);
            this.chart.Invalidate();
            this.chart.Visible = true;
            this.chart.Size = new Size(475, 275);
            this.chart.Location = new Point(300, 105);


        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CreateWorkersByDepartmentChart()
        {
            this.CreateChart(SeriesChartType.Column, "Workers By department", Worker.GetWorkersByDepartment(), "number of workers");
        }

        private void CreateProductsByDepartmentChart()
        {
            this.CreateChart(SeriesChartType.Pie, "Products per department", Product.GetProductsByDepartment(), "");
        }

        private void BtnStatWorkersByDepartment_Click(object sender, EventArgs e)
        {
            CreateWorkersByDepartmentChart();
        }

        private void BtnProductsByDepartment_Click(object sender, EventArgs e)
        {
            CreateProductsByDepartmentChart();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductsListForm(currentUser);
            productsForm.Show();
        }

        private void StatisticsForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void StatisticsForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void StatisticsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void btnSelledProductsByDepartment_Click(object sender, EventArgs e)
        {
            CreateSoldProductByDepartmentChart();
        }

        private void CreateSoldProductByDepartmentChart()
        {
            this.CreateChart(SeriesChartType.Column, "Fastest selling Product", Product.GetSoldQuantity(), "Sold quantity");
        }
        private void CreateRevenuePerProductChart()
        {
            this.CreateChart(SeriesChartType.Pie, "Revenue Per Product", Product.GetProductRevenue(), "");
        }

        private void btnRevenuePerProduct_Click(object sender, EventArgs e)
        {
            CreateRevenuePerProductChart();
        }
    }
}
