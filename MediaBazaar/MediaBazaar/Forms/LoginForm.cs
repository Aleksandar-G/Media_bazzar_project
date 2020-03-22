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

namespace MediaBazaar
{
    public partial class LoginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public User currentUser;

        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnLogin.BackColor = ApplicationColors.Orange;
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string message = "";
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                message += "There is empty field \n";
            }
            
            if(!email.Contains("@"))
            {
                message += "Invalid email input \n";
            }
            if (message == "")
            {
                if (CheckCredentials(email, password))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong credentials!");
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private bool CheckRole(User user)
        {
            if (user.Role == "Administrator" || user.Role == "Manager") return true;

            return false;
        }

        private bool CheckCredentials(string email, string password)
        {
            if (User.Authenticate(email, password))
            {
                User user = User.GetByEmail(email);
                if (CheckRole(user))
                {
                    this.currentUser = user;
                    return true;
                }
            }

            return false;
        }
    }
}
