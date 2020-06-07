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
    public partial class WorkerShiftsPerDayForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private List<WorkShift> shifts;

        public WorkerShiftsPerDayForm()
        {
            InitializeComponent();
            this.shifts = new List<WorkShift>();

            this.rbAfternoon.Checked = true;
            this.BackColor = ApplicationColors.Orange;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnSave.BackColor = ApplicationColors.PrimaryDark;
            this.btnAddShift.BackColor = ApplicationColors.PrimaryDark;
            this.dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker.CustomFormat = "yyy-MM-dd";
            dateTimePicker.MinDate = DateTime.Now;
            dateTimePicker.Value = DateTime.Now;
        }
        private void UpdateListBox()
        {
            this.lbSelectedShifts.Items.Clear();
            for (int i = 0; i < this.shifts.Count; i++)
            {
                this.lbSelectedShifts.Items.Add($"{shifts[i].Date.ToString("yyyy-MM-dd")} - {shifts[i].SelectedShift}");
            }
        }
        public bool CheckIfExists(WorkShift s)
        {
            foreach (var item in this.shifts)
            {
                if (item.SelectedShift == s.SelectedShift && item.Date.ToString("yyyy-MM-dd") == s.Date.ToString("yyyy-MM-dd"))
                {
                    return true;
                }
            }

            return false;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSetShift_Click(object sender, EventArgs e)
        {
            Shift shift;
            DateTime date = dateTimePicker.Value;
            decimal wage = Convert.ToDecimal(tbWage.Text);
            int workersNeeded = Convert.ToInt32(tbWorkersNeeded.Text);

            if (rbMorning.Checked) shift = Shift.Morning;
            else if (rbAfternoon.Checked) shift = Shift.Afternoon;
            else shift = Shift.Evening;

            WorkShift addedShift = new WorkShift(shift, date, wage, workersNeeded);

            if (!CheckIfExists(addedShift))
            {
                this.shifts.Add(addedShift);
                this.UpdateListBox();
            }
            else
            {
                MessageBox.Show("This shift is already in the list");
            }
        }

        private void LbSelectedShifts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSelectedShifts.SelectedIndex;
            shifts.RemoveAt(index);
            this.UpdateListBox();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            foreach (var item in this.shifts)
            {
                item.Insert();
            }

            MessageBox.Show("Shifts have been set successfully added.");
            this.Close();
        }
    }
}
