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
        
        public StatisticsForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnProductsByDepartment.BackColor = ApplicationColors.Orange;
            this.cmbDepartments.BackColor = ApplicationColors.Orange;
            this.btnStatWorkersByDepartment.BackColor = ApplicationColors.Orange;
            
            

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnStatWorkersByDepartment_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            var chart = new Chart();
            chart.Series.Clear();

            Title title = new Title();
            title.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            title.Text = "Workers ratio by department";
            title.ForeColor = Color.White;

            var series = new Series();
            series.Name = "Number of workers";
            series.ChartType = SeriesChartType.Column;
            series.Color = ApplicationColors.PrimaryDark;
            series.BorderColor = Color.Transparent;
            series.Points.AddXY(statistics.GetDepartments()[0], statistics.GetWorkers()[0]);
            series.Points.AddXY(statistics.GetDepartments()[1], statistics.GetWorkers()[1]);
            series.Points.AddXY(statistics.GetDepartments()[2], statistics.GetWorkers()[2]);

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

            this.Controls.AddRange(new Control[] { chart });


        }

        private void BtnProductsByDepartment_Click(object sender, EventArgs e)
        {

        }
    }
}
