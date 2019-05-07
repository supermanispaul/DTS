namespace Document_Tracking_w_Barcode
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RemarkPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarksUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.remarksPop = new System.Windows.Forms.Panel();
            this.daysAfterSent = new System.Windows.Forms.Label();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.BackgroundDays = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.helloUser = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.pendingDocList = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.actionLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.receivedLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RemarkPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.panel5.SuspendLayout();
            this.remarksPop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemarkPanel
            // 
            this.RemarkPanel.BackColor = System.Drawing.Color.White;
            this.RemarkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemarkPanel.Controls.Add(this.panel2);
            this.RemarkPanel.Controls.Add(this.label3);
            this.RemarkPanel.Controls.Add(this.panel5);
            this.RemarkPanel.Controls.Add(this.remarksPop);
            this.RemarkPanel.Location = new System.Drawing.Point(202, 12);
            this.RemarkPanel.Name = "RemarkPanel";
            this.RemarkPanel.Size = new System.Drawing.Size(1015, 763);
            this.RemarkPanel.TabIndex = 2;
            this.RemarkPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.EmployeeList);
            this.panel2.Controls.Add(this.RemarksUpdate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(438, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 762);
            this.panel2.TabIndex = 8;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(104)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(449, 710);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 47);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.AllowUserToResizeRows = false;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.FullName});
            this.EmployeeList.Location = new System.Drawing.Point(46, 142);
            this.EmployeeList.Name = "EmployeeList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeList.Size = new System.Drawing.Size(495, 318);
            this.EmployeeList.TabIndex = 7;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            this.EmployeeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellDoubleClick);
            this.EmployeeList.SelectionChanged += new System.EventHandler(this.EmployeeList_SelectionChanged);
            this.EmployeeList.MouseHover += new System.EventHandler(this.EmployeeList_MouseHover);
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "EmployeeID";
            this.Barcode.Name = "Barcode";
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Employee Name";
            this.FullName.Name = "FullName";
            // 
            // RemarksUpdate
            // 
            this.RemarksUpdate.BackColor = System.Drawing.Color.White;
            this.RemarksUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemarksUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarksUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemarksUpdate.Location = new System.Drawing.Point(36, 590);
            this.RemarksUpdate.Multiline = true;
            this.RemarksUpdate.Name = "RemarksUpdate";
            this.RemarksUpdate.Size = new System.Drawing.Size(505, 114);
            this.RemarksUpdate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(49, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 97);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Remarks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(534, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(40, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Put some remarks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(0, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(575, 60);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(0, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(575, 60);
            this.label6.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(-4, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 45);
            this.label3.TabIndex = 21;
            this.label3.Text = "Remarks:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(-1, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(441, 355);
            this.panel5.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 44);
            this.label11.TabIndex = 19;
            this.label11.Text = "Attached Files:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(-8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(454, 43);
            this.label10.TabIndex = 18;
            // 
            // remarksPop
            // 
            this.remarksPop.BackColor = System.Drawing.Color.White;
            this.remarksPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remarksPop.Controls.Add(this.daysAfterSent);
            this.remarksPop.Controls.Add(this.remarkLabel);
            this.remarksPop.Controls.Add(this.BackgroundDays);
            this.remarksPop.Controls.Add(this.label4);
            this.remarksPop.Location = new System.Drawing.Point(-1, 46);
            this.remarksPop.Name = "remarksPop";
            this.remarksPop.Size = new System.Drawing.Size(442, 305);
            this.remarksPop.TabIndex = 17;
            // 
            // daysAfterSent
            // 
            this.daysAfterSent.AutoSize = true;
            this.daysAfterSent.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysAfterSent.ForeColor = System.Drawing.Color.Black;
            this.daysAfterSent.Location = new System.Drawing.Point(14, 55);
            this.daysAfterSent.Name = "daysAfterSent";
            this.daysAfterSent.Size = new System.Drawing.Size(161, 24);
            this.daysAfterSent.TabIndex = 15;
            this.daysAfterSent.Text = "Days after sent";
            this.daysAfterSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.remarkLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarkLabel.ForeColor = System.Drawing.Color.White;
            this.remarkLabel.Location = new System.Drawing.Point(27, -1);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Padding = new System.Windows.Forms.Padding(5);
            this.remarkLabel.Size = new System.Drawing.Size(85, 29);
            this.remarkLabel.TabIndex = 14;
            this.remarkLabel.Text = "Remarks";
            // 
            // BackgroundDays
            // 
            this.BackgroundDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundDays.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundDays.Location = new System.Drawing.Point(1, 55);
            this.BackgroundDays.Name = "BackgroundDays";
            this.BackgroundDays.Size = new System.Drawing.Size(440, 24);
            this.BackgroundDays.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(0, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 29);
            this.label4.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.helloUser);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 817);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1179, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 41;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_3);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Document_Tracking_w_Barcode.Properties.Resources._220px_DTI_2018_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(1283, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // helloUser
            // 
            this.helloUser.AutoSize = true;
            this.helloUser.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helloUser.Location = new System.Drawing.Point(11, 10);
            this.helloUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloUser.Name = "helloUser";
            this.helloUser.Size = new System.Drawing.Size(96, 25);
            this.helloUser.TabIndex = 40;
            this.helloUser.Text = "Hello User!";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1353, 785);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.pendingDocList);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1345, 754);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pending Documents";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(619, -3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 802);
            this.label8.TabIndex = 13;
            // 
            // pendingDocList
            // 
            this.pendingDocList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pendingDocList.BackColor = System.Drawing.Color.White;
            this.pendingDocList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendingDocList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingDocList.ForeColor = System.Drawing.Color.Black;
            this.pendingDocList.FormattingEnabled = true;
            this.pendingDocList.ItemHeight = 22;
            this.pendingDocList.Location = new System.Drawing.Point(6, 10);
            this.pendingDocList.Name = "pendingDocList";
            this.pendingDocList.Size = new System.Drawing.Size(607, 728);
            this.pendingDocList.TabIndex = 0;
            this.pendingDocList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.pendingDocList.DoubleClick += new System.EventHandler(this.PendingDocList_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.actionLabel);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.barcodeLabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.fromLabel);
            this.panel3.Controls.Add(this.subjectLabel);
            this.panel3.Controls.Add(this.receivedLabel);
            this.panel3.Location = new System.Drawing.Point(637, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 761);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLabel.ForeColor = System.Drawing.Color.White;
            this.actionLabel.Location = new System.Drawing.Point(133, 350);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(0, 22);
            this.actionLabel.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(53, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Action:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(32, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(652, 279);
            this.panel4.TabIndex = 15;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint_1);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Coral;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(652, 41);
            this.label9.TabIndex = 14;
            this.label9.Text = "Attached Files:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLabel.ForeColor = System.Drawing.Color.White;
            this.barcodeLabel.Location = new System.Drawing.Point(136, 438);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(0, 21);
            this.barcodeLabel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(116, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 104);
            this.label7.TabIndex = 11;
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(136, 383);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(0, 21);
            this.fromLabel.TabIndex = 7;
            // 
            // subjectLabel
            // 
            this.subjectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(136, 408);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(0, 21);
            this.subjectLabel.TabIndex = 9;
            // 
            // receivedLabel
            // 
            this.receivedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.receivedLabel.AutoSize = true;
            this.receivedLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedLabel.ForeColor = System.Drawing.Color.White;
            this.receivedLabel.Location = new System.Drawing.Point(136, 467);
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(0, 21);
            this.receivedLabel.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1345, 754);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remarked Document";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RemarkPanel);
            this.Name = "Form3";
            this.Text = "Employee Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.RemarkPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.panel5.ResumeLayout(false);
            this.remarksPop.ResumeLayout(false);
            this.remarksPop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel RemarkPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RemarksUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label receivedLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.ListBox pendingDocList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Panel remarksPop;
        private System.Windows.Forms.Label daysAfterSent;
        private System.Windows.Forms.Label remarkLabel;
        private System.Windows.Forms.Label BackgroundDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label helloUser;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label label12;
    }
}