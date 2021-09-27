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
    public partial class frmBookings : Form
    {

        private frmMain parent;
        public frmBookings(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmBookings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmCollectCar clt = new frmCollectCar(this);
            clt.Show();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            

            frmMakeBooking nextForm = new frmMakeBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmCancelBooking cb = new frmCancelBooking(this);
            cb.Show();
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmReturnCar rtn = new frmReturnCar(this);
            rtn.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmBookings_Load(object sender, EventArgs e)
        {

        }
    }
}
