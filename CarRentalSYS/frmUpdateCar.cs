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
    public partial class frmUpdateCar : Form
    {
        frmCars parent;
        public frmUpdateCar()
        {
            InitializeComponent();

            
        }
        public frmUpdateCar(frmCars Parent)
        {
            InitializeComponent();

            parent = Parent;
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
            comboBoxStatus.Items.Clear();

            if (cboRegNo.Text==string.Empty)
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

                    //Update Mar 27
                    string carCategoryCode = car.GetCategory();
                    List<string[]> catIdAndDescriptionList = Category.GetCatIdAndDescriptionList();
                    foreach (string[] catIdAndDescription in catIdAndDescriptionList)
                    {
                        if (catIdAndDescription[0] == carCategoryCode)
                        {
                            cboClassCode.Text = catIdAndDescription[0] + "-" + catIdAndDescription[1];
                        }
                        cboClassCode.Items.Add(catIdAndDescription[0] + "-" + catIdAndDescription[1]);
                    }

                    maketxt.Text = car.GetMake();
                    modeltxt.Text = car.GetModel();

                    //Update Mar 27
                    string carTransmitionTypeCode = car.GetTransmission();
                    Utility.loadTransmissionType(cboTransmission);
                    foreach (string item in cboTransmission.Items)
                    {
                        if (item.Substring(0,1) == carTransmitionTypeCode)
                        {
                            cboTransmission.Text = item;
                            break;
                        }
                    }
                    string carFuelTypeCode = car.GetFuelType();
                    Utility.loadFuelTypes(cboFuel);
                    foreach (string item in cboFuel.Items)
                    {
                        if (item.Substring(0, 1) == carFuelTypeCode)
                        {
                            cboFuel.Text = item;
                            break;
                        }
                    }

                    cboNoOfDoors.Text = car.GetNoOfDoors().ToString();

                    for (int i = 2; i < 6; i++)
                    {
                        cboNoOfDoors.Items.Add(i);
                    }

                    //Apr 1
                    Utility.loadStatusType(comboBoxStatus);
                    string carStatus = car.GetStatus().ToString();
                    foreach (string item in comboBoxStatus.Items)
                    {
                        if (item.Substring(0, 1) == carStatus)
                        {
                            comboBoxStatus.Text = item;
                            break;
                        }
                    }
                }
                
            }
            grpCarInfo.Visible = true;
        }

        //https://docs.microsoft.com/en-us/dotnet/standard/base-types/substitutions-in-regular-expressions
        //https://stackoverflow.com/questions/8764827/c-sharp-regex-validation-rule-using-regex-match

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (cboClassCode.Text == "")
            {

                MessageBox.Show("Please select car class code !!");
                cboClassCode.Focus();
            }
            else if (maketxt.Text == "")
            {

                MessageBox.Show("Please enter make of a car !!");
                maketxt.Focus();
            }
            else if (!Regex.IsMatch(maketxt.Text, @"^([a-zA-Z]+[\s]*[a-zA-Z])*$"))
            {
                MessageBox.Show("Make must be alphabetical (1 or 2 words) !!");
                maketxt.Focus();
                return;
            }
            else if (modeltxt.Text == "")
            {

                MessageBox.Show("Please enter model of a car !!");
                modeltxt.Focus();
            }
            else if (!Regex.IsMatch(modeltxt.Text, @"^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("Model must be alphanumeric without spaces!!");
                modeltxt.Focus();
                return;
            }
            else if (cboTransmission.Text == "")
            {

                MessageBox.Show("Please select car transmision type !!");
                cboTransmission.Focus();
            }
            else if (cboFuel.Text == "")
            {

                MessageBox.Show("Please select type of the fuel !!");
                cboFuel.Focus();
            }
            else if (cboNoOfDoors.Text == "")
            {

                MessageBox.Show("Please select number of doors !!");
                cboNoOfDoors.Focus();
            }
            else if (comboBoxStatus.Text == "")
            {

                MessageBox.Show("Please select car status !!");
                comboBoxStatus.Focus();
            }
            else
            {
                //Mar 27
                //Into the data base table Cars car class code must be inserted except desciption which is included in cboClassCode.Text
                string carClassCode = cboClassCode.Text.Split('-')[0];
                //Into the data base table Cars car transmition type must be inserted only the first letter which is included in cboTransmission.Text
                string carTransmitionTypeCode = cboTransmission.Text.Substring(0, 1);
                //Into the data base table Cars car fuel type must be inserted only the first letter which is included in cboFuelType.Text
                string carFuelTypeCode = cboFuel.Text.Substring(0, 1);
                //Into the data base table Cars car status type must be inserted only the first letter which is included in cboFuelType.Text
                string carStatusTypeCode = comboBoxStatus.Text.Substring(0, 1);

                Car car = new Car(labelRegNumberValue.Text, carClassCode, maketxt.Text, modeltxt.Text, carTransmitionTypeCode,
                carFuelTypeCode, Convert.ToInt32(cboNoOfDoors.Text), carStatusTypeCode);

                string errorMessage = car.UpdateCar();

                if (errorMessage == string.Empty)
                {
                    MessageBox.Show(labelRegNumberValue.Text + " has been updated!!");

                    //reset user interface
                    grpCarInfo.Visible = false;
                    

                    Utility.loadAvailableCars(cboRegNo);
                    cboRegNo.SelectedIndex = -1;


                }

                else
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
                //reset user interface
                grpCarInfo.Visible = false;
                cboRegNo.SelectedIndex = -1;

            }



        }

        private void grpCarInfo_Enter(object sender, EventArgs e)
        {

        }

        private void frmUpdateCar_Load(object sender, EventArgs e)
        {
            Utility.loadAllCars(cboRegNo);
                
        }
        
    }
}
