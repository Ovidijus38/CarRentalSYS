using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace CarRentalSYS
{
    class Booking
    {       
        public Booking() : this(default, default, "", default, default,default, 'A')
        {

        }
        public Booking(int id, int customerId, string carRegNo, DateTime dateTimeFrom, 
            DateTime dateTimeTo, double bookingTotalCost, char status)
        {
            this.ID = id;
            this.CustomerID = customerId;
            this.CarRegNo = carRegNo;
            this.StartDateTime = dateTimeFrom;
            this.EndDateTime = dateTimeTo;
            this.BookingTotalCost = bookingTotalCost;
            this.Status = status;
        }
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public string CarRegNo { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public double BookingTotalCost { get; set; }

        public char Status { get; set; }

        //https://www.c-sharpcorner.com/article/working-with-hashset-in-c-sharp/

        public static HashSet<string> GetBookedCarsRegNoSetBetweenDates(DateTime dateTimeFrom, DateTime dateTimeTo)
        {

            HashSet<string> carsRegNoSet = new HashSet<string>();
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                //String sql = "Select Car_Reg_No from BOOKINGS Where (Start_Date >=:dateTimeFrom And Start_Date <=:dateTimeTo) " +
                //    "OR (End_Date >=:dateTimeFrom AND End_Date <=:dateTimeTo)";//Works but not estimates variation when dateTimeTo and dateTimeFrom is inside Start_Date and End_Date

                //String sql = "Select Car_Reg_No from BOOKINGS Where (Start_Date <:dateTimeFrom And End_Date <:dateTimeFrom) " +
                //    "OR (Start_Date >:dateTimeTo AND End_Date >:dateTimeTo)";

                //String sql = "Select Car_Reg_No from BOOKINGS Where (Start_Date <:dateTimeFrom And End_Date <:dateTimeFrom)"; //Works

                //String sql = "Select Car_Reg_No from BOOKINGS Where NOT ((Start_Date >:dateTimeTo AND End_Date >:dateTimeTo))";//Works

                //String sql = "Select Car_Reg_No from BOOKINGS Where NOT ((Start_Date >:dateTimeTo AND End_Date >:dateTimeTo) OR (Start_Date <:dateTimeFrom And End_Date <:dateTimeFrom))";//Doesn't Work
                //String sql = "Select Car_Reg_No from BOOKINGS Where (Start_Date >:dateTimeTo AND End_Date >:dateTimeTo) OR (Start_Date <:dateTimeFrom And End_Date <:dateTimeFrom)";//Doesn't Work

                String sql = "Select Car_Reg_No from BOOKINGS Where (Start_Date >=:dateTimeFrom And Start_Date <=:dateTimeTo) " +
                    "OR (End_Date >=:dateTimeFrom AND End_Date <=:dateTimeTo) OR (Start_Date <=:dateTimeFrom AND End_Date >=:dateTimeTo)";//Works

                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(":dateTimeFrom", dateTimeFrom);
                cmd.Parameters.Add(":dateTimeTo", dateTimeTo);
                conn.Open();

                //https://www.tutorialspoint.com/Try-Catch-Finally-in-Chash
                //https://www.c-sharpcorner.com/UploadFile/puranindia/try-catch-finally-in-C-Sharp/

                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        carsRegNoSet.Add(dr.GetValue(0).ToString());
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return carsRegNoSet;
        }
        public string AddBooking()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "INSERT INTO BOOKINGS (Booking_ID,Cust_ID,Car_Reg_No,Cost,Start_Date,End_Date," +
                    "Status) " +
                    "VALUES(:booking_ID,:custId,:carRegNo,:cost,:dateTimeFrom,:dateTimeTo,:status)";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":booking_ID", this.ID);
                cmd.Parameters.Add(":custId", this.CustomerID);
                cmd.Parameters.Add(":carRegNo", this.CarRegNo);
                cmd.Parameters.Add(":cost", this.BookingTotalCost);
                cmd.Parameters.Add(":dateTimeFrom", this.StartDateTime);
                cmd.Parameters.Add(":dateTimeTo", this.EndDateTime);
                cmd.Parameters.Add(":status", this.Status);
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    string errorMessage = "Problem with connection to database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;
                }
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("ORA-00001: unique constraint"))
                    {
                        string errorMessage = "This booking with ID - " + " already exists!!"
                            + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                        conn.Close();
                        return errorMessage;
                    }
                    else
                    {
                        string errorMessage = "The problem with booking data insertion into database!!"
                            + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                        conn.Close();
                        return errorMessage;
                    }
                }
            }
            return string.Empty;
        }
        public static List<string> GetBookingDataByID(int id)
        {
            List<string> bookingDataList = new List<string>();

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
                //https://www.c-sharpcorner.com/UploadFile/manas1/usage-and-importance-of-using-in-C-Sharp472/

                //String sql = "Select * from CARS Where Reg_No = '" + reg + "'";
                string sql = "SELECT cu.Name, cu.Licence_No, cu.Country_Code, cu.Address, cu.Post_Code," +
                        "cu.Phone_No, cu.Email, ca.Reg_No, ca.Make, ca.Model, b.Start_Date, b.End_Date, b.cost, b.Status " +
                        "FROM BOOKINGS b," +
                        "CUSTOMERS cu," +
                        "CARS ca " +
                        "WHERE b.Booking_ID = '" + id + "'" +
                        " AND cu.Cust_ID = b.Cust_ID AND ca.Reg_No = b.Car_Reg_No";



                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {

                    while (dr.Read())
                    {
                        bookingDataList.Add(dr.GetValue(0).ToString());
                        bookingDataList.Add(dr.GetValue(1).ToString());
                        bookingDataList.Add(dr.GetValue(2).ToString());
                        bookingDataList.Add(dr.GetValue(3).ToString());
                        bookingDataList.Add(dr.GetValue(4).ToString());
                        bookingDataList.Add(dr.GetValue(5).ToString());
                        bookingDataList.Add(dr.GetValue(6).ToString());
                        bookingDataList.Add(dr.GetValue(7).ToString());
                        bookingDataList.Add(dr.GetValue(8).ToString());
                        bookingDataList.Add(dr.GetValue(9).ToString());
                        bookingDataList.Add(dr.GetValue(10).ToString());
                        bookingDataList.Add(dr.GetValue(11).ToString());
                        bookingDataList.Add(dr.GetValue(12).ToString());
                        bookingDataList.Add(dr.GetValue(13).ToString());
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return bookingDataList;
        }
        public static string CancelBookingByID(int id)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "UPDATE BOOKINGS SET Status = 'N' Where Booking_ID =:id";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":id", id);
                
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    string errorMessage = "Problem with connection to database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;
                }
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    string errorMessage = "The problem with booking data updating in database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;

                }
            }
            return string.Empty;
        }

        public static int GetLastBookingID()
        {

            int lastBookingID = 0;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "SELECT MAX(BOOKING_ID) FROM BOOKINGS";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        lastBookingID = int.Parse(dr.GetValue(0).ToString());
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return lastBookingID;
        }
        public static string CollectCarByBookingID(int id, DateTime collectDateTime)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                //String sql = "UPDATE BOOKINGS SET STATUS='O' Where Booking_ID=:id";

                String sql = "UPDATE BOOKINGS SET STATUS='R', COLLECT_DATE=TO_DATE('" + collectDateTime + "','DD-MM-YYYY HH24:MI:SS') Where Booking_ID=:id";// correct date format
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":id", id);
                //cmd.Parameters.Add(":collDate", collectDateTime);
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    string errorMessage = "Problem with connection to database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;
                }
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    string errorMessage = "The problem with booking data updating in database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;

                }
            }
            return string.Empty;
        }

        public static string ReturnCarByBookingID(int id, DateTime returnDateTime)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                //String sql = "UPDATE BOOKINGS SET STATUS='O' Where Booking_ID=:id";

                //Apr 1 Update
                String sql = "UPDATE BOOKINGS SET STATUS='C', RETURN_DATE=TO_DATE('" + returnDateTime + "','DD-MM-YYYY HH24:MI:SS') Where Booking_ID=:id";// correct date and time
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":id", id);
                //cmd.Parameters.Add(":collDate", returnDateTime);
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    string errorMessage = "Problem with connection to database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;
                }
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    string errorMessage = "The problem with booking data updating in database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;

                }
            }
            return string.Empty;
        }

        public static string GetCarCollectDateTimeByBookingID(int id)
        {
            string carCollectDateTime = string.Empty;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {


                //String sql = "Select * from CARS Where Reg_No = '" + reg + "'";
                string sql = "SELECT COLLECT_DATE FROM BOOKINGS WHERE Booking_ID = '" + id + "'";

                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {

                    while (dr.Read())
                    {
                        carCollectDateTime = dr.GetValue(0).ToString();
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return carCollectDateTime;
        }

        //Update Mar 27
        public static List<int> GetBookingsIDs()
        {
            List<int> bookingsIds = new List<int>();
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "Select Booking_ID from BOOKINGS";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {

                    while (dr.Read())
                    {
                        bookingsIds.Add((int)dr.GetValue(0));
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return bookingsIds;
        }
        public static List<Booking> GetBookingsBetweenDates(DateTime dateTimeFrom, DateTime dateTimeTo)
        {

            List<Booking> bookings = new List<Booking>();
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "Select * from BOOKINGS Where (Start_Date >=:dateTimeFrom And Start_Date <=:dateTimeTo) " +
                    "OR (End_Date >=:dateTimeFrom AND End_Date <=:dateTimeTo) OR (Start_Date <=:dateTimeFrom AND End_Date >=:dateTimeTo)";//Works

                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(":dateTimeFrom", dateTimeFrom);
                cmd.Parameters.Add(":dateTimeTo", dateTimeTo);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        Booking booking = new Booking();
                        booking.ID = Convert.ToInt32(dr.GetValue(0));
                        booking.CustomerID = Convert.ToInt32(dr.GetValue(1));
                        booking.CarRegNo = dr.GetValue(2).ToString();
                        booking.BookingTotalCost = Convert.ToDouble(dr.GetValue(3));
                        booking.StartDateTime = Convert.ToDateTime(dr.GetValue(4));
                        booking.EndDateTime = Convert.ToDateTime(dr.GetValue(5));
                        booking.Status = dr.GetValue(8).ToString()[0];
                        bookings.Add(booking);

                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return bookings;
        }
    }
}
