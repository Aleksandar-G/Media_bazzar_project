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
    public partial class RemoveEmployeeForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private User user;
        private MainForm mainForm;

        public RemoveEmployeeForm(User user, MainForm mainForm)
        {
            InitializeComponent();

            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.dpEndDate.Value = DateTime.Now;

            this.user = user;
            this.mainForm = mainForm;
        }

        private void RemoveEmployeeForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void RemoveEmployeeForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void RemoveEmployeeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            this.btnRemove.BackColor = ApplicationColors.Orange;
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            this.btnRemove.BackColor = ApplicationColors.Red;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this user?",
                                    "Confirm",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                switch (user.Role)
                {
                    case "Worker":
                        Worker worker = Worker.GetByUserId(user.Id);
                        worker.Delete(dpEndDate.Value);
                        break;
                    case "Administrator":
                        Administrator admin = Administrator.GetByUserId(user.Id);
                        admin.Delete(dpEndDate.Value);
                        break;
                    case "Manager":
                        Manager manager = Manager.GetByUserId(user.Id);
                        manager.Delete(dpEndDate.Value);
                        break;
                }

                mainForm.ShowUsers(User.GetAll());
                this.Close();
            }
        }
    }
}
