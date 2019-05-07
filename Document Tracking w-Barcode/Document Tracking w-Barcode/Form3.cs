using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_Tracking_w_Barcode
{
    public partial class Form3 : Form
    {
        Employees employeeForm3;
        Employees employeeInList = new Employees();
        Document documentForm3 = new Document();
        List<Label> listOfLabel =new List<Label>();
        //private string _itemID;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Login emp)
        {
            InitializeComponent();
            EmployeeMethod empMet = new EmployeeMethod(null,emp);
            employeeForm3 = empMet.GetEmployee();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisposeLabel();
            ShowDetails();
        }
        private void DisposeLabel()
        {
            foreach(var labels in listOfLabel)
            {
                labels.Dispose();
            }
            panel4.Controls.Clear();

        }
        void ShowDetails()
        {
            if (pendingDocList.SelectedItem != null)
            {
                documentForm3.BarcodeNo = ItemSplitting(pendingDocList.SelectedItem.ToString());
                DocumentMethod docMet = new DocumentMethod(documentForm3);
                Document doc = docMet.GetDocument();
                var path = Path.GetFullPath($"{doc.DocumentLocation}");
                //if path doesn't find the image
               
                
                barcodeLabel.Text = GetBarcode(doc.BarcodeNo);
                subjectLabel.Text = GetSubject(doc.Subject);
                fromLabel.Text = GetFrom(doc.EmployeeFrom);
                receivedLabel.Text = GetDateReceived(doc.DateReceived.ToShortDateString());
                ShowAttachedFiles(doc.UploadedFile,doc.DocumentLocation,"main");
                ShowAttachedFiles(doc.UploadedFile, doc.DocumentLocation,"notmain");
                label7.Visible = true;
            }
            else
            {
                NoSelectedItem();
            }
        }

        private void NoSelectedItem()
        {
            barcodeLabel.Text = "";
            subjectLabel.Text = "";
            receivedLabel.Text = "";
            fromLabel.Text = "";
            label7.Visible = false;
        }

        private void ShowAttachedFiles(string filesUploaded,string scannedDocumentString, string position)
        {
            Label label = null ;
            Label scannedDocument = null;
            scannedDocument = new Label();
            scannedDocument.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scannedDocument.AutoSize = true;
            scannedDocument.Location = new System.Drawing.Point(0, 45);
            scannedDocument.Name = scannedDocumentString;
            scannedDocument.Size = new System.Drawing.Size(81, 18);
            scannedDocument.TabIndex = 0;
            scannedDocument.Text = $"{Path.GetFileName(scannedDocumentString)} (SCANNED DOCUMENT)";
            scannedDocument.Click += GetLabelName_Click;
            scannedDocument.MouseHover += CursorHoverLabel;
            scannedDocument.MouseLeave += CursorLeaveLabel;
            panel4.Controls.Add(scannedDocument);
            string[] fileSplitted = filesUploaded.Split(',');
            int y = 80;
            if(position == "main")
            {
                foreach (string file in fileSplitted)
                {
                    label = new Label();
                    label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(0, y);
                    label.Name = file;
                    label.Size = new System.Drawing.Size(81, 18);
                    label.TabIndex = 0;
                    label.Text = Path.GetFileName(file);
                    label.Click += GetLabelName_Click;
                    label.MouseHover += CursorHoverLabel;
                    label.MouseLeave += CursorLeaveLabel;
                    panel4.Controls.Add(label9);
                    panel4.Controls.Add(label);
                    listOfLabel.Add(label);
                    y += 80;
                }
            }
            else
            {
                foreach (string file in fileSplitted)
                {
                    label = new Label();
                    label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(0, y);
                    label.Name = file;
                    label.Size = new System.Drawing.Size(81, 18);
                    label.TabIndex = 0;
                    label.Text = Path.GetFileName(file);
                    label.Click += GetLabelName_Click;
                    label.MouseHover += CursorHoverLabel;
                    label.MouseLeave += CursorLeaveLabel;
                    panel5.Controls.Add(label11);
                    panel5.Controls.Add(label10);
                    panel5.Controls.Add(label);
                    listOfLabel.Add(label);
                    y += 45;
                }
            }
           
        }

        private void CursorLeaveLabel(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void CursorHoverLabel(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void GetLabelName_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            Process.Start(clickedLabel.Name);
        }
        public string ItemSplitting(string itemToSplit)
        {
            var item = itemToSplit;
            string[] items = item.Split('-');
            return items[0];
        }

        

        private void SelectDocument()
        {
            if (pendingDocList.SelectedItem != null)
            {
                documentForm3.BarcodeNo = ItemSplitting(pendingDocList.SelectedItem.ToString());

                RemarkPanel.Visible = true;
                DocumentMethod docMet = new DocumentMethod(documentForm3);

                Document doc = docMet.GetDocument();
                Log log = new Log(documentForm3, employeeForm3);
                log.InsertLog();
                try
                {
                    var path = Path.GetFullPath($"{doc.DocumentLocation}");
                    Bitmap documentImage = new Bitmap(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Image has been deleted!");
                }
               
            }
        }

        private void UpdateList()
        {
            DocumentMethod docMet = new DocumentMethod(null,employeeForm3);
            pendingDocList.DataSource = docMet.GetPendingDoc();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            UpdateList();
            HideThePopUp();
            ViewEmployeeList();
            remarksPop.Visible = false;
            panel4.HorizontalScroll.Enabled = true;
            panel4.AutoScroll = true;
        }

        private void HideThePopUp()
        {
            if (pendingDocList.SelectedItem == null)
            {
                label7.Visible = false;
            }
        }

        public void ViewEmployeeList()
        {
            try
            {
                EmployeeList.Rows.Clear();
                EmployeeMethod employeeMet = new EmployeeMethod(employeeForm3);
                foreach (DataRow r in employeeMet.GetEmployees().Rows)
                {
                    EmployeeList.Rows.Add(r["EmployeeID"].ToString(), r["FirstName"].ToString() + " " + r["LastName"].ToString());
                    EmployeeList.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClosePopUp();
        }

        private void ClosePopUp()
        {
            RemarkPanel.Visible = false;
            
            EmployeeList.DataSource = null;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm3();
        }

        private void CloseForm3()
        {
            this.Dispose();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private string GetFrom(string from)
        {
            return $"From: {from}";
        }
        private string GetDateReceived(string dateReceived)
        {
            return $"Received: {dateReceived}";
        }
        private string GetBarcode(string barcode)
        {
            return $"Reference No. {barcode}";
        }
        private string GetSubject(string subject)
        {
            return $"Subject: {subject}";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            Log log = new Log(documentForm3);
            documentForm3.DelayedDocument = log.DocumentOpened();
            DocumentMethod docmet2 = new DocumentMethod(documentForm3, employeeForm3);
            documentForm3.RemarkID = docmet2.GetRemarkIDOfEmp();
            documentForm3.Remarks = RemarksUpdate.Text;
            DocumentMethod docmet = new DocumentMethod(documentForm3, employeeForm3);

            if (docmet.UpdateRemarks() && docmet.UpdateDaysDelayed())
            {
                MessageBox.Show("Remarks has been saved!");
                RemarkPanel.Visible = false;
                 
                    UpdateList();
                    ShowDetails();
                DisposeLabel();
                NoSelectedItem();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void EmployeeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentMethod docMet = new DocumentMethod(documentForm3, employeeForm3);
            Document docL = docMet.GetRemarksString();
            if (docL.Remarks != "")
            {
                remarksPop.Visible = true;
                remarkLabel.Text = docL.Remarks;

                daysAfterSent.Text = docL.DelayedDocument;
                BackgroundDays.BackColor = Color.DarkCyan;

            }
            else
            {
                MessageBox.Show("N/A");

            }
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeList_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in EmployeeList.SelectedRows)
            {
                employeeInList.EmployeeID = row.Cells[0].Value.ToString();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            remarksPop.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SelectDocument();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   

        private void Label10_Click_2(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void PendingDocList_DoubleClick(object sender, EventArgs e)
        {
            RemarkPanel.Visible = true;
        }

        private void EmployeeList_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
