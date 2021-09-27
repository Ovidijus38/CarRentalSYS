using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace CarRentalSYS
{
    class Car
    {
        private String reg;
        private String category;
        private String make;
        private String model;
        private String transmission;
        private String fuelType;
        private int noOfDoors;
        private String status;
        public Car() : this("", "", "", "", "", "", 0, "A")
        {
        }

        public Car(String reg, String category, String make, String model, String transmission, String fuelType, int noOfDoors, String status)
        {
            SetReg(reg);
            SetCategory(category);
            SetMake(make);
            SetModel(model);
            SetTransmission(transmission);
            SetFuelType(fuelType);
            SetNoOfDoors(noOfDoors);
            SetStatus(status);
        }

        public String GetReg()
        {
            return reg;
        }

        public void SetReg(String reg)
        {
            this.reg = reg;
        }

        public String GetCategory()
        {
            return category;
        }

        public void SetCategory(String category)
        {
            this.category = category;
        }

        public String GetMake()
        {
            return make;
        }

        public void SetMake(String make)
        {
            this.make = make;
        }

        public String GetModel()
        {
            return model;
        }

        public void SetModel(String model)
        {
            this.model = model;
        }

        public String GetTransmission()
        {
            return transmission;
        }

        public void SetTransmission(String transmission)
        {
            this.transmission = transmission;
        }
        public String GetFuelType()
        {
            return fuelType;
        }

        public void SetFuelType(String fuelType)
        {
            this.fuelType = fuelType;
        }

        public int GetNoOfDoors()
        {
            return noOfDoors;
        }

        public void SetNoOfDoors(int noOfDoors)
        {
            this.noOfDoors = noOfDoors;
        }
        public string GetStatus()
        {
            return status;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }

        //https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-the-try-catch-block-to-catch-exceptions
        //https://docs.oracle.com/javase/tutorial/essential/exceptions/finally.html
        //https://www.tutlane.com/tutorial/csharp/try-catch-finally-in-csharp


        public string AddCar()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "INSERT INTO CARS (Reg_No,Cat_Id,Make,Model,Transmission,FuelType,NoOfDoors, Status) " +
                    "VALUES(:reg,:category,:make,:model,:transmission,:fuelType,:noOfDoors,:status)";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":reg", this.reg);
                cmd.Parameters.Add(":category", this.category);
                cmd.Parameters.Add(":make", this.make);
                cmd.Parameters.Add(":model", this.model);
                cmd.Parameters.Add(":transmission", this.transmission);
                cmd.Parameters.Add(":fuelType", this.fuelType);
                cmd.Parameters.Add(":noOfDoors", this.noOfDoors);
                cmd.Parameters.Add(":status", this.status);
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
                        string errorMessage = "This car reg number - " + this.reg + " already exists, please enter a different reg number!!"
                            + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                        conn.Close();
                        return errorMessage;
                    }
                    else
                    {
                        string errorMessage = "The problem with car data insertion into database!!"
                            + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                        conn.Close();
                        return errorMessage;
                    }
                }
            }
            return string.Empty;
        }

        public static Car GetCarByRegNo(string reg)
        {
            Car car = new Car();
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                String sql = "Select * from CARS Where Reg_No = '" + reg + "'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    
                    while (dr.Read())
                    {
                        car.SetReg(dr.GetValue(0).ToString());
                        car.SetCategory(dr.GetValue(1).ToString());
                        car.SetMake(dr.GetValue(2).ToString());
                        car.SetModel(dr.GetValue(3).ToString());
                        car.SetTransmission(dr.GetValue(4).ToString());
                        car.SetFuelType(dr.GetValue(5).ToString());
                        car.SetNoOfDoors(Convert.ToInt32(dr.GetValue(6)));
                        car.SetStatus(dr.GetValue(7).ToString());

                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return car;
        }

        public string UpdateCar()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "UPDATE CARS SET Cat_Id = :category, Make = :make, Model =:model, Transmission=:transmission," +
                    "FuelType =:fuelType, NoOfDoors=:noOfDoors, Status=:status Where Reg_No =:reg";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":category", this.category);
                cmd.Parameters.Add(":make", this.make);
                cmd.Parameters.Add(":model", this.model);
                cmd.Parameters.Add(":transmission", this.transmission);
                cmd.Parameters.Add(":fuelType", this.fuelType);
                cmd.Parameters.Add(":noOfDoors", this.noOfDoors.ToString());
                cmd.Parameters.Add(":status", this.status);
                cmd.Parameters.Add(":reg", this.reg);
                


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
                    
                    string errorMessage = "The problem with car data updating in database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;
                    
                }
            }
            return string.Empty;
        }
        public static string DeleteCarByRegNo(string reg)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                
                String sql = "Delete from CARS Where Reg_No =:reg";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":reg", reg);
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

                    string errorMessage = "The problem with car data deleting from database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;

                }
            }
            return string.Empty;

        }

        public static List<string> GetAvailableCarsRegNo()
        {

            List<string> carsRegNoList = new List<string>(); 
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                String sql = "Select REG_NO from CARS WHERE Status = 'A'";
                //Apr 1 update
                
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        carsRegNoList.Add(dr.GetValue(0).ToString());
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return carsRegNoList;
        }

        public static List<string> GetAllCarsRegNo()
        {

            List<string> carsRegNoList = new List<string>();
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                String sql = "Select REG_NO from CARS";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        carsRegNoList.Add(dr.GetValue(0).ToString());
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return carsRegNoList;
        }

        public static string TakeCarOutOfServiceByRegNo(string reg)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "UPDATE CARS SET Status = :availability Where Reg_No =:reg";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":availability", 'O');
                cmd.Parameters.Add(":reg", reg);

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

                    string errorMessage = "The problem with car availability updating in database!!"
                        + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                    conn.Close();
                    return errorMessage;

                }
            }
            return string.Empty;

        }
        public static List<Car> GetAvailableCarsByCAT_ID(string catID)
        {

            List<Car> cars = new List<Car>();

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                
                String sql = "Select * from CARS Where CAT_ID =:catID And Status = 'A'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":catID", catID);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        Car car = new Car();
                        car.SetReg(dr.GetValue(0).ToString());
                        car.SetCategory(dr.GetValue(1).ToString());
                        car.SetMake(dr.GetValue(2).ToString());
                        car.SetModel(dr.GetValue(3).ToString());
                        car.SetTransmission(dr.GetValue(4).ToString());
                        car.SetFuelType(dr.GetValue(5).ToString());
                        car.SetNoOfDoors(Convert.ToInt32(dr.GetValue(6)));
                        /*car.SetAvailable(dr.GetValue(7).ToString()[0])*/;
                        cars.Add(car);
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return cars;
        }


    }
}
