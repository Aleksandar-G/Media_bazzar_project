using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.Forms;
using MediaBazaar.Models;

namespace MediaBazaar
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public User currentUser;
        private List<User> users;

        public MainForm(User user)
        {
            InitializeComponent();

            this.currentUser = user;
            this.navigation.BackColor = ApplicationColors.PrimaryDark;
            this.BackColor = ApplicationColors.Orange;
            this.btnViewStatistics.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (currentUser.Role == "Manager" || currentUser.Role == "Administrator")
            {
                users = User.GetAll();
                this.btnViewStatistics.Show();;
                this.btnLeaveRequests.Show();
            }

            else if (currentUser.Role == "Supervisor")
            {
                this.btnViewStockRequests.Hide();
                this.btnAddEmployee.Hide();
                this.btnAddDepartment.Hide();

                Supervisor supervisor = Supervisor.GetByUserId(currentUser.Id);
                users = new List<User>(Worker.GetAll().FindAll(w => w.DepartmentId == supervisor.DepartmentId));
            }

            ShowUsers(users);
        }

        public void ShowUsers(List<User> users)
        {
            this.flpEmployees.Controls.Clear();

            if (users == null) {
                return;
            }

            users.ForEach(user =>
            {
                var btn = new Button();
                btn.BackColor = SystemColors.ControlLightLight;
                btn.Width = this.flpEmployees.Width - 30;
                btn.Height = 60;


                btn.Text = $"{user.Name} ({user.Email}) [{user.Role}]";
                btn.Font = new Font("Segoe UI Black", 12);
                btn.TextAlign = ContentAlignment.MiddleLeft;

                btn.MouseEnter += new EventHandler((s, ev) =>
                {
                    btn.BackColor = SystemColors.ControlLight;
                    btn.Cursor = Cursors.Hand;
                });

                btn.MouseLeave += new EventHandler((s, ev) =>
                {
                    btn.BackColor = SystemColors.ControlLightLight;
                });

                btn.Click += new EventHandler((s, ev) =>
                {
                    var form = new EditEmployeeForm(user, this);
                    form.Show();
                });

                this.flpEmployees.Controls.Add(btn);
            });
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NavigationDrawer1_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void MainForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Navigation_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Navigation_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Navigation_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new AddEmployeeForm(this);
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new AddDepartmentForm();
            form.Show();
        }

        private void BtnViewStatistics_Click(object sender, EventArgs e)
        {
            var form = new StatisticsForm(currentUser);
            form.Show();
        }

        private void btnViewStockRequests_Click(object sender, EventArgs e)
        {
            StockRequestForm form = new StockRequestForm();
            form.Show();
        }

        private void TextBoxExt1_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            ShowUsers(users.FindAll(x => x.Name.Contains(search)));
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductsListForm(currentUser);
            productsForm.Show();
        }

        private void BtnViewWorkshifts_Click(object sender, EventArgs e)
        {
            ViewWorkshiftsForm workshiftsForm = new ViewWorkshiftsForm(currentUser);
            workshiftsForm.Show();
        }

        private void btnAddShiftsPerDay_Click(object sender, EventArgs e)
        {
            WorkerShiftsPerDayForm form = new WorkerShiftsPerDayForm();
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WorkerShiftsPerMonthForm form = new WorkerShiftsPerMonthForm();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                WorkShift.AssignShifts();
            } catch (Exception)
            {
                MessageBox.Show("Something happened. Please check your connection and try again.");
                return;
            }

            MessageBox.Show("Available shifts for the upcoming week were successfully assigned to the available users");
        }

        private void BtnLeaveRequests_Click(object sender, EventArgs e)
        {
            if (LeaveRequest.GetAll().Count == 0)
            {
                MessageBox.Show("No more requests!");
                return;
            }

            ViewLeaveRequestsForm form = new ViewLeaveRequestsForm();
            form.Show();
        }
    }
}
