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
    public partial class frmCars : Form
    {
        private frmMain parent;

        public frmCars(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmCars()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCar ac = new frmAddCar(this);
            ac.Show();
        }

        private void btnAddCarClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCarClass acc = new frmAddCarClass(this);
            acc.Show();
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmUpdateCar cr = new frmUpdateCar(this);
            cr.Show();
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmRemoveCar re = new frmRemoveCar(this);
            re.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {

        }

        private void frmCars_Load(object sender, EventArgs e)
        {

        }
    }
}
