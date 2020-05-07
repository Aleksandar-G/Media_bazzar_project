using System;
using System.Collections.Generic;
using System.Linq;
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjIwNTA0QDMxMzcyZTM0MmUzMGtEQzlxQzMyb1gycERnQ1FHT3REdVBuSW5Icmovc1NwQVJGMS9IcFNta2c9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
           // Supervisor supervisor = new Supervisor("sas", "man@sas.com", "08888888",1, 12000, new DateTime(2020,1,1), new DateTime(2020, 1, 1), new DateTime());
            //supervisor.Insert();
            if (loginForm.currentUser != null)
            {
                Application.Run(new MainForm(loginForm.currentUser));
            }
        }
    }
}
