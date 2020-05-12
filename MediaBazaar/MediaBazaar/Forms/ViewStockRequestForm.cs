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
        private StockRequest currentstockRequest;

        public ViewStockRequestForm(StockRequest stockRequest)
        {
            this.currentstockRequest = stockRequest;

            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnFulfillRequest.BackColor = ApplicationColors.Red;

            lblProductTag.BackColor = ApplicationColors.LightOrange;
            lblQuantityTag.BackColor = ApplicationColors.LightOrange;
            lblWorkerTag.BackColor = ApplicationColors.LightOrange;

            this.lblItemName.Text = stockRequest.Product.Name;
            this.lblItemQuantity.Text = stockRequest.Quantity.ToString();
            this.lblWorker.Text = stockRequest.Worker.Name;

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

        private void BtnFulfillRequest_Click(object sender, EventArgs e)
        {
            currentstockRequest.Product.IncreaseQuantity(currentstockRequest.Quantity);
            currentstockRequest.CompleteStockRequest();

            MessageBox.Show("This stock request was successfully fulfilled!");

            this.Close();
        }
    }
}
