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
    public partial class AssignEmployessForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private Dictionary<long, string> workersIdName;
        public AssignEmployessForm()
        {
            InitializeComponent();
            lbWorkers.SelectionMode = SelectionMode.MultiExtended;
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnAssign.BackColor = ApplicationColors.Red;

            workersIdName = Worker.GetAllWorkersWithDepartments();
            if (workersIdName == null)
            {
                MessageBox.Show("There are no Workers without Department");
                this.Close();
            }
            else
            {
                foreach (var item in workersIdName)
                {
                    lbWorkers.Items.Add(item.Value);
                }
            }           
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

            (Application.OpenForms["AddDepartmentForm"] as AddDepartmentForm).Assign(AssignWorkers());
            this.Close();

            MessageBox.Show("Department successfully created");
        }

        public List<long> AssignWorkers()
        {
            List<long> ids = new List<long>();
           
            foreach (var item in lbWorkers.SelectedItems)
            {
                foreach (var i in workersIdName)
                {
                    if (item.ToString() == i.Value)
                    {
                        ids.Add(i.Key);
                    }
                }
            }

            return ids;
        }
    }
}
