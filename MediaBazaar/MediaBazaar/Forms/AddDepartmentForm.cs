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
    public partial class AddDepartmentForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public AddDepartmentForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnAdd.BackColor = ApplicationColors.Red;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string departmentName = tbDepartmentName.Text;
            if (departmentName == "")
            {
                MessageBox.Show("Please input a name for the new department");
                return;
            }

            Department department = new Department(departmentName);

            department.Insert();

            Forms.AssignEmployessForm assignEmployessForm = new Forms.AssignEmployessForm();
            assignEmployessForm.Show();

        }

        public void Assign(List<long> WorkersId)
        {
           
            long departmentId = Department.GetTheNewestDepartmentId();
            foreach (var item in WorkersId)
            {
                Models.Worker.AssignWorkerToDepartment(item,departmentId);
            }

            this.Close();
                 
        }

        private void tbDepartmentName_MouseClick(object sender, MouseEventArgs e)
        {
            tbDepartmentName.Text = "";
        }
    }
}
