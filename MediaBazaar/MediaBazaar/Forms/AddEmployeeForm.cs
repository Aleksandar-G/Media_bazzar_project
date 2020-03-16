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
    public partial class AddEmployeeForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public AddEmployeeForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnAdd.BackColor = ApplicationColors.Red;
            cbRole.SelectedItem = "Role";
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

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            this.btnAdd.BackColor = ApplicationColors.Orange;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            this.btnAdd.BackColor = ApplicationColors.Red;
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
            } else
            {
                cbDepartments.Visible = false;
                cbWorkshifts.Visible = false;
            }
        }

        private void TbDepartmentName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbName.Text == "Name")
            {
                tbName.Text = "";
            }
        }

        private void TbEmail_MouseEnter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
            }
        }

        private void TbPhone_MouseEnter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "Phone")
            {
                tbPhone.Text = "";
            }
        }
    }
}
