using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.Forms;
using MediaBazaar.Models;

namespace MediaBazaar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           DotNetEnv.Env.Load("../../../../WebApp/.env");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
           
            if (loginForm.currentUser != null)
            {
                Application.Run(new MainForm(loginForm.currentUser));
            }
        }
    }
}
