﻿using System;
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

            this.user = user;
            this.mainForm = mainForm;
            this.cbRole.SelectedItem = user.Role;
            this.cbRole.Enabled = false;
            this.tbName.Text = user.Name;
            this.tbEmail.Text = user.Email;
            this.tbPhone.Text = user.Phone;
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

        private void TbName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbName.Text == "Name")
            {
                tbName.Text = "";
            }
        }

        private void TbEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
            }
        }

        private void TbPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPhone.Text == "Phone")
            {
                tbPhone.Text = "";
            }
        }

        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem.ToString() == "Worker")
            {
                Department.GetNames().ForEach(d => this.cbDepartments.Items.Add(d));
                Worker worker = Worker.GetByUserId(user.Id);

                cbDepartments.Visible = true;
                cbDepartments.SelectedItem = Department.GetAll().Find(x => x.Id == worker.DepartmentId).Name;

                cbWorkshifts.Visible = true;
                string workshift = worker.GetWorkshift.ToString("G");
                cbWorkshifts.SelectedItem = workshift.First() + workshift.Substring(1).ToLower();
            }
            else
            {
                cbDepartments.Visible = false;
                cbWorkshifts.Visible = false;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Add validation to the forms
           
            try
            {
                user.Name = tbName.Text;
                user.Email = tbEmail.Text;
                user.Phone = tbPhone.Text;
                if (String.IsNullOrEmpty(user.Name) || String.IsNullOrEmpty(user.Email) || String.IsNullOrEmpty(user.Phone))
                {
                    MessageBox.Show("You left empty field(s)");
                }
                else
                {
                    if (user.Role == "Worker")
                    {
                        Worker worker = Worker.GetByUserId(user.Id);
                        Worker updatedWorker = new Worker(
                            worker.Id,
                            Department.GetByName(cbDepartments.SelectedItem.ToString()).Id,
                            Worker.GetWorkshiftByName(cbWorkshifts.SelectedItem.ToString()),
                            user
                        );

                        worker.Update(updatedWorker);
                        MessageBox.Show("User updated successfully");
                        mainForm.LoadUsers();
                        this.Close();
                        return;
                    }

                    user.Update(user);
                    MessageBox.Show("User updated successfully");
                    mainForm.ShowUsers(User.GetAll());
                    this.Close();
                }

                user.Update(user);
                MessageBox.Show("User updated successfully");
                mainForm.ShowUsers(User.GetAll());
                this.Close();

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
                            Worker.GetWorkshiftByName(cbWorkshifts.SelectedItem.ToString()),
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
    }
}
