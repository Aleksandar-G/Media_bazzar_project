using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.Models;
namespace MediaBazaar.Forms
{
    public partial class WorkerShiftsPerMonthForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private List<WorkShift> shifts;
        public WorkerShiftsPerMonthForm()
        {
            InitializeComponent();
            this.shifts = new List<WorkShift>();

            this.BackColor = ApplicationColors.Orange;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnSetShift.BackColor = ApplicationColors.PrimaryDark;
            this.rbMorning.Checked = true;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.MinDate = DateTime.Now;
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.CustomFormat = "MM/yyyy";
        }
        public List<WorkShift> ListShifts(List<DateTime> dates)
        {
            List<WorkShift> result = new List<WorkShift>();
            Shift shift;
            decimal wage = Convert.ToDecimal(tbWage.Text);
            int workersNeeded = Convert.ToInt32(tbWorkersNeeded.Text);

            if (rbMorning.Checked) shift = Shift.Morning;
            else if (rbAfternoon.Checked) shift = Shift.Afternoon;
            else shift = Shift.Evening;

            for (int i = 0; i < dates.Count; i++)
            {
                result.Add(new WorkShift(shift, dates[i], wage, workersNeeded));
            }
            return result;
        }
        public List<DateTime> GetDates(int year, int month)
        {
            int last_day = DateTime.DaysInMonth(year, month);
            List<DateTime> dates = new List<DateTime>();
            for (int i = 1; i <= last_day; i++)
            {
                dates.Add(new DateTime(year, month, i));
            }
            return dates;

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSetShift_Click(object sender, EventArgs e)
        {
            int year = dateTimePicker.Value.Year;
            int month = dateTimePicker.Value.Month;

            this.shifts = ListShifts(this.GetDates(year, month));
            foreach (var item in this.shifts)
            {
                item.Insert();
            }
            MessageBox.Show($"The shifts for {month} / {year} have been set successfully added.");
        }
    }
}
