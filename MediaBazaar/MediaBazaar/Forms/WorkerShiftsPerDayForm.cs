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
        private Worker worker;
        private List<Workshift> workshifts;
        private List<DateTime> dates;

        public WorkerShiftsPerDayForm(Worker w)
        {
            InitializeComponent();
            this.worker = w;
            this.workshifts = new List<Workshift>();
            this.dates = new List<DateTime>();
            this.rbMorning.Checked = true;
            this.lblHeading.Text = $"ID:{w.Id}| {w.Name}'s Shifts";
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnSave.BackColor = ApplicationColors.Orange;
            this.btnSetShift.BackColor = ApplicationColors.Orange;
        }
        private void UpdateListBox()
        {
            this.lbSelectedShifts.Items.Clear();
            for (int i = 0; i < this.dates.Count; i++)
            {
                this.lbSelectedShifts.Items.Add($"{dates[i]}: {workshifts[i]}");
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSetShift_Click(object sender, EventArgs e)
        {
            Workshift shift;
            DateTime date = dateTimePicker.Value;

            if (rbMorning.Checked) shift = Workshift.MORNING;
            else if (rbAfternoon.Checked) shift = Workshift.AFTERNOON;
            else shift = Workshift.EVENING;

            this.workshifts.Add(shift);
            this.dates.Add(date);

            this.UpdateListBox();
        }

        private void LbSelectedShifts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSelectedShifts.SelectedIndex;
            workshifts.RemoveAt(index);
            dates.RemoveAt(index);
            this.UpdateListBox();
        }
    }
}
