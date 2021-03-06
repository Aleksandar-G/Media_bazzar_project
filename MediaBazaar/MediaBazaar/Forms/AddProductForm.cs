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

namespace MediaBazaar.Forms
{
    public partial class AddProductForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public AddProductForm(User user)
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            
            if (user.Role == "Supervisor")
            {
                Supervisor supervisor = Supervisor.GetByUserId(user.Id);
                Department supervisorDepartment = Department.GetById(supervisor.DepartmentId);

                if (supervisorDepartment != null)
                {
                    cmbDepartments.Items.Add(supervisorDepartment.Name);
                    cmbDepartments.SelectedIndex = 0;
                }
                
                cmbDepartments.Enabled = false;
                return;
            }

            foreach(Department department in Department.GetAll())
            {
                cmbDepartments.Items.Add(department.Name);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            string name = tbProductName.Text;
            string description = tbProductDescription.Text;
            double buyingPrice = Convert.ToDouble(tbProductBuyingPrice.Text);
            double sellingPrice = Convert.ToDouble(tbSellingPrice.Text);
            int quantity = 0;
            int minQuantity = Convert.ToInt32(tbMinQuantity.Text);
            string department = cmbDepartments.SelectedItem.ToString();

            try
            {
                Product product = new Product(name, description, buyingPrice, sellingPrice, quantity, minQuantity, department);
                product.Insert();

                MessageBox.Show("Product was created successfully!");

                tbProductName.Text = "";
                tbProductDescription.Text = "";
                tbProductBuyingPrice.Text = "";
                tbMinQuantity.Text = "";
                tbSellingPrice.Text = "";
                cmbDepartments.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddProductForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddProductForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}
