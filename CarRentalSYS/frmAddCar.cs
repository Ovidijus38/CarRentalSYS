using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSYS
{
    public partial class frmAddCar : Form
    {
        frmCars parent;
        public frmAddCar()
        {
            InitializeComponent();
        }
        public frmAddCar(frmCars Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void transmissionlbl_Click(object sender, EventArgs e)
        {

        }

        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in
        //https://www.programiz.com/csharp-programming/foreach-loop
        //https://www.dotnetperls.com/foreach

        private void regNotxt_TextChanged(object sender, EventArgs e)
        {
            cboClassCode.Items.Clear();
            cboTransmission.Items.Clear();
            cboFuelType.Items.Clear();
            cboNoOfDoors.Items.Clear();

            List<string[]> catIdAndDescriptionList = Category.GetCatIdAndDescriptionList();

            foreach (string[] catIdAndDescription in catIdAndDescriptionList)
            {
                cboClassCode.Items.Add(catIdAndDescription[0] + "-" + catIdAndDescription[1]);
            }


            Utility.loadTransmissionType(cboTransmission);
            Utility.loadFuelTypes(cboFuelType);


            for (int i = 2; i < 6; i++)
            {
                cboNoOfDoors.Items.Add(i);
            }
        }

        private void AddCarbtn_Click(object sender, EventArgs e)
        {
            

            if (regNotxt.Text == "")
            {

                MessageBox.Show("Please enter reg number !!");
                regNotxt.Focus();
            }
            else if(cboClassCode.Text == "")
            {

                MessageBox.Show("Please select car class code !!");
                cboClassCode.Focus();
            }
            else if(maketxt.Text == "")
            {

                MessageBox.Show("Please enter make of a car !!");
                maketxt.Focus();
            }
            else if (!Regex.IsMatch(maketxt.Text, @"^([a-zA-Z]+[\s]*[a-zA-Z])*$"))
            {
                MessageBox.Show("Make must be alphabetical (1 or 2 words)!!");
                maketxt.Focus();
                return;
            }
            else if(modeltxt.Text == "")
            {

                MessageBox.Show("Please enter model of a car !!");
                modeltxt.Focus();
            }
            else if (!Regex.IsMatch(modeltxt.Text, "^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("Model must be alphanumeric without space !!");
                modeltxt.Focus();
                return;
            }
            else if(cboTransmission.Text == "")
            {

                MessageBox.Show("Please select car transmision type !!");
                cboTransmission.Focus();
            }
            else if(cboFuelType.Text == "")
            {

                MessageBox.Show("Please select type of the fuel !!");
                cboFuelType.Focus();
            }
            else if (cboNoOfDoors.Text == "")
            {

                MessageBox.Show("Please select number of doors !!");
                cboNoOfDoors.Focus();
            }
            else
            {
                int noOfDorsInt = int.Parse(cboNoOfDoors.Text);
                //Mar 27
                //Into the data base table Cars car class code must be inserted except desciption which is included in cboClassCode.Text
                string carClassCode = cboClassCode.Text.Split('-')[0];
                //Into the data base table Cars car transmition type must be inserted only the first letter which is included in cboTransmission.Text
                string carTransmitionTypeCode = cboTransmission.Text.Substring(0, 1);
                //Into the data base table Cars car fuel type must be inserted only the first letter which is included in cboFuelType.Text
                string carFuelTypeCode = cboFuelType.Text.Substring(0, 1);


                Car car = new Car(regNotxt.Text, carClassCode, maketxt.Text, modeltxt.Text, carTransmitionTypeCode, carFuelTypeCode,
                    noOfDorsInt, "A");

                string errorMessage = car.AddCar();


                if (errorMessage == string.Empty)
                {
                    MessageBox.Show(regNotxt.Text + " has been added!!");

                }
                else
                {
                    MessageBox.Show(errorMessage);
                    regNotxt.Focus();
                    return;
                }

                regNotxt.Clear();
                cboClassCode.Items.Clear();
                maketxt.Clear();
                modeltxt.Clear();
                cboTransmission.Items.Clear();
                cboFuelType.Items.Clear();
                cboNoOfDoors.Items.Clear();

            }

        }

        private void cboclassCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboclassCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTransmision_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
