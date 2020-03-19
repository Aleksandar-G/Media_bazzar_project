﻿using MediaBazaar.Models;
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

        public AddEmployeeForm()
        {
            InitializeComponent();

            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnAdd.BackColor = ApplicationColors.Red;
            cbRole.SelectedItem = "Role";

            Department.GetNames().ForEach(x => cbDepartments.Items.Add(x));
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
            if (cbRole.SelectedItem.ToString() != "Role")
            {
                cbRole.Items.Remove("Role");
            }

            if (cbRole.SelectedItem.ToString() == "Worker")
            {
                cbDepartments.Visible = true;
                cbDepartments.SelectedIndex = 0;

                cbWorkshifts.Visible = true;
                cbWorkshifts.SelectedIndex = 0;
            }
            else
            {
                cbDepartments.Visible = false;
                cbWorkshifts.Visible = false;
            }
        }

        private void TbDepartmentName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbName.Text == "Name")
            {
                tbName.Text = "";
            }
        }

        private void TbPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPhone.Text == "Phone")
            {
                tbPhone.Text = "";
            }
        }

        private void TbEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;

            if (cbRole.SelectedItem.ToString() == "Worker")
            {
                Department department = Department.GetByName(cbDepartments.SelectedItem.ToString());
                Workshift workshift = GetWorkshift(cbWorkshifts.SelectedItem.ToString());

                Worker worker = new Worker(name, email, phone, department.Id, workshift);
                worker.Insert();
                return;
            }
            else if (cbRole.SelectedItem.ToString() == "Administrator")
            {
                Administrator administrator = new Administrator(name, email, phone);
                administrator.Insert();
            }
            else if (cbRole.SelectedItem.ToString() == "Manager")
            {
                Manager manager = new Manager(name, email, phone);
                manager.Insert();
            }
        }

        public Workshift GetWorkshift(string val)
        {
            switch (val)
            {
                case "Morning":
                    return Workshift.MORNING;
                case "Afternoon":
                    return Workshift.AFTERNOON;
                case "Evening":
                    return Workshift.EVENING;
                default:
                    return Workshift.MORNING;
            }
        }
    }
}
