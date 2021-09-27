using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace CarRentalSYS
{
    class Customer
    {
        public Customer() : this(default,"", "", "", "", "", "","")
        {
        }
        public Customer(int id, string countryCode, string licenceNo,  string name, string address, string postCode, string phoneNo, 
            string email)
        {
            this.ID = id;
            this.CountryCode = countryCode;
            this.LicenceNo = licenceNo;
            this.Name = name;
            this.Address = address;
            this.PostCode = postCode;
            this.PhoneNo = phoneNo;
            this.Email = email;
        }
        public int ID { get; set; }
        public string CountryCode { get; set; }
        public string LicenceNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        public string AddCustomer()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "INSERT INTO CUSTOMERS (Cust_ID, Country_Code,Licence_No,Name,Address,Post_Code,Phone_No, Email) " +
                    "VALUES(:custID,:countryCode,:licenceNo,:name,:address,:postCode,:phoneNo,:email)";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":custID", this.ID);
                cmd.Parameters.Add(":countryCode", this.CountryCode);
                cmd.Parameters.Add(":licenceNo", this.LicenceNo);
                cmd.Parameters.Add(":name", this.Name);
                cmd.Parameters.Add(":address", this.Address);
                cmd.Parameters.Add(":postCode", this.PostCode);
                cmd.Parameters.Add(":phoneNo", this.PhoneNo);
                cmd.Parameters.Add(":email", this.Email);
               
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
                        string errorMessage = "This customer with id - " + this.ID + " already exists, please enter a different ID!!"
                            + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                        conn.Close();
                        return errorMessage;
                    }
                    else
                    {
                        string errorMessage = "The problem with customer data insertion into database!!"
                            + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                        conn.Close();
                        return errorMessage;
                    }
                }
            }
            return string.Empty;
        }

        public static Customer GetCustomerByLicenceNoAndCountryCode(string licenceNo, string countryCode)
        {
            Customer customer = new Customer();
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                String sql = "Select * from CUSTOMERS Where Licence_No = '" + licenceNo + "' AND Country_Code = '" + countryCode + "'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {

                    while (dr.Read())
                    {
                        customer.ID = int.Parse(dr.GetValue(0).ToString());
                        customer.CountryCode = dr.GetValue(1).ToString();
                        customer.LicenceNo = dr.GetValue(2).ToString();
                        customer.Name= dr.GetValue(3).ToString();
                        customer.Address = dr.GetValue(4).ToString();
                        customer.PostCode = dr.GetValue(5).ToString();
                        customer.PhoneNo = dr.GetValue(6).ToString();
                        customer.Email= dr.GetValue(7).ToString();
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return customer;
        }

        public static List<int> GetCustomersIDs()
        {
            List<int> customersIds = new List<int>();
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                
                String sql = "Select Cust_ID from CUSTOMERS";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {

                    while (dr.Read())
                    {
                        customersIds.Add(int.Parse(dr.GetValue(0).ToString()));
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return customersIds;
        }

        public static int GetLastCustomerID()
        {

            int lastCustomerID = 0;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "SELECT MAX(Cust_ID) FROM CUSTOMERS";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        lastCustomerID = int.Parse(dr.GetValue(0).ToString());
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return lastCustomerID;
        }

    }

}
