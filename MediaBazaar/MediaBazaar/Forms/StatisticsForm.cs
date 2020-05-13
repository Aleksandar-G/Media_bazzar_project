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
        public Chart CreateChart(SeriesChartType type)
        {
            var chart = new Chart();
            chart.Series.Clear();

            Title title = new Title();
            title.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            title.ForeColor = Color.White;

            var series = new Series();
            series.Name = "Number of workers";
            series.ChartType = type;
            series.Color = ApplicationColors.PrimaryDark;
            series.BorderColor = Color.Transparent;

            if (type == SeriesChartType.Column)
            {
                title.Text = "Workers ratio by department";
                int lenght = Department.GetNames().Count;
                Dictionary<string, int> result = new Dictionary<string, int>();
                result = Worker.GetWorkersByDepartment();

                foreach (var item in result)
                {
                    series.Points.AddXY(item.Key, item.Value);
                }
            }
            else
            {
                title.Text = "Products ratio by department";
                int lenght = Department.GetNames().Count;
                Dictionary<string, int> result = new Dictionary<string, int>();
                result = Product.GetProductsByDepartment();
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

            chart.ChartAreas.Add(chartArea);
            chart.Legends.Add(legend);
            chart.BackColor = ApplicationColors.Orange;
            chart.Titles.Add(title);
            chart.Series.Add(series);
            chart.Invalidate();
            chart.Size = new Size(475, 275);
            chart.Location = new Point(300, 105);

            return chart;

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CreateWorkersByDepartmentChart()
        {
            Chart createdChart = this.CreateChart(SeriesChartType.Column);

            if (this.Controls.Count == 5) //CHECK FORM CONTROL NUMBER
            {
                this.Controls.RemoveAt(this.Controls.Count - 1);
            }
            this.Controls.AddRange(new Control[] { createdChart });
        }

        private void BtnStatWorkersByDepartment_Click(object sender, EventArgs e)
        {
            CreateWorkersByDepartmentChart();
        }

        private void BtnProductsByDepartment_Click(object sender, EventArgs e)
        {
            Chart createdChart = this.CreateChart(SeriesChartType.Pie);

            if (this.Controls.Count == 5) //CHECK FORM CONTROL NUMBER
            {
                this.Controls.RemoveAt(this.Controls.Count - 1);
            }
            this.Controls.AddRange(new Control[] { createdChart });
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
    }
}
