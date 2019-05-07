using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Tracking_w_Barcode
{
    public class Login : Connection
    {
        
        public string FullName { get; set; }
        public bool Logged { get; set; }
        public string LoginID { get; set; }
        private MySqlCommand com;
        
        public List<string> GetUserType()
        {
            List<string> users = new List<string>(); 
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = "Select * from usertype;";
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                users.Add((string)dataReader[1]);
            }
            base.GetConnection().Close();
             
            return users;
        }
        public bool LoggedIn(Employees employees)
        {
             base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"Select * from employee INNER JOIN usertype ON employee.UserTypeID = usertype.UserTypeID WHERE BINARY employee.UserName = '{employees.Username}' AND  employee.Password = '{employees.Password}' AND usertype.UserType = '{employees.UserType}';";
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                LoginID = dataReader.GetString(0);
                FullName = $"{dataReader.GetString(1)} {dataReader.GetString(2)}";
                Logged = true;
            }
            base.GetConnection().Close();
            return Logged;
        }

    }
}
