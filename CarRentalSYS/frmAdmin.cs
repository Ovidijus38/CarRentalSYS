using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSYS
{
    public partial class frmAdmin : Form
    {

        private frmMain parent;

        public frmAdmin(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnListDailyRent_Click(object sender, EventArgs e)
        {
            frmListDailyRent nextForm = new frmListDailyRent(this);
            this.Hide();
            // frmListDailyRent day = new frmListDailyRent();
            //day.Show();
            nextForm.Show();
        }

        private void btnYearlyRevenue_Click(object sender, EventArgs e)
        {
            frmYearlyRevenueAnalysis nextForm = new frmYearlyRevenueAnalysis(this);
            this.Hide();
            // frmYearlyRevenueAnalysis year = new frmYearlyRevenueAnalysis();
            //year.Show();
            nextForm.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
