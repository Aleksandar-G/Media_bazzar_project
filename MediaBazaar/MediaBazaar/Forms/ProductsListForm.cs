using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Forms
{
    public partial class ProductsListForm : Form
    {
        public ProductsListForm()
        {
            InitializeComponent();
        }

        private void ProductsListForm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("SERVER=studmysql01.fhict.local;DATABASE=dbi425706;UID=dbi425706;PASSWORD=12345678");

                string selectQuery = "SELECT * FROM products";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbProducts.Items.Add(reader.GetString("Name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}