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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin a = new frmAdmin(this);
            a.Show();

        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCars c = new frmCars(this);
            c.Show();
        }
        private void btnBookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookings b = new frmBookings(this);
            b.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
