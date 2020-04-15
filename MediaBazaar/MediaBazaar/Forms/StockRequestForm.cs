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
    public partial class StockRequestForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private List<StockRequest> stockRequests;
        public StockRequestForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
        }

        private void StockRequestForm_Load(object sender, EventArgs e)
        {
            LoadStockRequests();
        }
        public void LoadStockRequests()
        {
            //users = Models.User.GetAll();
            stockRequests = StockRequest.GetAll();

            this.flpStockRequests.Controls.Clear();

            stockRequests.ForEach(stockrequest =>
            {
                var btn = new Button();
                btn.BackColor = SystemColors.ControlLightLight;
                btn.Width = this.flpStockRequests.Width - 30;
                btn.Height = 60;


                btn.Text = $"Product name: {stockrequest.RequestedProduct} -> {stockrequest.RequestedQuantity} pieces ";
                btn.Font = new Font("Segoe UI Black", 12);
                btn.TextAlign = ContentAlignment.MiddleLeft;

                btn.MouseEnter += new EventHandler((s, ev) =>
                {
                    btn.BackColor = SystemColors.ControlLight;
                    btn.Cursor = Cursors.Hand;
                });

                btn.MouseLeave += new EventHandler((s, ev) =>
                {
                    btn.BackColor = SystemColors.ControlLightLight;
                });


                this.flpStockRequests.Controls.Add(btn);
            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockRequestForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void StockRequestForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void StockRequestForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
