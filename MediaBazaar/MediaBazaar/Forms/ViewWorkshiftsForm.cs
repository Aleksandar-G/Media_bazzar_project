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
    public partial class ViewWorkshiftsForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private List<Worker> workers;
        private Worker currentWorker;
        private List<WorkShift> workShifts;
        public ViewWorkshiftsForm()
        {
            InitializeComponent();
            this.workers = Worker.GetAll();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.cbWorkers.BackColor = ApplicationColors.Orange;
            this.lbWorkshifts.BackColor = ApplicationColors.Orange;

            this.workShifts = new List<WorkShift>();

            this.panel.Visible = false;
            this.rbDaily.Checked = true;
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
           
        }
        public void SetComboBoxCollection()
        {
            foreach (var item in this.workers)
            {
                cbWorkers.Items.Add($"{item.Name} - {item.Email}");
            }
        }
      
        public void UpdateListBox(List<WorkShift> w, bool daily)
        {
            lbWorkshifts.Items.Clear();
            lbWorkshifts.Items.Add($"Date              Shift");
            lbWorkshifts.Items.Add($"--------------------");
          
            foreach (var item in w)
            {
                if (daily)
                {
                    if (item.Date.ToString("yyyy-MM-dd") == dateTimePicker.Value.ToString("yyyy-MM-dd"))
                    {
                        lbWorkshifts.Items.Add($"{item.Date.ToString("yyyy-MM-dd")}  {item.SelectedShift}");
                    }
                }
                else
                {
                    if(item.Date.Month == dateTimePicker.Value.Month)
                    {
                        lbWorkshifts.Items.Add($"{item.Date.ToString("yyyy-MM-dd")}  {item.SelectedShift}");
                    }
                }
            }
        }
        public bool CheckRadioButtons()
        {
            if (rbDaily.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   
            
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewWorkshiftsForm_Load(object sender, EventArgs e)
        {
            SetComboBoxCollection();
        }

        private void CbWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.panel.Visible = true;
            currentWorker = this.workers[cbWorkers.SelectedIndex];
           
            workShifts = Worker.GetWorkShiftsByWorkerID(currentWorker.Id);
            UpdateListBox(workShifts, CheckRadioButtons());

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBox(workShifts, CheckRadioButtons());
        }

        private void RbDaily_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox(workShifts, CheckRadioButtons());
        }

        private void RbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox(workShifts, CheckRadioButtons());
        }
    }
}
