using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Tracking_w_Barcode
{
    public class Signup : Connection

    {
        private MySqlCommand com;
        private bool Signed;

        public List<string> GetUserType()
        {
            List<string> userType =new List<string>(); 
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = "Select UserType from usertype;";
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                userType.Add(dataReader[0].ToString());
            }
            base.GetConnection().Close();
            return userType;
        }
        public List<string> GetOfficeDivision()
        {
            List<string> userType = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = "Select OfficeAndDivision from officeanddivision;";
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                userType.Add(dataReader[0].ToString());
            }
            base.GetConnection().Close();
            return userType;
        }
        public int InsertEmployee(Employees employees)
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = "INSERT INTO employee(EmployeeID,FirstName,LastName,UserName,Password,Cellphone,Email,UserTypeID,OfficeAndDivisionID) VALUES(@a,@b,@c,@d,@e,@f,@g,@h,@i)";
            com.Parameters.AddWithValue("@a", employees.EmployeeID);
            com.Parameters.AddWithValue("@b", employees.FirstName);
            com.Parameters.AddWithValue("@c", employees.LastName);
            com.Parameters.AddWithValue("@d", employees.Username);
            com.Parameters.AddWithValue("@e", employees.Password);
            com.Parameters.AddWithValue("@f", employees.CellphoneNo);
            com.Parameters.AddWithValue("@g", employees.Email);
            com.Parameters.AddWithValue("@h", employees.UserTypeID);
            com.Parameters.AddWithValue("@i", employees.OfficeAndDivisionID);
            int a = com.ExecuteNonQuery();
            base.GetConnection().Close();
            return a;
        }

       public bool AlreadySignedUp(string employeeID)
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = "Select employeeID from employee;";
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                if ((string)dataReader[0] == employeeID)
                {
                    Signed = true;
                }
                else
                {
                    Signed = false;
                }
            }
            base.GetConnection().Close();
            return Signed;
        }
    }
}
