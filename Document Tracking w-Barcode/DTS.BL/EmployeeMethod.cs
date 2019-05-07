using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Tracking_w_Barcode
{
   public class EmployeeMethod :Connection
    {
        MySqlCommand com;
        MySqlDataAdapter adapter;
        DataTable dt;
        Employees emp = new Employees();
        Login login = new Login();
        public EmployeeMethod(Employees employees)
        {
            emp = employees;
        }
        public EmployeeMethod(Employees employees,Login login)
        {
            emp = employees;
            this.login = login;
        }
        public List<string> GetAllEmployees()
        {
            List<string> employeeList = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT EmployeeID,FirstName,LastName FROM employee";
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                employeeList.Add($"{dr[1]} {dr[2]}");
            }
            base.GetConnection().Close();
            return employeeList;
        }

        public DataTable GetLog()
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT EmployeeID,FirstName,LastName FROM employee";
            adapter = new MySqlDataAdapter(com);
            dt = new DataTable();
            adapter.Fill(dt);
            base.GetConnection().Close();
            return dt;
        }

        public DataTable GetEmployees()
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT EmployeeID,FirstName,LastName from employee WHERE EmployeeID  NOT IN('{emp.EmployeeID}')";

            adapter = new MySqlDataAdapter(com);
            dt = new DataTable();
            adapter.Fill(dt);
            base.GetConnection().Close();
            return dt;
        }

        public Employees GetEmployee()
        {
            Employees emp = new Employees();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT employee.EmployeeID, employee.FirstName,employee.LastName,employee.Cellphone,employee.Email,usertype.UserType FROM employee INNER JOIN usertype ON employee.UserTypeID = usertype.UserTypeID WHERE employee.EmployeeID = '{login.LoginID}'";
            MySqlDataReader dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                emp.EmployeeID = dr[0].ToString();
                emp.FirstName = dr[1].ToString();
                emp.LastName = dr[2].ToString();
                emp.CellphoneNo = dr[3].ToString();
                emp.Email = dr[4].ToString();
                emp.UserType = dr[5].ToString();

            }
            base.GetConnection().Close();
            return emp;
        }
    }
}
