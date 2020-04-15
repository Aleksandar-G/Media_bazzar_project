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
using MySql.Data.MySqlClient;

namespace MediaBazaar.Forms
{
    public partial class ProductsListForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public ProductsListForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
        }

        private void ProductsListForm_Load(object sender, EventArgs e)
        {
            FillUpProducts();
        }

        private void CmbProducts_Click(object sender, EventArgs e)
        {
            FillUpProducts();
        }

        private void FillUpProducts()
        {
            //cmbProducts.Items.Clear();

            //try
            //{
            //    foreach (Product product in Product.GetAll())
            //    {
            //        cmbProducts.Items.Add(product.Name);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            lbProducts.Items.Clear();

            try
            {
                foreach (Product product in Product.GetAll())
                {
                    lbProducts.Items.Add(product.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            string productName = "";
            Product product;

            try
            {
                //productName = cmbProducts.SelectedItem.ToString();
                productName = lbProducts.SelectedItem.ToString();

                product = Product.GetByName(productName);

                ProductInfoForm productInfoForm = new ProductInfoForm(product);
                productInfoForm.Show();

            }

            catch
            {
                MessageBox.Show("Please, select a product first!");
            }
            
        }

        private void BtnCreateProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            string productName = "";
            Product product;

            try
            {
                //productName = cmbProducts.SelectedItem.ToString();
                productName = lbProducts.SelectedItem.ToString();

                product = Product.GetByName(productName);

                product.Delete();
                MessageBox.Show("Product was successfully deleted!");
                FillUpProducts();
            }

            catch
            {
                MessageBox.Show("Please, select a product first!");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsListForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ProductsListForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ProductsListForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LbProducts_DoubleClick(object sender, EventArgs e)
        {
            FillUpProducts();
        }
    }
}