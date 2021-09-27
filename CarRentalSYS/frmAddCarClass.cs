using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CarRentalSYS
{
    public partial class frmAddCarClass : Form
    {
        frmCars parent;
        
        public frmAddCarClass()
        {
            InitializeComponent();
            this.ActiveControl = txtCode;
        }
        public frmAddCarClass(frmCars Parent)
        {
            InitializeComponent();
            parent = Parent;
            this.ActiveControl = txtCode;
        }

        private void AddCarClassbtn_Click(object sender, EventArgs e)
        {
            //string carClassCode = txtCode.Text;
            txtCode.Focus();
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Please enter car class code !!");
                txtCode.Focus();
                return;
            }
            if (txtCode.Text.Length != 2 )
            {
                MessageBox.Show("Car class code must be 2 letters length !!");
                txtCode.Focus();
                return;
            }

            //https://stackoverflow.com/questions/1181419/verifying-that-a-string-contains-only-letters-in-c-sharp
            //https://www.dotnetperls.com/regex
            //https://www.c-sharpcorner.com/article/c-sharp-regex-examples/

            if (!Regex.IsMatch(txtCode.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Car class code must be alphabetical !!");
                txtCode.Focus();
                return;
            }
            
            if(string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter description !!");
                txtDescription.Focus();
                return;
            }
            if (int.TryParse(txtDescription.Text, out int number))
            {
                MessageBox.Show("Description can not be numeric!!");
                txtDescription.Focus();
                return;
            }

            if(!double.TryParse(txtRate.Text, out double vRate))
            {
                MessageBox.Show("Please enter only numbers!!");
                txtRate.Focus();
                return;
            }

            if(vRate > 999.99)
            {
                MessageBox.Show("The maximum cost is 999.99 €!!");
                txtRate.Focus();
                return;
            }

            Category cat = new Category(txtCode.Text, txtDescription.Text, vRate);

            string errorMessage = cat.AddCategory();


            if(errorMessage== string.Empty)
            {
                MessageBox.Show(txtCode.Text + " has been added!!");
                
            }
            else
            {
                MessageBox.Show(errorMessage);
                txtCode.Focus();
                return;
            }

            txtCode.Clear();
            txtDescription.Clear();
            txtRate.Clear();
        }

        private void cboClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtRate.Clear();
        }

      

        

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddCarClass_Load(object sender, EventArgs e)
        {

        }
    }
}
