using Document_Tracking_w_Barcode;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DTS.BL
{
    public class ActionTabMethod : Connection
    {
        MySqlCommand com;
        MySqlDataAdapter adapter;
        DataTable dt;
        ActionTab actionTab = null;
        public ActionTabMethod()
        {

        }
        
        public ActionTabMethod(ActionTab actionTab) 
        {
            this.actionTab = actionTab;
        }
        public List<string> GetAllAction()
        {
            List<string> actionTab = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT Action_Tab FROM action_tab;";
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                actionTab.Add(dr[0].ToString());
            }
            base.GetConnection().Close();
            return actionTab;
        }
        public string GetActionTabString()
        {
            string actionTabString = "";
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT Action_Tab from action_tab WHERE Action_Tab = '{actionTab.ActionTabString}'";
            
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                actionTabString = dr[0].ToString();
            }
            base.GetConnection().Close();

            return actionTabString;
        }
        public DataTable GetActionTab()
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT * from action_tab";
            adapter = new MySqlDataAdapter(com);
            dt = new DataTable();
            adapter.Fill(dt);
            base.GetConnection().Close();
            return dt;
        }
        public bool InsertActionTab()
        {
            bool inserted = false;
            base.GetConnection().Open();
            try
            {
                com = base.GetConnection().CreateCommand();
                com.CommandText = @"INSERT INTO action_tab(Action_Tab) VALUES(@actionTab);";
                com.Parameters.AddWithValue("@actionTab", actionTab.ActionTabString);
                com.ExecuteNonQuery();
                inserted = true;
            }
            catch (Exception)
            {
                inserted = false;
            }
          
           
            base.GetConnection().Close();
            return inserted;
        }
        public bool UpdateActionTab()
        {
            bool success = false;
            base.GetConnection().Open();
            try
            {
                com = base.GetConnection().CreateCommand();
                com.CommandText = $"UPDATE action_tab SET Action_Tab = '{actionTab.ActionTabString}' WHERE action_tab_ID = {actionTab.ActionTabID};";
                success = true;
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                success = false;
            }
            base.GetConnection().Close();
            return success;
        }
    }
}
