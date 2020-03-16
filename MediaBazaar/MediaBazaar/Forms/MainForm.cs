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
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();
            this.navigation.BackColor = ApplicationColors.PrimaryDark;
            this.BackColor = ApplicationColors.Orange;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++) 
            {
                var btn = new Button();
                btn.BackColor = SystemColors.ControlLightLight;
                btn.Width = this.flpEmployees.Width - 30;
                btn.Height = 60;

                
                btn.Text = "John Doe [Main Department]";
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

                btn.Click += new EventHandler((s, ev) =>
                {
                    var form = new EditEmployeeForm();
                    form.Show();
                });

                this.flpEmployees.Controls.Add(btn);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NavigationDrawer1_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void MainForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Navigation_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Navigation_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Navigation_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new AddEmployeeForm();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new AddEmployeeForm();
            form.Show();
        }
    }
}
