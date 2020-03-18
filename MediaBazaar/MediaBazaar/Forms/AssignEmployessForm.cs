using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace MediaBazaar.Forms
{
    public partial class AssignEmployessForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public AssignEmployessForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnAssign.BackColor = ApplicationColors.Red;
            //Models.Worker.GetAllWithoutDepartment();
        }

        private void AssignEmployessForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AssignEmployessForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AssignEmployessForm_MouseMove(object sender, MouseEventArgs e)
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

        private void btnAssign_Click(object sender, EventArgs e)
        {
            foreach (User itemChecked in clbWorkers.CheckedItems)
            {
                //DataRowView castedItem = itemChecked as User;
                //string Name = castedItem["CompanyName"];
                //int? id = castedItem["ID"];

                //SELECT u.Name FROM users as u INNER JOIN workers as w ON u.Id = w.Id WHERE w.Department_id IS NULL
            }

        }

        public List<String> Assign()
        {
            foreach (User itemChecked in clbWorkers.CheckedItems)
            {
                //DataRowView castedItem = itemChecked as User;
                //string Name = castedItem["CompanyName"];
                //int? id = castedItem["ID"];

                //SELECT u.Name FROM users as u INNER JOIN workers as w ON u.Id = w.Id WHERE w.Department_id IS NULL
            }

            return null;
        }
    }
}
