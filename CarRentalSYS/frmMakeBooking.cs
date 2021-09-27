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
    public partial class frmMakeBooking : Form
    {
        frmBookings parent;
        public frmMakeBooking()
        {
            InitializeComponent();
        }
        public frmMakeBooking(frmBookings Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            //Load Cars Classes
            List<string[]> catIdAndDescriptionList = Category.GetCatIdAndDescriptionList();
            foreach (string[] catIdAndDescription in catIdAndDescriptionList)
            {
                cboClasses.Items.Add(catIdAndDescription[0] + "-" + catIdAndDescription[1]);
            }

            //PickUp Times
            cboPickUpTime.Items.Add(cboPickUpTime);

            const int firstHour = 8;
            const int lastHour = 18;
            for (var hour = firstHour; hour < lastHour; hour++)
            {
                for (var minute = 0; minute <= 40; minute += 20)
                {
                    cboPickUpTime.Items.Add($"{hour}:{minute:00}");
                }
            }
            cboPickUpTime.Items.Add($"{lastHour}:00");



            //Drop Off Times
            cboDropTime.Items.Add(cboDropTime);

            const int firstHour1 = 8;
            const int lastHour1 = 18;
            for (var hour = firstHour1; hour < lastHour1; hour++)
            {
                for (var minute = 0; minute <= 40; minute += 20)
                {
                    cboDropTime.Items.Add($"{hour}:{minute:00}");
                }
            }
            cboDropTime.Items.Add($"{lastHour1}:00");
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter customers full name !!");
                txtName.Focus();

            }
            else if (txtLicenceNo.Text == "")
            {
                MessageBox.Show("Please enter customers licence No !!");
                txtLicenceNo.Focus();
            }
            else if (txtCountryCode.Text == "")
            {
                MessageBox.Show("Please enter customers country 2 letters code !!");
                txtCountryCode.Focus();
            }
            else if (txtCountryCode.Text.Length != 2)
            {
                MessageBox.Show("Country code must be 2 letters length. Please enter correct country 2 letters code !!");
                txtCountryCode.Focus();
            }
            else if (!Regex.IsMatch(txtCountryCode.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Country code must be alphabetical !!");
                txtCountryCode.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter customers e - mail address !!");
                txtEmail.Focus();
            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please enter customers phone number !!");
                txtPhoneNo.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter customers address !!");
                txtAddress.Focus();
            }
            else if (txtPostCode.Text == "")
            {
                MessageBox.Show("Please enter customers post code !!");
                txtPostCode.Focus();
            }
            else
            {
                List<int> customersIds = Customer.GetCustomersIDs();
                int newCustomerID = 0;
                if (customersIds.Count == 0)
                {
                    newCustomerID = 1;
                }
                else
                {
                    int lastCustomerID = Customer.GetLastCustomerID();
                    newCustomerID = lastCustomerID + 1;
                }

                //Trim is used because these fields will be used in composite primary key and additional spaces in them can lead into incorrect data formation
                //https://www.c-sharpcorner.com/UploadFile/mahesh/trim-string-in-C-Sharp/
                //https://docs.microsoft.com/en-us/dotnet/api/system.string.trim?view=net-5.0
                //https://docs.microsoft.com/en-us/dotnet/standard/base-types/trimming
                //https://www.geeksforgeeks.org/c-sharp-trim-method/

                Customer customer = new Customer(newCustomerID, txtCountryCode.Text.Trim(), txtLicenceNo.Text.Trim(), txtName.Text, txtAddress.Text,
                    txtPostCode.Text, txtPhoneNo.Text, txtEmail.Text);

                string errorMessage = customer.AddCustomer();


                if (errorMessage == string.Empty)
                {
                    MessageBox.Show("Customer from country " + txtCountryCode.Text + " and licence No " + txtLicenceNo.Text + " has been added! This customer ID " + newCustomerID);
                    btnAddCustomer.Enabled = false;
                    btnSearchCustByLicNoAndCountryCode.Enabled = false;
                    txtName.ReadOnly = true;
                    txtLicenceNo.ReadOnly = true;
                    txtCountryCode.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPhoneNo.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtPostCode.ReadOnly = true;
                    labelCustomerIdValue.Text = newCustomerID.ToString();
                    labelCustomerIdValue.Visible = true;
                    labelCustomerID.Visible = true;

                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
                txtLicenceNo.Focus();
                return;

            }

        }

        private void makeBookingbtn_Click(object sender, EventArgs e)
        {
            string test = string.Empty;
            string selectedCarData = lstCars.GetItemText(lstCars.SelectedItem);
            string selectedCarRegNo = selectedCarData.Split(' ')[0];


            if (selectedCarRegNo ==string.Empty)
            {
                MessageBox.Show("The problem with selected car register number!!");
            }
            else
            {
                DateTime dateFrom = dtpDateFrom.Value.Date;
                DateTime dateTo = dtpDateTo.Value.Date;
                string pickUpTimeString = cboPickUpTime.Text;
                TimeSpan pickUpTimeSpan = TimeSpan.Parse(pickUpTimeString);
                DateTime dateTimeFrom = dateFrom.Add(pickUpTimeSpan);
                string dropTimeString = cboDropTime.Text;
                TimeSpan dropTimeSpan = TimeSpan.Parse(dropTimeString);
                DateTime dateTimeTo = dateTo.Add(dropTimeSpan);

                //Apr 1 updates
                TimeSpan bookingTimeSpan = dateTo.Subtract(dateFrom);
                // + 1 because if car is booked for the day dates difference will be 0 days, but price must be calcualted for 1 day
                int bookingDays = (int)bookingTimeSpan.Days + 1;
                string carClassCode = cboClasses.Text.Split('-')[0];
                double catCostPerDay = Category.GetCostPerDayByCatId(carClassCode);
                double bookingTotalCost = catCostPerDay * bookingDays;

                int customerId = int.Parse(labelCustomerIdValue.Text);

                List<int> bookingsIds = Booking.GetBookingsIDs();
                int newBookingID = 0;
                if (bookingsIds.Count == 0)
                {
                    newBookingID = 1;
                }
                else
                {
                    int lastBookingID = Booking.GetLastBookingID();
                    newBookingID = lastBookingID + 1;
                }

                Booking booking = new Booking(newBookingID, customerId, selectedCarRegNo, dateTimeFrom, dateTimeTo, bookingTotalCost, 'B');

                string errorMessage = booking.AddBooking();


                if (errorMessage == string.Empty)
                {
                    makeBookingbtn.Enabled = false;
                    MessageBox.Show(" Booking has been added!! Booking ID - " + newBookingID);
                    //MessageBox.Show("Reservation succsefull.");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                    
                    return;
                }
            }
            //returnDateAndTimetxt.Focus();
            return;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lstCars.Items.Clear();

            DateTime dateFrom = dtpDateFrom.Value.Date;
            DateTime dateTo = dtpDateTo.Value.Date;
            if (dateTo < dateFrom)
            {
                MessageBox.Show("Return date to must be later then Pickup date. Select correct dates !!");
                dtpDateFrom.Focus();
            }
            else if (cboPickUpTime.Text == "")
            {
                MessageBox.Show("Pickup up time must be selected !!");
                cboPickUpTime.Focus();

            }
            else if (cboDropTime.Text == "")
            {
                MessageBox.Show("Drop off time must be selected !!");
                cboDropTime.Focus();
            }
            else
            {
                string pickUpTimeString = cboPickUpTime.Text;
                TimeSpan pickUpTimeSpan = TimeSpan.Parse(pickUpTimeString);
                DateTime dateTimeFrom = dateFrom.Add(pickUpTimeSpan);
                string dropTimeString = cboDropTime.Text;
                TimeSpan dropTimeSpan = TimeSpan.Parse(dropTimeString);
                DateTime dateTimeTo = dateFrom.Add(dropTimeSpan);

                //Update Mar 27
                //From the data base table Cars cars according class code can be extracted. Cars class code must be extracted from 
                //cboClasses.Text as here is car class code and car clas description delimited by hyphen
                //https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
                //https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-5.0

                string carsClassCode = cboClasses.Text.Split('-')[0];
                List<Car> selectedCategoryAvailableCars = Car.GetAvailableCarsByCAT_ID(carsClassCode);

                HashSet<string> bookedBetweenRequiredDatesCarsRegNoSet = Booking.GetBookedCarsRegNoSetBetweenDates(dateTimeFrom, dateTimeTo);

                if (bookedBetweenRequiredDatesCarsRegNoSet.Count == 0 || bookedBetweenRequiredDatesCarsRegNoSet == null)
                {
                    foreach (Car car in selectedCategoryAvailableCars)
                    {
                        lstCars.Items.Add(car.GetReg() + " " + car.GetMake() + " " + car.GetModel() + " " + car.GetTransmission() + " " + car.GetFuelType() + " " + car.GetNoOfDoors() + "-doors");
                    }
                }
                else
                {
                    foreach (Car car in selectedCategoryAvailableCars)
                    {
                        if (!bookedBetweenRequiredDatesCarsRegNoSet.Contains(car.GetReg()))
                        {
                            lstCars.Items.Add(car.GetReg() + " " + car.GetMake() + " " + car.GetModel() + " " + car.GetTransmission() + " " + car.GetFuelType() + " " + car.GetNoOfDoors() + "-doors");
                        }

                    }
                }
                dtpDateFrom.Enabled = false;
                dtpDateTo.Enabled = false;
                cboClasses.Enabled = false;
                cboPickUpTime.Enabled = false;
                cboDropTime.Enabled = false;
                btnCheck.Enabled = false;

            }
            txtLicenceNo.Focus();
            grpCars.Visible = true;

        }

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update Mar 27
            string carClassCode = cboClasses.Text.Split('-')[0];
            double catCostPerDay = Category.GetCostPerDayByCatId(carClassCode);
            DateTime dateFrom = dtpDateFrom.Value.Date;
            DateTime dateTo = dtpDateTo.Value.Date;
            TimeSpan bookingTimeSpan = dateTo.Subtract(dateFrom);

            // + 1 because if car is booked for the day dates difference will be 0 days, but price must be calcualted for 1 day

            int bookingDays = (int)bookingTimeSpan.Days + 1;

            double bookingTotalCost = catCostPerDay * bookingDays;

            labelBookingPrice.Text = "Car booking price per day - " + catCostPerDay + "€.\r\n" + 
                                      "Days of booking - " + bookingDays + ".\r\n" +
                                      "Booking total price - " + bookingTotalCost + "€.";

            grpCustomer.Visible = true;
            labelCustomerID.Visible = false;
            labelCustomerIdValue.Visible = false;
            groupBoxBookingPrice.Visible = true;
            lstCars.Enabled = false;
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

        private void btnSearchCustByLicNoAndCountryCode_Click(object sender, EventArgs e)
        {
            if (txtLicenceNo.Text == "")
            {
                MessageBox.Show("Please enter customers licence No !!");
                txtLicenceNo.Focus();
            }
            else if (txtCountryCode.Text == "")
            {
                MessageBox.Show("Please enter customers country 2 letters code !!");
                txtCountryCode.Focus();
            }
            else if (txtCountryCode.Text.Length != 2)
            {
                MessageBox.Show("Country code must be 2 letters length. Please enter correct country 2 letters code !!");
                txtCountryCode.Focus();
            }
            else if (!Regex.IsMatch(txtCountryCode.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Country code must be alphabetical !!");
                txtCountryCode.Focus();
            }
            else
            {
                Customer customer = Customer.GetCustomerByLicenceNoAndCountryCode(txtLicenceNo.Text.Trim(), txtCountryCode.Text.Trim());
                if (customer.LicenceNo == string.Empty)
                {
                    MessageBox.Show("Customer with this Licence No and Country code is not in database!!");
                }
                else
                {
                    txtName.Text = customer.Name;
                    txtLicenceNo.Text = customer.LicenceNo;
                    txtCountryCode.Text = customer.CountryCode; 
                    txtEmail.Text = customer.Email;
                    txtPhoneNo.Text = customer.PhoneNo;
                    txtAddress.Text = customer.Address;
                    txtPostCode.Text = customer.PostCode;

                    btnAddCustomer.Enabled = false;
                    btnSearchCustByLicNoAndCountryCode.Enabled = false;
                    txtName.ReadOnly = true;
                    txtLicenceNo.ReadOnly = true;
                    txtCountryCode.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPhoneNo.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtPostCode.ReadOnly = true;

                    labelCustomerIdValue.Text = customer.ID.ToString();
                    labelCustomerIdValue.Visible = true;
                    labelCustomerID.Visible = true;


                }
            }
        }
    }
}