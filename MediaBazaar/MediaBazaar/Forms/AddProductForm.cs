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

namespace MediaBazaar.Forms
{
    public partial class AddProductForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public AddProductForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;

            foreach(Department department in Department.GetAll())
            {
                cmbDepartments.Items.Add(department.Name);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = "";
            string productDescription = "";
            double productPrice = 0;
            int productQuantity = 0;
            string productDepartment ="";

            try
            {
                productName = tbProductName.Text;
                productDescription = tbProductDescription.Text;
                productPrice = Convert.ToDouble(tbProductPrice.Text);
                productDepartment = cmbDepartments.SelectedItem.ToString();

                Product product = new Product(productName, productDescription, productPrice, productQuantity, productDepartment);
                product.Insert();

                MessageBox.Show("Product was created successfully!");
                tbProductName.Text = "";
                tbProductDescription.Text = "";
                tbProductPrice.Text = "";
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
