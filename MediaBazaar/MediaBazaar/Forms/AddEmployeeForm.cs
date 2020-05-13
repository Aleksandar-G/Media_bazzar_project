using MediaBazaar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class AddEmployeeForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private MainForm mainForm;

        public AddEmployeeForm(MainForm mainForm)
        {
            InitializeComponent();

            Department.GetNames().ForEach(x => cbDepartments.Items.Add(x));
      
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnAdd.BackColor = ApplicationColors.Red;
            this.mainForm = mainForm;
            this.cbRole.SelectedIndex = 0;
            this.dpBirthday.CustomFormat = "yyy-MM-dd";
            this.dpStartDate.CustomFormat = "yyy-MM-dd";
            this.dpBirthday.Value = DateTime.Now;
            this.dpStartDate.Value = DateTime.Now;
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

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            this.btnAdd.BackColor = ApplicationColors.Orange;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            this.btnAdd.BackColor = ApplicationColors.Red;
        }

        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem.ToString() == "Worker" || cbRole.SelectedItem.ToString() == "Supervisor")
            {
                cbDepartments.Visible = true;
                lblDepartment.Visible = true;
            }
            else
            {
                lblDepartment.Visible = false;
                cbDepartments.Visible = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            DateTime birthday = dpBirthday.Value;
            decimal salary = Convert.ToDecimal(tbSalary.Text);
            DateTime startDate = dpStartDate.Value;

            string message = "";

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(tbSalary.Text))
            {
                message += "You left empty field(s)\n";
            }

            if (!email.Contains("@"))
            {
                message += "Invalid email address\n";
            }

            if (name == "Name")
            {
                message += "Select appropriate name\n";
            }

            if (phone == "Phone")
            {
                message += "Select appropriate phone number";
            }

            if (message == "")
            {
                try
                {
                    if (cbRole.SelectedItem.ToString() == "Worker")
                    {
                        Department department = Department.GetByName(cbDepartments.SelectedItem.ToString());

                        Worker worker = new Worker(name, email, phone, department.Id, salary, birthday, startDate, new DateTime());
                        worker.Insert();
                    }
                    else if (cbRole.SelectedItem.ToString() == "Administrator")
                    {
                        Administrator administrator = new Administrator(name, email, phone, salary, birthday, startDate, new DateTime());
                        administrator.Insert();
                    }
                    else if (cbRole.SelectedItem.ToString() == "Manager")
                    {
                        Manager manager = new Manager(name, email, phone, salary, birthday, startDate, new DateTime());
                        manager.Insert();
                    }
                    else if (cbRole.SelectedItem.ToString() == "Supervisor")
                    {
                        Department department = Department.GetByName(cbDepartments.SelectedItem.ToString());

                        Supervisor supervisor = new Supervisor(name, email, phone, department.Id, salary, birthday, startDate, new DateTime());
                        supervisor.Insert();
                    }

                    MessageBox.Show("User added successfully!");
                    mainForm.ShowUsers(User.GetAll());
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not add the user! Please try again.\n{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
