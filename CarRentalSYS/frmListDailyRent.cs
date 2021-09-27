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
    public partial class frmListDailyRent : Form
    {
        public frmAdmin parent;

        public frmListDailyRent(frmAdmin Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmListDailyRent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListDailyRent_Load(object sender, EventArgs e)
        {
            //Apr 3 update
            List<string[]> catIdAndDescriptionList = Category.GetCatIdAndDescriptionList();
            foreach (string[] catIdAndDescription in catIdAndDescriptionList)
            {
                cboChooseCarClass.Items.Add(catIdAndDescription[0] + "-" + catIdAndDescription[1]);
            }

        }


        private void btnShowAnalysis_Click(object sender, EventArgs e)
        {
            if (cboChooseCarClass.Text == "")
            {

                MessageBox.Show("Please select car class !!");
                cboChooseCarClass.Focus();
            }
            else
            {
                //Apr 3 update
                //Into the data base table Cars car class code is except desciption which is included in cboChooseCarClass.Text

                //https://www.geeksforgeeks.org/string-split-method-in-c-sharp-with-examples/
                //https://www.dotnetperls.com/split
                //https://www.educative.io/edpresso/what-is-the-split-method-in-c-sharp

                string carClassCode = cboChooseCarClass.Text.Split('-')[0];
                double selectedCarClassDailyRent = Utility.GetDailyRentForSelectedCarClass(carClassCode);

                lstRentDisplay.Items.Add("This car class generate of " + selectedCarClassDailyRent + " euros today");

                //if (cboChooseCarClass.Text.Equals("EC - Economy"))
                //{
                //    lstRentDisplay.Items.Add("This car class generate of 500 euros today");

                //}
                //if (cboChooseCarClass.Text.Equals("PM - Premium"))
                //{
                //    lstRentDisplay.Items.Add("This car class generate of 1000 euros today");

                //}
                //if (cboChooseCarClass.Text.Equals("EC - Deluxe"))
                //{
                //    lstRentDisplay.Items.Add("This car class generate of 1500 euros today");

                //}
                grpTotalRent.Visible = true;
            }


            

        }

        private void grpTotalDaily_Enter(object sender, EventArgs e)
        {

        }

        private void cboChooseCarClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void grpTotalRent_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;


        }
    }
}
