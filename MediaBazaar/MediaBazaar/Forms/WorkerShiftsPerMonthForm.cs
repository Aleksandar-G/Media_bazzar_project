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
        private Worker worker;
        public WorkerShiftsPerMonthForm(Worker w)
        {
            InitializeComponent();
            this.worker = w;
            this.lblHeading.Text = $"{w.Id}| {w.Name}'s Shifts";
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnSetShift.BackColor = ApplicationColors.Orange;
            
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/yyyy";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
