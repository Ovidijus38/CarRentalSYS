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
    public partial class frmCollectCar : Form
    {
        frmBookings parent;
        public frmCollectCar()
        {
            InitializeComponent();
        }
        public frmCollectCar(frmBookings Parent)
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
                //PickUp Times
                comboBoxCollectTime.Items.Add(comboBoxCollectTime);

                const int firstHour = 8;
                const int lastHour = 18;
                for (var hour = firstHour; hour < lastHour; hour++)
                {
                    for (var minute = 0; minute <= 40; minute += 20)
                    {
                        comboBoxCollectTime.Items.Add($"{hour}:{minute:00}");
                    }
                }
                comboBoxCollectTime.Items.Add($"{lastHour}:00");


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

        private void frmCollectCar_Load(object sender, EventArgs e)
        {

        }

        private void grpBookingData_Enter(object sender, EventArgs e)
        {

        }

        private void btnCollectCar_Click(object sender, EventArgs e)
        {
            if (textBoxBookingStatus.Text == "Booked")
            {
                if (comboBoxCollectTime.Text == string.Empty)
                {
                    MessageBox.Show("Collection time must be selected !!");
                    comboBoxCollectTime.Focus();
                }
                else
                {

                    DateTime collectiomDate = dateTimePickerCollectionDate.Value.Date;
                    string collectionTimeString = comboBoxCollectTime.Text;
                    TimeSpan collectionTimeSpan = TimeSpan.Parse(collectionTimeString);
                    DateTime collectiomDateTime = collectiomDate.Add(collectionTimeSpan);
                    DateTime bookingEndDateTime = DateTime.Parse(textBoxBookingEndDateTime.Text);
                    DateTime bookingStartDateTime = DateTime.Parse(textBoxBookingStartDateTime.Text);
                    if (collectiomDateTime >= bookingEndDateTime)
                    {
                        MessageBox.Show("Booked by booking ID " + txtBookingID.Text + " car can't be collected as this booking end time " +
                        textBoxBookingEndDateTime.Text + "is already passed!!");
                        return;
                    }
                    if (collectiomDateTime < bookingStartDateTime)
                    {
                        MessageBox.Show("Booked by booking ID " + txtBookingID.Text + " car can't be collected as this booking start time " +
                        textBoxBookingStartDateTime.Text + " has not yet come!!");
                        return;
                    }

                    Int32.TryParse(txtBookingID.Text.Trim(), out int bookingIdInt);

                    string errorMessage = Booking.CollectCarByBookingID(bookingIdInt, collectiomDateTime);

                    if (errorMessage == string.Empty)
                    {
                        btnCollectCar.Enabled = false;
                        MessageBox.Show("Booked by booking ID " + txtBookingID.Text + " car is collected");
                        return;

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
                MessageBox.Show("Booked by booking ID " + txtBookingID.Text + " car can't be collected as this booking status is " +
                    textBoxBookingStatus.Text + " !!");
                return;
            }
        }
    }
}
