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
    public partial class LoginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnLogin.BackColor = ApplicationColors.Orange;
        }

        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}
