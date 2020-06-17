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
    public partial class ViewLeaveRequestsForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private LeaveRequest current_request;
        public ViewLeaveRequestsForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.panelDetails.Visible = false;
            
            this.UpdateGUI();

        }
        public void UpdateGUI()
        {
            this.lbLeaveRequests.Items.Clear();
            if (LeaveRequest.GetAll().Count == 0)
            {
                MessageBox.Show("No more requests!");
                this.Close();
            }
           foreach(var item in LeaveRequest.GetAll())
            {
                lbLeaveRequests.Items.Add(item.GetInfo());
            }

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewLeaveRequestsForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ViewLeaveRequestsForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ViewLeaveRequestsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LbLeaveRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDetails.Visible = true;
            current_request = LeaveRequest.GetAll()[lbLeaveRequests.SelectedIndex];
            lbDescription.Text = current_request.Description;
            lblName.Text = current_request.Worker.Name;
            lblFrom.Text = current_request.From.ToString("dd-MM-yyyy");
            lblTo.Text = current_request.To.ToString("dd-MM-yyyy");
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            current_request.Update(current_request, true);
            this.UpdateGUI();
        }

        private void BtnDecline_Click(object sender, EventArgs e)
        {
            current_request.Update(current_request, false);
            this.UpdateGUI();
        }
    }
}
