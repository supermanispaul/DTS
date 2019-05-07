using Document_Tracking_w_Barcode;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTS.BL
{
    public class OfficeAndDivisionMethod : Connection
    {
        OfficeAndDivision officeAndDivision = new OfficeAndDivision();
        MySqlCommand com;
        
        public OfficeAndDivisionMethod(OfficeAndDivision officeAndDivision)
        {
            this.officeAndDivision = officeAndDivision;
        }
        public OfficeAndDivisionMethod()
        {
        }

        public List<string> GetAllOfficeAndDivision()
        {
            List<string> officeAndDivisionList = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT OfficeAndDivision FROM officeanddivision;";
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                officeAndDivisionList.Add(dr[0].ToString());
            }
            base.GetConnection().Close();
            return officeAndDivisionList;
        }
        public int GetOfficeAndDivisionID()
        {
            int officeDivisionID = 0;
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT OfficeAndDivisionID FROM officeanddivision WHERE OfficeAndDivision = '{officeAndDivision.OfficesAndDivisions}';";
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                officeDivisionID  = int.Parse(dr[0].ToString());
            }
            base.GetConnection().Close();
            return officeDivisionID;
        }

    }
}
