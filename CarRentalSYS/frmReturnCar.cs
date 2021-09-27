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
    public partial class frmReturnCar : Form
    {
        frmBookings parent;
        public frmReturnCar()
        {
            InitializeComponent();
        }
        public frmReturnCar(frmBookings Parent)
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


       

        private void btnCheckBookings_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtBookingID.Text.Trim(), out int bookingIdInt))
            {
                List<string> bookingDataList = Booking.GetBookingDataByID(bookingIdInt);
                if (bookingDataList.Count == 0)
                {
                    MessageBox.Show("BookingID " + txtBookingID.Text.Trim() + " doesn't exist!!");
                    return;
                }
                txtCustomerName.Text = bookingDataList[0];
                txtCustomerLicenceNo.Text = bookingDataList[1];
                textBoxCustomerCountryCode.Text = bookingDataList[2];
                textBoxCustomerAddress.Text = bookingDataList[3];
                textBoxCustomerPostCode.Text = bookingDataList[4];
                txtPhoneNo.Text = bookingDataList[5];
                txtEmail.Text = bookingDataList[6];
                textBoxCarRegNo.Text = bookingDataList[7];
                textBoxCarMake.Text = bookingDataList[8];
                textBoxCarModel.Text = bookingDataList[9];
                textBoxBookingStartDateTime.Text = bookingDataList[10];
                textBoxBookingEndDateTime.Text = bookingDataList[11];
                textBoxCost.Text = bookingDataList[12] + " €";
                switch (bookingDataList[13])
                {
                    case "B":
                        textBoxBookingStatus.Text = "Booked";
                        break;
                    case "N":
                        textBoxBookingStatus.Text = "Canceled";
                        break;
                    case "R":
                        textBoxBookingStatus.Text = "Rented";
                        break;
                    case "C":
                        textBoxBookingStatus.Text = "Completed";
                        break;
                    default:
                        textBoxBookingStatus.Text = "Undefined";
                        break;
                }
                string carCollectDateTime = Booking.GetCarCollectDateTimeByBookingID(bookingIdInt);
                textBoxCollectDateTime.Text = carCollectDateTime;

                txtBookingID.ReadOnly = true;
                //Return Times
                comboBoxReturnTime.Items.Add(comboBoxReturnTime);

                const int firstHour = 8;
                const int lastHour = 18;
                for (var hour = firstHour; hour < lastHour; hour++)
                {
                    for (var minute = 0; minute <= 40; minute += 20)
                    {
                        comboBoxReturnTime.Items.Add($"{hour}:{minute:00}");
                    }
                }
                comboBoxReturnTime.Items.Add($"{lastHour}:00");
                btnCheckBookings.Enabled = false;
                grpBookingData.Visible = true;
                return;
            }
            else
            {
                MessageBox.Show("BookingID must be integer number !!");
                return;
            }
        }

        private void frmReturnCar_Load(object sender, EventArgs e)
        {

        }

        private void grpBookingData_Enter(object sender, EventArgs e)
        {

        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            if (textBoxBookingStatus.Text == "Rented")
            {
                if (comboBoxReturnTime.Text == string.Empty)
                {
                    MessageBox.Show("Return time must be selected !!");
                    comboBoxReturnTime.Focus();
                }
                else
                {

                    DateTime returnDate = dateTimePickerReturnDate.Value.Date;
                    string returnTimeString = comboBoxReturnTime.Text;
                    TimeSpan returnTimeSpan = TimeSpan.Parse(returnTimeString);
                    DateTime returnDateTime = returnDate.Add(returnTimeSpan);
                    DateTime bookingEndDateTime = DateTime.Parse(textBoxBookingEndDateTime.Text);

                    Int32.TryParse(txtBookingID.Text.Trim(), out int bookingIdInt);

                    string errorMessage = Booking.ReturnCarByBookingID(bookingIdInt, returnDateTime);

                    if (errorMessage == string.Empty)
                    {
                        btnReturnCar.Enabled = false;
                        // Apr 1 Update 
                        comboBoxReturnTime.Enabled = false;
                        if (returnDateTime <= bookingEndDateTime)
                        {
                            MessageBox.Show("Booked by booking ID " + txtBookingID.Text + " car is returned on time.");
                            return;
                        }
                        else
                        {
                            int delayInDays = (returnDateTime - bookingEndDateTime).Days;
                            if (delayInDays >=1)
                            {
                                int penalty = 100 * delayInDays;
                                MessageBox.Show("Booked by booking ID " + txtBookingID.Text + "  is returned with " + delayInDays + " days delay." +
                                    " Penalty " + penalty + "€ must be paid!!");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Booked by booking ID " + txtBookingID.Text + 
                                    "  is returned with delay less then 1 day. No penalty.");
                                return;
                            }

                            
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show(errorMessage);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Booked by booking ID " + txtBookingID.Text + " car can't be returned acording this booking status " +
                    textBoxBookingStatus.Text + " car has not been collected!!");
                return;
            }
        }
    }
}
