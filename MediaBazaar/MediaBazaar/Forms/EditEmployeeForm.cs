using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class EditEmployeeForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public EditEmployeeForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnEdit.BackColor = ApplicationColors.Orange;
            this.btnRemove.BackColor = ApplicationColors.Red;
            this.cbRole.SelectedIndex = 0;
            this.cbDepartments.SelectedIndex = 0;
            this.cbWorkshifts.SelectedIndex = 0;
        }

        private void EditEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void EditEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void EditEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRemove_MouseEnter(object sender, EventArgs e)
        {
            this.btnRemove.BackColor = ApplicationColors.Orange;
        }

        private void BtnRemove_MouseLeave(object sender, EventArgs e)
        {
            this.btnRemove.BackColor = ApplicationColors.Red;
        }

        private void BtnEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btnEdit.BackColor = ApplicationColors.LightOrange;
        }

        private void BtnEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btnEdit.BackColor = ApplicationColors.Orange;
        }

        private void TbName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbName.Text == "Name")
            {
                tbName.Text = "";
            }
        }

        private void TbEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
            }
        }

        private void TbPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPhone.Text == "Phone")
            {
                tbPhone.Text = "";
            }
        }

        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem.ToString() != "Role")
            {
                cbRole.Items.Remove("Role");
            }

            if (cbRole.SelectedItem.ToString() == "Worker")
            {
                cbDepartments.Visible = true;
                cbDepartments.SelectedIndex = 0;

                cbWorkshifts.Visible = true;
                cbWorkshifts.SelectedIndex = 0;
            }
            else
            {
                cbDepartments.Visible = false;
                cbWorkshifts.Visible = false;
            }
        }
    }
}
