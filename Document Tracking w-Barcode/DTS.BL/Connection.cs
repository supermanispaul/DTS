using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Tracking_w_Barcode
{
    public partial class Connection
    {
        private String connString;
        private MySqlConnection con;
        public Connection()
        {
            connString = "Server = localhost; Database = dts; Uid = root; pwd = '';";
            con = new MySqlConnection(connString);
        }
        public MySqlConnection GetConnection()
        {
            return con;
        }
       
    }
}
