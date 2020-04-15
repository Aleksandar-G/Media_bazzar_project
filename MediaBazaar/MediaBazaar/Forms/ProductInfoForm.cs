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

namespace MediaBazaar.Forms
{
    public partial class ProductInfoForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public ProductInfoForm(Product product)
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;

            lblProductTag.BackColor = ApplicationColors.LightOrange;
            lblDepartmentTag.BackColor = ApplicationColors.LightOrange;
            lblDescriptionTag.BackColor = ApplicationColors.LightOrange; 
            lblPriceTag.BackColor = ApplicationColors.LightOrange; 
            lblQuantityTag.BackColor = ApplicationColors.LightOrange;

            lblItemName.Text = product.Name;
            lblItemDepartment.Text = product.Department;
            lblDescription.Text = product.Description;
            lblItemPrice.Text = "$" + product.Price.ToString();
            lblItemQuantity.Text = product.Quantity.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductInfoForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ProductInfoForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void ProductInfoForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
