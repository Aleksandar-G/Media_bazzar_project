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
        private User currentUser;

        public ViewWorkshiftsForm(User currentUser)
        {
            InitializeComponent();

            this.BackColor = ApplicationColors.PrimaryDark;
            this.cbWorkers.BackColor = Color.White;
            this.cbWorkers.ForeColor = ApplicationColors.PrimaryDark;
            this.checkBox.BackColor = ApplicationColors.PrimaryDark;
            this.panel.Visible = false;
            
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            dateTimePicker.Format = DateTimePickerFormat.Custom;

            this.workShifts = new List<WorkShift>();
            this.currentUser = currentUser;

            this.workers = Worker.GetAll();
            if (currentUser.Role == "Supervisor")
            {
                long supervisorDepartment = Supervisor.GetByUserId(currentUser.Id).DepartmentId;
                this.workers = this.workers.FindAll(w => w.DepartmentId == supervisorDepartment);
            }
        }
        public void SetComboBoxCollection()
        {
            foreach (var item in this.workers)
            {
                cbWorkers.Items.Add($"{item.Name} - {item.Email}");
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
        public void CreateShiftComponent(WorkShift shift)
        {
            var btn = new Button();
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = ApplicationColors.Orange;
            btn.Width = this.flpShifts.Width - 50;
            btn.Height = 40;
            btn.ForeColor = Color.White;

            string dateInfo = $"{shift.Date.ToString("dd.MM.yyyy")} ({shift.Date.DayOfWeek})";
            string shiftInfo = $" Shift: [{shift.SelectedShift}]";
            btn.Text = $"{dateInfo} {shiftInfo}";

            btn.Font = new Font("Segoe UI", 13);
            
            btn.TextAlign = ContentAlignment.MiddleLeft;

            this.flpShifts.Controls.Add(btn);
        }
        public void ShowShifts(List<WorkShift> shifts, bool monthly)
        {
            this.flpShifts.Controls.Clear();
            if (!monthly)
            {
                shifts.ForEach(shift =>
                {
                    if (shift.Date.ToString("yyyy-MM-dd") == dateTimePicker.Value.ToString("yyyy-MM-dd"))
                    {
                        this.CreateShiftComponent(shift);
                    }
                });
            }
            else
            {
                shifts.ForEach(shift =>
                {
                    if (dateTimePicker.Value.Month == shift.Date.Month && dateTimePicker.Value.Year == shift.Date.Year)
                    {
                        this.CreateShiftComponent(shift);
                    }
                });

            }
        }
        private void CbWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.panel.Visible = true;
            currentWorker = this.workers[cbWorkers.SelectedIndex];
            workShifts = Worker.GetWorkShiftsByWorkerID(currentWorker.Id);
            this.ShowShifts(workShifts, checkBox.Checked);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.ShowShifts(this.workShifts, checkBox.Checked);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

            this.ShowShifts(this.workShifts, checkBox.Checked);
            

        }

       
    }
}
