using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace CarRentalSYS
{
    class Category
    {
        private String id;
        private double cost;
        private String desc;
        

        public Category():this("","", 0)
        {
        }

        public Category(String id, String desc, double cost)
        {
            setId(id);
            setCost(cost);
            setDesc(desc);
        }

        public String getId()
        {
            return id;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public double getCost()
        {
            return cost;
        }

        public void setCost(double cost)
        {
            this.cost = cost;
        }

        public String getDesc()
        {
            return desc;
        }

        public void setDesc(String desc)
        {
            this.desc = desc;
        }

        public string AddCategory()
        {
            //string errorMessage = string.Empty;
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch

            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {

                String sql = "INSERT INTO CATEGORIES (Cat_Id,Cost,Description) VALUES(:id,:price,:description)";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(":id", this.id);
                cmd.Parameters.Add(":price", this.cost);
                cmd.Parameters.Add(":description", this.desc);
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
                        string errorMessage = "This car class code already exists, please enter a different class code!!" 
                            + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                        conn.Close();
                        return errorMessage;
                    }
                    else
                    {
                        string errorMessage = "The problem with car class data insertion into database!!" 
                            + "\r\n" + "\r\n" + "Details: " + "\r\n" + ex.ToString();
                        conn.Close();
                        return errorMessage;
                    }   
                }
            }
            return string.Empty;
        }
        public static List<string[]> GetCatIdAndDescriptionList()
        {

            List<string[]> catIdAndDescriptionList = new List<string[]>();
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                String sql = "Select CAT_ID, Description  from CATEGORIES";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        string[] catIdAndDescriptionArray = new string[2];
                        catIdAndDescriptionArray[0] = dr.GetValue(0).ToString();
                        catIdAndDescriptionArray[1] = dr.GetValue(1).ToString();
                        catIdAndDescriptionList.Add(catIdAndDescriptionArray);
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return catIdAndDescriptionList;
        }

        public static double GetCostPerDayByCatId(string catId)
        {

            double catCostPerDay = 0;
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                String sql = "Select COST from CATEGORIES Where CAT_ID = '" + catId + "'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        catCostPerDay = Double.Parse(dr.GetValue(0).ToString());
                    }
                }
                finally
                {
                    dr.Close();
                }
            }
            return catCostPerDay;
        }




    }
}
