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
            //User user = new User("Test", "test@test.com", "12345678");
            //user.Insert();
            //User.GetById(1).Delete();
            //user.Delete();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjIwNTA0QDMxMzcyZTM0MmUzMGtEQzlxQzMyb1gycERnQ1FHT3REdVBuSW5Icmovc1NwQVJGMS9IcFNta2c9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainForm());
        }
    }
}
