using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentalSYS
{
    class Utility
    {
        public static void loadFuelTypes(ComboBox cboName)
        {
            cboName.Items.Add("Petrol");
            cboName.Items.Add("Diesel");
            cboName.Items.Add("Electric");
        }

        public static void loadTransmissionType(ComboBox cboName)
        {
            cboName.Items.Add("Manual");
            cboName.Items.Add("Automatic");
        }

        public static void loadStatusType(ComboBox cboName)
        {
            cboName.Items.Add("Available");
            cboName.Items.Add("Out Of Service");
            cboName.Items.Add("Rented");
        }

        
       
        public static void loadAvailableCars(ComboBox cboName)
        {

            List<string> carsRegNoList = Car.GetAvailableCarsRegNo();
            cboName.Items.Clear();
            foreach (string carRegNo in carsRegNoList)
            {
                cboName.Items.Add(carRegNo);
            }
            cboName.SelectedIndex = -1;
        }

        //Apr1 update
        public static void loadAllCars(ComboBox cboName)
        {

            List<string> carsRegNoList = Car.GetAllCarsRegNo();
            cboName.Items.Clear();
            foreach (string carRegNo in carsRegNoList)
            {
                cboName.Items.Add(carRegNo);
            }
            cboName.SelectedIndex = -1;
        }


        //Apr4 update
        public static double GetDailyRentForSelectedCarClass(string carsClassCode)
        {
            double selectedCarClassDailyRent = 0;

            DateTime todayStart = DateTime.Today;
            DateTime todayEnd = todayStart.AddDays(1).AddMinutes(-1);

            List<Booking> bookingsBetweenDates = Booking.GetBookingsBetweenDates(todayStart, todayEnd);
            if (bookingsBetweenDates.Count != 0 || bookingsBetweenDates != null)
            {

                List<Car> selectedCategoryAvailableCars = Car.GetAvailableCarsByCAT_ID(carsClassCode);

                // form carsRegNoSet
                //https://www.dotnetcurry.com/csharp/1362/hashset-csharp-with-examples
                //https://www.geeksforgeeks.org/hashset-in-c-sharp-with-examples/
                //https://www.c-sharpcorner.com/article/working-with-hashset-in-c-sharp/

                HashSet<string> carsRegNoSet = new HashSet<string>();
                foreach (Car car in selectedCategoryAvailableCars)
                {
                    carsRegNoSet.Add(car.GetReg());
                }
                
                // form selected category cars bookings between selected dates
                List<Booking> selectedCategoryCarsBookingsBetweenDatesList = new List<Booking>();
                foreach (Booking booking in bookingsBetweenDates)
                {
                    if (carsRegNoSet.Contains(booking.CarRegNo))
                    {
                        if (booking.Status == 'B'|| booking.Status == 'R' || booking.Status == 'C')
                        {
                            selectedCategoryCarsBookingsBetweenDatesList.Add(booking);
                        }
                        
                    }
                }
                

                if (selectedCategoryCarsBookingsBetweenDatesList.Count > 0)
                {
                    foreach (Booking booking in selectedCategoryCarsBookingsBetweenDatesList)
                    {
                        TimeSpan bookingTimeSpan = booking.EndDateTime.Subtract(booking.StartDateTime);

                        // + 1 because if car is booked for the day dates difference will be 0 days, but price must be calcualted for 1 day
                        int bookingDays = (int)bookingTimeSpan.Days + 1;
                        double carCostPerDay = booking.BookingTotalCost/bookingDays;
                        selectedCarClassDailyRent += carCostPerDay;
                    }
                }
            }

            return selectedCarClassDailyRent;
        }

        //april 24 update

        public static double GetSelectedYearSelectedMonthRevenueForSelectedCarClass(int year, int month, string carsClassCode)
        {
            double revenue = 0;

            DateTime firstMonthDayStart = new DateTime(year,month,1);
            DateTime lastMonthDayEnd = firstMonthDayStart.AddMonths(1).AddMinutes(-1);
            List<Booking> bookingsBetweenDates = Booking.GetBookingsBetweenDates(firstMonthDayStart, lastMonthDayEnd);
            if (bookingsBetweenDates.Count != 0 || bookingsBetweenDates != null)
            {

                List<Car> selectedCategoryAvailableCars = Car.GetAvailableCarsByCAT_ID(carsClassCode);

                // form carsRegNoSet
                HashSet<string> carsRegNoSet = new HashSet<string>();
                foreach (Car car in selectedCategoryAvailableCars)
                {
                    carsRegNoSet.Add(car.GetReg());
                }

                // form selected category cars bookings between selected dates
                List<Booking> selectedCategoryCarsBookingsBetweenDatesList = new List<Booking>();
                foreach (Booking booking in bookingsBetweenDates)
                {
                    if (carsRegNoSet.Contains(booking.CarRegNo))
                    {
                        if (booking.Status == 'B' || booking.Status == 'R' || booking.Status == 'C')
                        {
                            selectedCategoryCarsBookingsBetweenDatesList.Add(booking);
                        }

                    }
                }


                if (selectedCategoryCarsBookingsBetweenDatesList.Count > 0)
                {
                    foreach (Booking booking in selectedCategoryCarsBookingsBetweenDatesList)
                    {
                        //Simplified variation when all booking days are in one month - test data are formed according this rule
                        revenue += booking.BookingTotalCost;
                        
                    }
                }
            }

            return revenue;
        }



    }
}
