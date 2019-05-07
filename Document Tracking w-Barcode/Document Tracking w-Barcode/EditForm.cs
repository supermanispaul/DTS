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

        private void GridViewEditTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void GridViewEditTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                actionTabEditForm = new ActionTab();
                actionTabEditForm.ActionTabID = int.Parse(gridViewEditTable.Rows[e.RowIndex].Cells[0].Value.ToString());

                editText.Text = gridViewEditTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActionTabMethod actionTabMet = new ActionTabMethod(actionTabEditForm);
            actionTabEditForm.ActionTabString = editText.Text;
            if (actionTabMet.UpdateActionTab())
            {
                MessageBox.Show("Updated!");
            }
            ViewActionTab();
            editText.Text = "";
        }

        private void TableDpDwn_SelectedValueChanged(object sender, EventArgs e)
        {
            columnName.Text = tableDpDwn.Text;
            if(tableDpDwn.Text == "Action Tab")
            {
                ViewActionTab();
            }
        }

        private void EditText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
