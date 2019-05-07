using DTS.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Tracking_w_Barcode
{
    public class DocumentMethod : Connection
    {
        MySqlCommand com;
        MySqlDataAdapter adapter;
        DataTable dt;
        Employees employees = new Employees();
        Document document = new Document();
        OfficeAndDivision officeAndDivision = new OfficeAndDivision();
        public DocumentMethod(Document doc) : this(doc,null)
        {
            document = doc;
        }
        public DocumentMethod(Document doc, Employees emp)
        {
            document = doc;
            employees = emp;
           
        }
        public DocumentMethod(Document doc, Employees emp,OfficeAndDivision officeAndDivision)
        {
            document = doc;
            employees = emp;
            this.officeAndDivision = officeAndDivision;
        }

        public List<string> GetDocumentBarcode()
        {
            List<string> documentBarcode = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT documentBarcode from document";
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                documentBarcode.Add(dr[0].ToString());
            }
            base.GetConnection().Close();
            return documentBarcode;  
        }
        public string GetDocumentCount()
        {
            string documentBarcode = "";
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT COUNT(documentBarcode) from document";
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                documentBarcode = dr[0].ToString();
            }
            base.GetConnection().Close();
            return documentBarcode;
        }
 
        public DataTable GetItemsOfBarcode()
        {
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT document.documentBarcode,document.DateCreated,document.DateReceived,document.FromWho,document.MeanOfDelivery,document.Subject,document.DocumentLocation,primary_document.PrimaryDocument,document_type.DocumentType,remarks.Remarks,employee.employeeID,employee.FirstName,employee.LastName,pending_document.DaysDelayed from document INNER JOIN primary_document ON document.PrimaryDocID = primary_document.PrimaryDocumentID INNER JOIN document_type ON document.DocumentTypeID = document_type.DocumentTypeID INNER JOIN pending_document ON pending_document.documentBarcode = document.documentBarcode INNER JOIN employee ON pending_document.EmployeeID = employee.EmployeeID INNER JOIN remarks ON pending_document.RemarkID = remarks.RemarkID WHERE pending_document.documentBarcode = '{document.BarcodeNo}'";


            adapter = new MySqlDataAdapter(com);
            dt = new DataTable();
            adapter.Fill(dt);
            base.GetConnection().Close();
            return dt;
        }
        public Document GetDocument()
        {
            Document _document = new Document();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT documentBarcode,DateCreated,DateReceived,FromWho,MeanOfDelivery,Subject,DocumentLocation,UploadedFile FROM document WHERE documentBarcode = '{document.BarcodeNo}'";
            MySqlDataReader dr = com.ExecuteReader();
            
            DateTime dR;
            DateTime dC;
            while (dr.Read())
            {
                _document.BarcodeNo = dr[0].ToString();
                dC = Convert.ToDateTime(dr[1].ToString());
                dR = Convert.ToDateTime(dr[2].ToString());
                _document.DateReceived = dR;
                _document.DateCreated = dC;
                _document.EmployeeFrom = dr[3].ToString();
                _document.Transportation = dr[4].ToString();
                _document.Subject = dr[5].ToString();
                _document.DocumentLocation = dr[6].ToString();
                _document.UploadedFile = dr[7].ToString();
            }
            base.GetConnection().Close();
            return _document;
        }

          public Document GetRemarksString()
        {
            Document doc = new Document();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT remarks.remarks,pending_document.DaysDelayed from remarks INNER JOIN pending_document ON remarks.RemarkID = pending_document.RemarkID WHERE pending_document.documentBarcode = '{document.BarcodeNo}' AND pending_document.employeeID = '{employees.EmployeeID}';";
            MySqlDataReader dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                doc.Remarks = dr[0].ToString();
                doc.DelayedDocument = dr[1].ToString();
                
            }
            base.GetConnection().Close();
            return doc;
        }

        public bool UpdateDelayedDocs(){
            bool updated = false;
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $@" UPDATE pending_document SET DaysDelayed = '{document.DelayedDocument}' WHERE EmployeeID = {employees.EmployeeID}; ";   
            com.ExecuteNonQuery();
            updated = true;
            base.GetConnection().Close();
            return updated;
        }


        public Document RemarksFrom()
        {
            Document doc = new Document();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT remarks.remarks,employee.FirstName, employee.LastName FROM pending_document INNER JOIN employee ON employee.employeeID = pending_document.EmployeeID  INNER JOIN remarks ON pending_document.remarkID = remarks.remarkID WHERE pending_document.documentBarcode = '{document.BarcodeNo}'";
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                doc.Remarks = dr[0].ToString();
                doc.EmployeeFrom = $"{dr[1].ToString()} {dr[2].ToString()}";
            }
            base.GetConnection().Close();
            return doc;

        }

        public List<string> SearchEmails()
        {
            List<string> emails = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT email FROM employee WHERE UserTypeID = 2 AND OfficeAndDivisionID = {officeAndDivision.OfficeAndDivisionID} ;";
            
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                emails.Add(dr[0].ToString());
            }
            base.GetConnection().Close();
            return emails;
        }

     
       
        public List<string> GetPendingDoc()
        {
            List<string> doc = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT DISTINCT document.documentBarcode,employee.FirstName,employee.LastName,document.DateCreated FROM document INNER JOIN pending_document ON document.documentBarcode = pending_document.documentBarcode INNER JOIN employee ON pending_document.EmployeeID = employee.EmployeeID WHERE pending_document.employeeID = '{employees.EmployeeID}' AND pending_document.Status = '0';";

            MySqlDataReader dr = com.ExecuteReader();
            DateTime dt;
            while (dr.Read())
            {
                dt = Convert.ToDateTime(dr[3]);
                
                doc.Add($"{dr[0].ToString()}--{dr[1].ToString()} {dr[2].ToString()}--{dt.ToShortDateString()}");
            }
            base.GetConnection().Close();


            return doc;

        }
        public int GetLastRemarkID()
        {
            int remarkID = 0;
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT remarkID FROM remarks Order by remarkID DESC LIMIT 1";

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                remarkID =int.Parse(dr[0].ToString());
            }
            base.GetConnection().Close();
            return remarkID;
        }
        public List<string> ListEmployeeID()
        {

            List<string> employeeID = new List<string>();
            base.GetConnection().Open();
            foreach (var email in document.SendTo)
            {

                com = base.GetConnection().CreateCommand();
                com.CommandText = $"SELECT EmployeeID FROM employee WHERE Email = '{email}';";

                using (MySqlDataReader dr = com.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        employeeID.Add(dr[0].ToString());
                    }
                }

                    
              
            }
            base.GetConnection().Close();
            return employeeID;
        }
        public bool InsertPendingDocument()
        {
            bool inserted = false;

            
            try
            {
                int remarkIDs = document.LastRemarkID;
                base.GetConnection().Open();
                foreach (var employeeID in employees.ListEmployeeID)
                    {
                        remarkIDs += 1;
                        com = base.GetConnection().CreateCommand();
                        com.CommandText = @"BEGIN; INSERT INTO pending_document(documentBarcode,EmployeeID,Status,RemarkID) VALUES(@a,@b,@c,@d);INSERT INTO remarks(Remarks) VALUES(@e); COMMIT;";
                        com.Parameters.AddWithValue("@a", document.BarcodeNo);
                        com.Parameters.AddWithValue("@b", employeeID);
                        com.Parameters.AddWithValue("@c", 0);
                        com.Parameters.AddWithValue("@d", remarkIDs);
                        com.Parameters.AddWithValue("@e", null);
                        com.ExecuteNonQuery();
                }
               
                inserted = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            base.GetConnection().Close();
            return inserted;
        }

        public bool InsertDocument()
        {
            bool inserted = false;
            base.GetConnection().Open();
                    com = base.GetConnection().CreateCommand();
                    com.CommandText = @" BEGIN;INSERT INTO pending_document(documentBarcode,EmployeeID,Status,RemarkID) VALUES(@k,@l,@m,@n); INSERT INTO document(documentBarcode,DateCreated,DateReceived,DeadlineDate,FromWho,MeanOfDelivery,Subject,DocumentLocation,UploadedFile,tags,PrimaryDocID,DocumentTypeID) VALUES(@a,@b,@c,@deadlineDate,@d,@e,@f,@g,@h,@tags,@i,@j);INSERT INTO remarks(Remarks) VALUES(@o); COMMIT;";
                    com.Parameters.AddWithValue("@k", document.BarcodeNo);
                    com.Parameters.AddWithValue("@l", employees.EmployeeID);
                    com.Parameters.AddWithValue("@m", 0);
                    com.Parameters.AddWithValue("@n", document.RemarkID);
                    com.Parameters.AddWithValue("@deadlineDate", document.DeadlineDate);
                    com.Parameters.AddWithValue("@a", document.BarcodeNo);
                    com.Parameters.AddWithValue("@b", document.DateCreated);
                    com.Parameters.AddWithValue("@c", document.DateReceived);
                    com.Parameters.AddWithValue("@d", document.EmployeeFrom);
                    com.Parameters.AddWithValue("@e", document.Transportation);
                    com.Parameters.AddWithValue("@f", document.Subject);
                    com.Parameters.AddWithValue("@g", document.DocumentLocation);
                    com.Parameters.AddWithValue("@h", document.UploadedFile);
                    com.Parameters.AddWithValue("@tags", document.Tags);
                    com.Parameters.AddWithValue("@i", document.PrimaryDoc);
                    com.Parameters.AddWithValue("@j", document.DocType);
                    com.Parameters.AddWithValue("@o", document.Remarks);
            com.ExecuteNonQuery();
                inserted = true;
            base.GetConnection().Close();
            return inserted;
        }


    







        public List<string> GetEmployeeByEmail ()
        {
            List<string> getEmployee = new List<string>();
            base.GetConnection().Open();
                foreach (var email in document.SendTo)
                {
                    
                    com = base.GetConnection().CreateCommand();
                    com.CommandText = $"SELECT EmployeeID FROM employee WHERE Email = '{email}';";

             using(MySqlDataReader  dr = com.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        getEmployee.Add(dr[0].ToString());
                    }
                }
                }
            
           
            base.GetConnection().Close();
            return getEmployee;
          
        }
        
   
        public int GetPrimaryDocID()
        {
            int a = 0;
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT PrimaryDocumentID FROM primary_document WHERE PrimaryDocument = '{document.PrimaryDocument}';";

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                a = int.Parse(dr[0].ToString());
            }
            base.GetConnection().Close();
            return a;
        }
        public int GetDocTypeID()
        {
            int a = 0;
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT DocumentTypeID FROM document_type WHERE DocumentType = '{document.DocType}';";

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                a = int.Parse(dr[0].ToString());
            }
            base.GetConnection().Close();
            return a;
        }
        public List<string> GetPrimaryDoc()
        {

            List<string> priDoc = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT PrimaryDocument FROM primary_document;";

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                priDoc.Add(dr[0].ToString());
            }
            base.GetConnection().Close();
            return priDoc;  

        }
        public List<string> GetDocumentType()
        {

            List<string> docType = new List<string>();
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT DocumentType FROM document_type;";

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                docType.Add(dr[0].ToString());
            }
            base.GetConnection().Close();
            return docType;

        }
    
        public int GetRemarkIDOfEmp()
        {
            int remarkID = 0;
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $"SELECT RemarkID FROM pending_document WHERE EmployeeID = '{employees.EmployeeID}' AND documentBarcode = '{document.BarcodeNo}';";

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                remarkID = int.Parse(dr[0].ToString());
            }
            base.GetConnection().Close();
            return remarkID;
        }
        public bool UpdateDaysDelayed()
        {
            bool updated = false;
            base.GetConnection().Open();
            com = base.GetConnection().CreateCommand();
            com.CommandText = $@" UPDATE pending_document SET DaysDelayed = '{document.DelayedDocument}' WHERE employeeID = '{employees.EmployeeID}' AND documentBarcode = '{document.BarcodeNo}'; ";
            com.ExecuteNonQuery();
            updated = true;
            base.GetConnection().Close();
            return updated;
        }
        public bool UpdateRemarks()
        {
            bool updated = false;
            try
            {
                base.GetConnection().Open();
                com = base.GetConnection().CreateCommand();
                com.CommandText = $@" UPDATE remarks,pending_document SET remarks.Remarks = '{document.Remarks}',pending_document.status = 1 WHERE remarks.RemarkID = {document.RemarkID} AND pending_document.RemarkID = {document.RemarkID} AND pending_document.EmployeeID = '{employees.EmployeeID}';";
                com.ExecuteNonQuery();
                updated = true;
            }
            catch (Exception ex)
            {
                updated = false;
            }
           
            
            base.GetConnection().Close();
            return updated;
        }

   
    
    }
}
