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

namespace MediaBazaar
{
    public partial class EditEmployeeForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private User user;
        private MainForm mainForm;

        public EditEmployeeForm(User user, MainForm mainForm)
        {
            InitializeComponent();

            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnEdit.BackColor = ApplicationColors.Orange;
            this.btnRemove.BackColor = ApplicationColors.Red;
            this.btnEditShifts.BackColor = ApplicationColors.Orange;
            this.btnAssignShfitsPerMonth.BackColor = ApplicationColors.Orange;
            this.user = user;
            this.mainForm = mainForm;
            this.cbRole.SelectedItem = user.Role;
            this.cbRole.Enabled = false;
            this.tbName.Text = user.Name;
            this.tbEmail.Text = user.Email;
            this.tbPhone.Text = user.Phone;
            this.tbSalary.Text = user.Salary.ToString();
            this.dtbBirthday.CustomFormat = "yyy-MM-dd";
            this.dtbBirthday.Value = user.Birthday;

            this.checkRole();
        }

        private void EditEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void EditEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void EditEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRemove_MouseEnter(object sender, EventArgs e)
        {
            this.btnRemove.BackColor = ApplicationColors.Orange;
        }

        private void BtnRemove_MouseLeave(object sender, EventArgs e)
        {
            this.btnRemove.BackColor = ApplicationColors.Red;
        }

        private void BtnEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btnEdit.BackColor = ApplicationColors.LightOrange;
        }

        private void BtnEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btnEdit.BackColor = ApplicationColors.Orange;
        }

        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkRole();
        }

        private void checkRole()
        {
            if (user.Role == "Worker")
            {
                cbDepartments.Visible = true;
                lblDepartment.Visible = true;

                Worker worker = Worker.GetByUserId(user.Id);
                Department.GetAll().ForEach(d => {
                    this.cbDepartments.Items.Add(d.Name);

                    if (d.Id == worker.DepartmentId)
                    {
                        cbDepartments.SelectedItem = d.Name;
                    }
                });
            }
            else
            {
                cbDepartments.Visible = false;
                lblDepartment.Visible = false;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                user.Name = tbName.Text;
                user.Email = tbEmail.Text;
                user.Phone = tbPhone.Text;
                user.Birthday = dtbBirthday.Value;
                user.Salary = Convert.ToDecimal(tbSalary.Text);

                if (String.IsNullOrEmpty(user.Name) || String.IsNullOrEmpty(user.Email) || String.IsNullOrEmpty(user.Phone)||!user.Email.Contains("@"))
                {
                    MessageBox.Show("You left empty field(s) or \nyou have entered invalid email address");
                }
                else
                {
                    if (user.Role == "Worker")
                    {
                        Worker worker = Worker.GetByUserId(user.Id);
                        Worker updatedWorker = new Worker(
                            worker.Id,
                            Department.GetByName(cbDepartments.SelectedItem.ToString()).Id,
                            user
                        ) ;

                        worker.Update(updatedWorker);
                        MessageBox.Show("User updated successfully");
                        mainForm.ShowUsers(User.GetAll());
                        this.Close();
                        return;
                    }

                    user.Update(user);
                    MessageBox.Show("User updated successfully");
                    mainForm.ShowUsers(User.GetAll());
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this user?",
                                     "Confirm",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                switch (user.Role)
                {
                    case "Worker":
                        Worker worker = new Worker(
                            Worker.GetByUserId(user.Id).Id,
                            Department.GetByName(cbDepartments.SelectedItem.ToString()).Id,
                            user
                        );
                        worker.Delete();
                        break;
                    case "Administrator":
                        Administrator admin = new Administrator(Administrator.GetByUserId(user.Id).Id, user);
                        admin.Delete();
                        break;
                    case "Manager":
                        Manager manager = new Manager(Manager.GetByUserId(user.Id).Id, user);
                        manager.Delete();
                        break;
                }

                mainForm.ShowUsers(User.GetAll());
                this.Close();
            }
        }

        private void BtnEditShifts_Click(object sender, EventArgs e)
        {
            Worker worker = Worker.GetByUserId(this.user.Id);
            Forms.WorkerShiftsPerDayForm workerShiftsForm = new Forms.WorkerShiftsPerDayForm(worker);
            workerShiftsForm.Show();
        }

        private void BtnAssignShfitsPerMonth_Click(object sender, EventArgs e)
        {
            Worker worker = Worker.GetByUserId(this.user.Id);
            Forms.WorkerShiftsPerMonthForm workerShiftsForm = new Forms.WorkerShiftsPerMonthForm(worker);
            workerShiftsForm.Show();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            if (Worker.GetByUserId(this.user.Id) != null)
            {
                this.btnEditShifts.Visible = true;
                this.btnAssignShfitsPerMonth.Visible = true;
            }
        }
    }
}

