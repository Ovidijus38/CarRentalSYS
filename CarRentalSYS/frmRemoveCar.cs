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
    public partial class frmRemoveCar : Form
    {
        frmCars parent;
        public frmRemoveCar()
        {
            InitializeComponent();
           
        }
        public frmRemoveCar(frmCars Parent)
        {
            InitializeComponent();
            parent = Parent;
            List<string> carsRegNoList = Car.GetAvailableCarsRegNo();
            foreach (string carRegNo in carsRegNoList)
            {
                cboRegNo.Items.Add(carRegNo);
            }
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

        private void btnCheckReg_Click(object sender, EventArgs e)
        {
            
            cboClassCode.Items.Clear();
            cboTransmission.Items.Clear();
            cboFuel.Items.Clear();
            cboNoOfDoors.Items.Clear();
            maketxt.Text = string.Empty;
            modeltxt.Text = string.Empty;
            lblAvailability.Text = string.Empty;
            

            if (cboRegNo.Text == string.Empty)
            {
                MessageBox.Show("Please select Reg No !!");
                cboRegNo.Focus();
            }
            else
            {
                Car car = Car.GetCarByRegNo(cboRegNo.Text);
                if (car.GetReg() == string.Empty)
                {
                    MessageBox.Show("Car with this Reg Number is absent in database!!");
                }
                else
                {
                    labelRegNumberValue.Text = car.GetReg();

                    //Update Apr1
                    string carCategoryCode = car.GetCategory();
                    List<string[]> catIdAndDescriptionList = Category.GetCatIdAndDescriptionList();
                    foreach (string[] catIdAndDescription in catIdAndDescriptionList)
                    {
                        if (catIdAndDescription[0] == carCategoryCode)
                        {
                            cboClassCode.Text = catIdAndDescription[0] + "-" + catIdAndDescription[1];
                            break;
                        }
                        
                    }
                    maketxt.Text = car.GetMake();
                    modeltxt.Text = car.GetModel();
                    cboTransmission.Text = car.GetTransmission();
                    cboFuel.Text = car.GetFuelType();
                    cboNoOfDoors.Text = car.GetNoOfDoors().ToString();
                    
                    switch (car.GetStatus())
                    {
                        case "A":
                            lblAvailability.Text = "Status: Available";
                            break;
                        case "O":
                            lblAvailability.Text = "Status: Out Of Service";
                            break;
                        case "R":
                            lblAvailability.Text = "Status: Rented";
                            break;
                        default:
                            break;
                    }
                }
            }
            maketxt.ReadOnly = true;
            modeltxt.ReadOnly = true;
            cboRegNo.Enabled = false;
            grpCarInfo.Visible = true;

        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            string errorMessage = Car.DeleteCarByRegNo(labelRegNumberValue.Text);
            if (errorMessage == string.Empty)
            {
                cboRegNo.Text = string.Empty;
                cboClassCode.Text = string.Empty;
                maketxt.Clear();
                modeltxt.Clear();
                cboTransmission.Text = string.Empty;
                cboFuel.Text = string.Empty;
                cboNoOfDoors.Text = string.Empty;
                MessageBox.Show(labelRegNumberValue.Text + " has been removed!!");

            }
            else
            {
                MessageBox.Show(errorMessage);
                cboRegNo.Focus();
                return;
            }
        }

        private void grpCarInfo_Enter(object sender, EventArgs e)
        {

        }

        private void frmRemoveCar_Load(object sender, EventArgs e)
        {
            Utility.loadAvailableCars(cboRegNo);
        }

        private void btnTakeOutOfService_Click(object sender, EventArgs e)
        {
            string errorMessage = Car.TakeCarOutOfServiceByRegNo(labelRegNumberValue.Text);
            if (errorMessage == string.Empty)
            {
                

                MessageBox.Show(labelRegNumberValue.Text + " has been taken out of service!!");

                Utility.loadAvailableCars(cboRegNo);
                
                grpCarInfo.Visible = false;
                cboRegNo.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show(errorMessage);
                cboRegNo.Focus();
                return;
            }

            

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
