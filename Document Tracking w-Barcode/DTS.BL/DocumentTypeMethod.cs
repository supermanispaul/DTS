using Document_Tracking_w_Barcode;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DTS.BL
{
    public class DocumentTypeMethod : Connection

    {
        MySqlCommand com;
        MySqlDataAdapter adapter;
        DataTable dt;
        DocumentType documentType = null;
        
        public DocumentTypeMethod()
        {

        }
        public DocumentTypeMethod(DocumentType documentType)
        {
            this.documentType = documentType;
        }
        public DataTable GetDocumentType()
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT * from document_type";
            adapter = new MySqlDataAdapter(com);
            dt = new DataTable();
            adapter.Fill(dt);
            base.GetConnection().Close();
            return dt;
        }
        public bool UpdateDocumentType()
        {
            bool success = false;
            base.GetConnection().Open();
            try
            {
                com = base.GetConnection().CreateCommand();
                com.CommandText = $"UPDATE document_type SET DocumentType = '{documentType.DocumentTypeString}' WHERE DocumentTypeID = {documentType.DocumentTypeID};";
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
