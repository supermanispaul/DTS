using DTS.BL;
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
    public partial class EditForm : Form
    {
        ActionTab actionTabEditForm = null;
        DocumentType documentTypeEditForm = null;
        public EditForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tableDpDwn.SelectedIndex = 0;
            
        }
        public void ViewActionTab()
        {
            try
            {
                gridViewEditTable.Rows.Clear();
                ActionTabMethod actionTable = new ActionTabMethod();
                foreach (DataRow r in actionTable.GetActionTab().Rows)
                {
                    gridViewEditTable.Rows.Add(r["action_tab_ID"].ToString(), r["Action_Tab"].ToString());
                    gridViewEditTable.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ViewDcoumentType()
        {
            try
            {
                gridViewEditTable.Rows.Clear();
                DocumentTypeMethod documentTypeTable = new DocumentTypeMethod();
                foreach (DataRow r in documentTypeTable.GetDocumentType().Rows)
                {
                    gridViewEditTable.Rows.Add(r["DocumentTypeID"].ToString(), r["DocumentType"].ToString());
                    gridViewEditTable.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GridViewEditTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void GridViewEditTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                if(tableDpDwn.Text == "Document Type")
                {
                    GetDocumentTypeID(e);
                }
                else if(tableDpDwn.Text == "Action Tab")
                {
                    GetActionTabID(e);
                }
                

            }

        }

        private void GetDocumentTypeID(DataGridViewCellEventArgs e)
        {
            documentTypeEditForm = new DocumentType();
            documentTypeEditForm.DocumentTypeID = int.Parse(gridViewEditTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            editText.Text = gridViewEditTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void GetActionTabID(DataGridViewCellEventArgs e)
        {
            actionTabEditForm = new ActionTab();
            actionTabEditForm.ActionTabID = int.Parse(gridViewEditTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            editText.Text = gridViewEditTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tableDpDwn.Text == "Action Tab")
            {
                UpdateActionTab();
            }
            else if (tableDpDwn.Text == "Document Type")
            {
                DocumentTypeMethod documentTypeMet = new DocumentTypeMethod(documentTypeEditForm);
                if (String.IsNullOrEmpty(editText.Text) && String.IsNullOrWhiteSpace(editText.Text))
                {
                    MessageBox.Show("No items to be updated!");
                }
                else
                {
                    documentTypeEditForm.DocumentTypeString = editText.Text;
                    if (documentTypeMet.UpdateDocumentType())
                    {
                        MessageBox.Show("Updated!");
                    }
                    ViewDcoumentType();
                    editText.Text = "";
                }
            }
         
        }

        private void UpdateActionTab()
        {
            ActionTabMethod actionTabMet = new ActionTabMethod(actionTabEditForm);
            if (String.IsNullOrEmpty(editText.Text) && String.IsNullOrWhiteSpace(editText.Text))
            {
                MessageBox.Show("No items to be updated!");
            }
            else
            {
                actionTabEditForm.ActionTabString = editText.Text;
                if (actionTabMet.UpdateActionTab())
                {
                    MessageBox.Show("Updated!");
                }
                ViewActionTab();
                editText.Text = "";
            }
        }

        private void TableDpDwn_SelectedValueChanged(object sender, EventArgs e)
        {
            columnName.Text = tableDpDwn.Text;
            if(tableDpDwn.Text == "Action Tab")
            {
                ViewActionTab();
            }
            else if(tableDpDwn.Text == "Document Type")
            {
                ViewDcoumentType();
            }
        }

        private void EditText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //if string1 at string2 ay magkapareho return
            //else add a new    
            ActionTab actionTab = new ActionTab();
            actionTab.ActionTabString = editText.Text;
            ActionTabMethod actionTabMet = new ActionTabMethod(actionTab);
            if(String.Equals(editText.Text, actionTabMet.GetActionTabString(), StringComparison.CurrentCultureIgnoreCase))
            {
                MessageBox.Show("GG");
            }
            else
            {
                actionTabMet.UpdateActionTab();
                ViewActionTab();
            }
        }
    }
}
