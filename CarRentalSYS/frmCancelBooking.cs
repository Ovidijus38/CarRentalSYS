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
    public partial class frmCancelBooking : Form
    {
        frmBookings parent;
        public frmCancelBooking()
        {
            InitializeComponent();
        }
        public frmCancelBooking(frmBookings Parent)
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


        //https://www.c-sharpcorner.com/UploadFile/mahesh/trim-string-in-C-Sharp/
        //https://www.geeksforgeeks.org/c-sharp-trim-method/
        //https://www.tutorialspoint.com/chash-trim-method

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
                txtBookingID.ReadOnly = true;
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

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {

        }

        private void grpBookingData_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (textBoxBookingStatus.Text== "Booked")
            {
                Int32.TryParse(txtBookingID.Text.Trim(), out int bookingIdInt);
                string errorMessage = Booking.CancelBookingByID(bookingIdInt);
                btnCancelBooking.Enabled = false;
                if (errorMessage == string.Empty)
                {
                    MessageBox.Show("Booking Cancelled");
                    return;

                }
                else
                {
                    MessageBox.Show(errorMessage);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Booking can't be cancelled because it status is " + textBoxBookingStatus.Text + "!!");
                return;
            }

            



            
        }
    }
}
