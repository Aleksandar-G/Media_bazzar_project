using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjIwNTA0QDMxMzcyZTM0MmUzMGtEQzlxQzMyb1gycERnQ1FHT3REdVBuSW5Icmovc1NwQVJGMS9IcFNta2c9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //User user = new User("Martin Markov", "martin.markov28@gmail.com", "088888888");
            //user.Insert();

            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            if (loginForm.currentUser != null)
            {
                Application.Run(new MainForm(loginForm.currentUser));
            }

        }
    }
}
