using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Tracking_w_Barcode
{
   public class Log : Connection
    {
        Document doc = new Document();
        Employees emp = new Employees();
        

        MySqlCommand com;
        // MySqlDataAdapter adapter;
        //DataTable dt;
        public Log(Document doc)
        {
            this.doc = doc;
        }
        public Log(Document doc, Employees emp)
        {
            this.doc = doc;
            this.emp = emp;
        }

        public string DocumentOpened()
        {
            string result = "";
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $" SELECT DateCreated from document WHERE documentBarcode = '{doc.BarcodeNo}';";
            MySqlDataReader dr = com.ExecuteReader();
            DateTime dC;
            while (dr.Read())
            {
                dC =Convert.ToDateTime( dr[0]);
                int days = (int)(DateTime.Now - dC).TotalDays;
                result = $"{days.ToString()} days after it was sent,document was remarked.";
            }
            base.GetConnection().Close();

            return result;
        }



        private string GetDocumentOpened()
        {
           return $"Mr./Mrs./Ms. {emp.FullName} has opened the DOCUMENT : { doc.BarcodeNo} at {DateTime.Now}";
        }
  /*      public DataTable GetLog()
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = "SELECT * FROM log";
            adapter = new MySqlDataAdapter(com);
            dt = new DataTable();
            adapter.Fill(dt);
            base.GetConnection().Close();
            return dt;
        }
*/

        private string DocumentRemarked { get; set; }
        public List<string> GetLogs()
        {
            List<string> remarks = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = @"SELECT logs from log;";
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                remarks.Add(dr[0].ToString());
            }
            base.GetConnection().Close();
            return remarks;
        }
        public void InsertLog()
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = @"INSERT INTO log(logs) VALUES (@a);";
            com.Parameters.AddWithValue("@a", GetDocumentOpened());
            com.ExecuteNonQuery();
            base.GetConnection().Close();
        }

    }
}