using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_Tracking_w_Barcode
{
    public partial class Form7 : Form
    {
        Employees emp = new Employees();
        Document document = new Document();
        public Form7()
        {
            InitializeComponent();
        }
        public string ItemSplitting(string itemToSplit)
        {
            var item = itemToSplit;
            string[] items = item.Split('-');
            return items[1];
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            DocumentMethod docMet = new DocumentMethod(null);
            comboBarcode.DataSource= docMet.GetDocumentBarcode();
            // comboBarcode.SelectedIndex = 0;
            comboBarcode.DropDownStyle = ComboBoxStyle.DropDownList;
            RemarkPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void ViewDocumentDetails()
        {
            try
            {
                listOfItems.Rows.Clear();
                DocumentMethod docMet = new DocumentMethod(document);
                foreach (DataRow r in docMet.GetItemsOfBarcode().Rows)
                {
                    listOfItems.Rows.Add(r["EmployeeID"].ToString(),r["FirstName"].ToString() + " "+ r["LastName"].ToString(), r["Subject"].ToString(), r["Remarks"].ToString(), r["DateCreated"].ToString());
                    listOfItems.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void listOfItems_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }

        private void comboBarcode_SelectedValueChanged(object sender, EventArgs e)
        {
          document.BarcodeNo = comboBarcode.SelectedItem.ToString();
            ViewDocumentDetails();
        }

        private void listOfItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listOfItems_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in listOfItems.SelectedRows)
            {
               emp.EmployeeID = row.Cells[0].Value.ToString();
                
            }
            
        }

        private void listOfItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentMethod docMet = new DocumentMethod(document,emp);
            Document docL = docMet.GetRemarksString();
            if(docL.Remarks != "")
            {
                RemarkPanel.Visible = true;
                remarkLabel.Text = docL.Remarks;

                    daysAfterSent.Text = docL.DelayedDocument;
                    BackgroundDays.BackColor = Color.DarkCyan;
                
            }
            else
            {
                MessageBox.Show("N/A");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RemarkPanel.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
