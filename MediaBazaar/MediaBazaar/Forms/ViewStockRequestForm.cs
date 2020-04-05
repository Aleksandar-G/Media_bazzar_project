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
    public partial class ViewStockRequestForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public ViewStockRequestForm(StockRequest stockRequest)
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            lbProducts.BackColor = ApplicationColors.PrimaryDark;
            //rtbProducts.BackColor = ApplicationColors.Orange;
            this.lbAdmin.Text = stockRequest.AdminName;
            this.lbDepartment.Text = "Department: "+stockRequest.DepartmentName;
            foreach (var item in stockRequest.ProductsAndQuantity)
            {
                //this.lbProducts.Text += $"{item.Key} : {item.Value} \n";
                this.lbProducts.Items.Add($"Name: {item.Key} -> Quantity: {item.Value}");
            }
        }

        private void ViewStockRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewStockRequestForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ViewStockRequestForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void ViewStockRequestForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
