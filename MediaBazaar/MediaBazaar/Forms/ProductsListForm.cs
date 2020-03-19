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
        public ProductsListForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnInfo.BackColor = ApplicationColors.Red;
        }

        private void ProductsListForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach(string product in Product.GetAllProducts())
                {
                    cmbProducts.Items.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = cmbProducts.SelectedItem.ToString();

                string productDescription = "";
                double productPrice = 0;
                int productQuantity = 0;

                DBconnection dbConnection = new DBconnection();
                string selectQuery = "SELECT * FROM products;";

                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand(selectQuery, dbConnection.connection);
                //command.Parameters.AddWithValue("@name", productName);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString("Name") == productName)
                    {
                        productDescription = reader.GetString("Description");
                        productPrice = Convert.ToDouble(reader.GetString("Price"));
                        productQuantity = Convert.ToInt32(reader.GetString("Quantity"));
                    }
                }

                ProductInfoForm productInfoForm = new ProductInfoForm(productName, productDescription, productPrice, productQuantity);
                productInfoForm.Show();

                dbConnection.CloseConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}