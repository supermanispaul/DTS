namespace Document_Tracking_w_Barcode
{
    partial class Form7
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
            this.listOfItems = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBarcode = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.daysAfterSent = new System.Windows.Forms.Label();
            this.RemarkPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BackgroundDays = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listOfItems)).BeginInit();
            this.RemarkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfItems
            // 
            this.listOfItems.AllowUserToAddRows = false;
            this.listOfItems.AllowUserToDeleteRows = false;
            this.listOfItems.AllowUserToResizeColumns = false;
            this.listOfItems.BackgroundColor = System.Drawing.Color.White;
            this.listOfItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.Employee,
            this.Subject,
            this.Remarks,
            this.DateOfRemark});
            this.listOfItems.Location = new System.Drawing.Point(121, 148);
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.ReadOnly = true;
            this.listOfItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfItems.Size = new System.Drawing.Size(767, 465);
            this.listOfItems.TabIndex = 9;
            this.listOfItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfItems_CellContentClick);
            this.listOfItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfItems_CellDoubleClick);
            this.listOfItems.SelectionChanged += new System.EventHandler(this.listOfItems_SelectionChanged);
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // Employee
            // 
            this.Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // DateOfRemark
            // 
            this.DateOfRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfRemark.HeaderText = "Date Given";
            this.DateOfRemark.Name = "DateOfRemark";
            this.DateOfRemark.ReadOnly = true;
            // 
            // comboBarcode
            // 
            this.comboBarcode.BackColor = System.Drawing.Color.White;
            this.comboBarcode.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBarcode.FormattingEnabled = true;
            this.comboBarcode.Items.AddRange(new object[] {
            " "});
            this.comboBarcode.Location = new System.Drawing.Point(300, 85);
            this.comboBarcode.Name = "comboBarcode";
            this.comboBarcode.Size = new System.Drawing.Size(413, 44);
            this.comboBarcode.TabIndex = 10;
            this.comboBarcode.SelectedValueChanged += new System.EventHandler(this.comboBarcode_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(573, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "Remarks:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.remarkLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarkLabel.ForeColor = System.Drawing.Color.White;
            this.remarkLabel.Location = new System.Drawing.Point(27, 73);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Padding = new System.Windows.Forms.Padding(5);
            this.remarkLabel.Size = new System.Drawing.Size(85, 31);
            this.remarkLabel.TabIndex = 14;
            this.remarkLabel.Text = "Remarks";
            // 
            // daysAfterSent
            // 
            this.daysAfterSent.AutoSize = true;
            this.daysAfterSent.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysAfterSent.ForeColor = System.Drawing.Color.White;
            this.daysAfterSent.Location = new System.Drawing.Point(25, 160);
            this.daysAfterSent.Name = "daysAfterSent";
            this.daysAfterSent.Size = new System.Drawing.Size(161, 24);
            this.daysAfterSent.TabIndex = 15;
            this.daysAfterSent.Text = "Days after sent";
            this.daysAfterSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RemarkPanel
            // 
            this.RemarkPanel.Controls.Add(this.label6);
            this.RemarkPanel.Controls.Add(this.label5);
            this.RemarkPanel.Controls.Add(this.daysAfterSent);
            this.RemarkPanel.Controls.Add(this.button1);
            this.RemarkPanel.Controls.Add(this.remarkLabel);
            this.RemarkPanel.Controls.Add(this.BackgroundDays);
            this.RemarkPanel.Controls.Add(this.label2);
            this.RemarkPanel.Controls.Add(this.label1);
            this.RemarkPanel.Location = new System.Drawing.Point(228, 230);
            this.RemarkPanel.Name = "RemarkPanel";
            this.RemarkPanel.Size = new System.Drawing.Size(596, 282);
            this.RemarkPanel.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-1, 162);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(15, 22);
            this.label6.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, 54);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(15, 70);
            this.label5.TabIndex = 18;
            // 
            // BackgroundDays
            // 
            this.BackgroundDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundDays.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundDays.Location = new System.Drawing.Point(0, 162);
            this.BackgroundDays.Name = "BackgroundDays";
            this.BackgroundDays.Size = new System.Drawing.Size(596, 22);
            this.BackgroundDays.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 70);
            this.label1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(0, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1030, 41);
            this.label3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 54);
            this.label4.TabIndex = 18;
            this.label4.Text = "BARCODE ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(1017, 655);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemarkPanel);
            this.Controls.Add(this.listOfItems);
            this.Controls.Add(this.comboBarcode);
            this.Controls.Add(this.label3);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfItems)).EndInit();
            this.RemarkPanel.ResumeLayout(false);
            this.RemarkPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView listOfItems;
        private System.Windows.Forms.ComboBox comboBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label remarkLabel;
        private System.Windows.Forms.Label daysAfterSent;
        private System.Windows.Forms.Panel RemarkPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfRemark;
        private System.Windows.Forms.Label BackgroundDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}