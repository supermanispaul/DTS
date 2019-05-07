namespace Document_Tracking_w_Barcode
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewEditTable = new System.Windows.Forms.DataGridView();
            this.ActionTabID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDpDwn = new System.Windows.Forms.ComboBox();
            this.columnName = new System.Windows.Forms.Label();
            this.editText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEditTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewEditTable
            // 
            this.gridViewEditTable.AllowUserToAddRows = false;
            this.gridViewEditTable.AllowUserToDeleteRows = false;
            this.gridViewEditTable.AllowUserToOrderColumns = true;
            this.gridViewEditTable.AllowUserToResizeRows = false;
            this.gridViewEditTable.BackgroundColor = System.Drawing.Color.White;
            this.gridViewEditTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewEditTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridViewEditTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewEditTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridViewEditTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewEditTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionTabID,
            this.ActionTab});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewEditTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridViewEditTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewEditTable.GridColor = System.Drawing.Color.White;
            this.gridViewEditTable.Location = new System.Drawing.Point(12, 119);
            this.gridViewEditTable.Name = "gridViewEditTable";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewEditTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridViewEditTable.Size = new System.Drawing.Size(846, 267);
            this.gridViewEditTable.TabIndex = 0;
            this.gridViewEditTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewEditTable_CellClick);
            this.gridViewEditTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewEditTable_CellValueChanged);
            // 
            // ActionTabID
            // 
            this.ActionTabID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActionTabID.HeaderText = "ActionTabID";
            this.ActionTabID.Name = "ActionTabID";
            // 
            // ActionTab
            // 
            this.ActionTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActionTab.HeaderText = "Action Tab";
            this.ActionTab.Name = "ActionTab";
            // 
            // tableDpDwn
            // 
            this.tableDpDwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableDpDwn.FormattingEnabled = true;
            this.tableDpDwn.Items.AddRange(new object[] {
            "Action Tab",
            "Primary Document",
            "Document Type"});
            this.tableDpDwn.Location = new System.Drawing.Point(149, 40);
            this.tableDpDwn.Name = "tableDpDwn";
            this.tableDpDwn.Size = new System.Drawing.Size(532, 32);
            this.tableDpDwn.TabIndex = 3;
            this.tableDpDwn.SelectedValueChanged += new System.EventHandler(this.TableDpDwn_SelectedValueChanged);
            // 
            // columnName
            // 
            this.columnName.AutoSize = true;
            this.columnName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnName.Location = new System.Drawing.Point(10, 412);
            this.columnName.Name = "columnName";
            this.columnName.Size = new System.Drawing.Size(57, 21);
            this.columnName.TabIndex = 4;
            this.columnName.Text = "label1";
            // 
            // editText
            // 
            this.editText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editText.Location = new System.Drawing.Point(291, 407);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(567, 29);
            this.editText.TabIndex = 5;
            this.editText.TextChanged += new System.EventHandler(this.EditText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Column to edit:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editText);
            this.Controls.Add(this.columnName);
            this.Controls.Add(this.tableDpDwn);
            this.Controls.Add(this.gridViewEditTable);
            this.Name = "EditForm";
            this.Text = "form";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEditTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewEditTable;
        private System.Windows.Forms.ComboBox tableDpDwn;
        private System.Windows.Forms.Label columnName;
        private System.Windows.Forms.TextBox editText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionTabID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionTab;
    }
}