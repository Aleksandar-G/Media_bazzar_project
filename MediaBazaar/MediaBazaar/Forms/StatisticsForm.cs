using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaar.Forms
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            this.BackColor = ApplicationColors.PrimaryDark;
            this.btnClose.BackColor = ApplicationColors.Red;
            this.btnBestSeller.BackColor = ApplicationColors.Orange;
            this.cmbDepartments.BackColor = ApplicationColors.Orange;
            this.btnLastWeek.BackColor = ApplicationColors.Orange;
            this.btnStatByDepartment.BackColor = ApplicationColors.Orange;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }
}
