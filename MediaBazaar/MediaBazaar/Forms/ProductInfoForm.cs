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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm(string name, string description, double price, int quantity)
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;

            lblItemName.Text = name;
            lblDescription.Text = description;
            lblItemPrice.Text = price.ToString();
            lblItemQuantity.Text = quantity.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
