using DTS.BL;
using MailKit.Net.Smtp;
using MimeKit;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using Zen.Barcode;

namespace Document_Tracking_w_Barcode
{
    public partial class Form1 : Form
    {
        //private string _fullname;
        Employees employee = new Employees();
        Document documentForm1 = new Document();
        private string _path = null;
        private string folderPath { get; set; }
        public List<string> Emails;
       
        bool scanning;
        public List<string> listOfDocuments;
        int scannedCount = 0;
        private string  destFile = null;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Login login)
        {
            InitializeComponent();
            employee.FullName = login.FullName;
            employee.EmployeeID = login.LoginID;
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            ActionMethodPopulate();

            RemoveEditingDropDown();
            //POPULATE DROPDOWNS & LISTBOX
            EmailDocTypePrimDocPopulation();
            HelloUser();
            ListScanners();

            // Set start output folder TMP
            folderPath = Path.GetFullPath(@"\\10.20.4.30\temp\");
            listOfDocuments = new List<string>();
            this.Size = new System.Drawing.Size(this.Size.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void ActionMethodPopulate()
        {
            panel7.AutoScroll = true;
            ActionTabMethod actTabMethod = new ActionTabMethod();
            RadioButton radBtn;
            int radioBtnInc = 0;
            int radY = 0;
            foreach (var actions in actTabMethod.GetAllAction())
            {
                radBtn = new RadioButton();
                radBtn.Name = $"radBtn{radioBtnInc}";
                radBtn.AutoSize = true;
                radBtn.Location = new System.Drawing.Point(36, radY);
                radBtn.Size = new System.Drawing.Size(130, 25);
                radBtn.TabIndex = 0;
                radBtn.Text = actions;
                radBtn.UseVisualStyleBackColor = true;
                radioBtnInc++;

                panel7.Controls.Add(radBtn);
                radY += 33;
            }
        }

        private void RemoveEditingDropDown()
        {
            primaryDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            docType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void HelloUser()
        {
            helloUser.Text = $"Hello {employee.FullName}";
        }

        private void EmailDocTypePrimDocPopulation()
        {
            DocumentMethod docMeth = new DocumentMethod(null);
            docCount.Text = docMeth.GetDocumentCount();
            
            foreach (var primDoc in docMeth.GetPrimaryDoc())
            {
                primaryDoc.Items.Add(primDoc);
            }
            foreach (var documentType in docMeth.GetDocumentType())
            {
                docType.Items.Add(documentType);
            }
            OfficeAndDivisionMethod officeAndDivisionMethod = new OfficeAndDivisionMethod();
            officeAndDivisionList.DataSource = officeAndDivisionMethod.GetAllOfficeAndDivision();
        }

        private void ListScanners()
        {
            // Clear the ListBox.
            listOfPrinters.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                listOfPrinters.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
        }

     
        private void TriggerScan()
        {
            Console.WriteLine("Image succesfully scanned");
            scanBtn.Enabled = true;
            if (Scanner.doneScanning)
            {
                using(PdfDocument doc = new PdfDocument())
                {
                    listOfDocuments.RemoveAt(listOfDocuments.Count() - 1);
                    var i = 0;
                    foreach (var list in listOfDocuments)
                    {
                        doc.Pages.Add(new PdfPage());
                        using (XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i]))
                        {
                            using (XImage img = XImage.FromFile(list))
                            {
                                xgr.DrawImage(img, 0, 0);
                            }
                        }
                        i++;
                    }
                    destFile= $@"\\10.20.4.30\temp\{refNo.Text}.pdf";
                    doc.Save(destFile);
                    doc.Close();
                }
            }
        }

        public void StartScanning()
        {
            Scanner device = null;
            scanBtn.Enabled = false;
            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listOfPrinters.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                scanning = false;
                return;
            }
            else if (String.IsNullOrEmpty(refNo.Text))
            {
                MessageBox.Show("Provide a filename",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                scanning = false;
                return;
            }

            ImageFile image = new ImageFile();
            image = device.ScanJPEG();
            string imageExtension = ".jpeg";



           
            // Save the image
            _path = Path.Combine(folderPath, refNo.Text+ Convert.ToString(scannedCount +=1)+ imageExtension);

            listOfDocuments.Add(_path);


            try
            {
                if (File.Exists(_path))
                {
                    scannedDocument.Image.Dispose();
                    File.Delete(_path);
                }
               
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                    try
                    {
                       
                        image.SaveFile(_path);
                        Bitmap tempScan = new Bitmap(_path);
                        tempScan = ResizeImage(tempScan, 333, 387);
                        scannedDocument.Image = tempScan;
                        }
                        catch (COMException e)
                        {
                            uint errorCode = (uint)e.ErrorCode;
                            if (errorCode == 0x80210070)
                            {
                                scanning = false;
                                
                            }
                        }
                    }));
            }
            catch(COMException e)
            {
              MessageBox.Show("There is no paper to be scan!");
            }
        }
       
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution); // retains dpi reguardless of physical size

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        bool CheckInput()
        {
            bool check = false ;
            if (string.IsNullOrWhiteSpace(employeeRemark.Text) || string.IsNullOrWhiteSpace(fromUser.Text) || string.IsNullOrWhiteSpace(transportation.Text)
                || string.IsNullOrWhiteSpace(docType.Text) || string.IsNullOrWhiteSpace(primaryDoc.Text)
                || string.IsNullOrWhiteSpace(subject.Text) || string.IsNullOrWhiteSpace(refNo.Text) || string.IsNullOrWhiteSpace(uploadTxt.Text))
            {
                check = false;
            }
            else
            {
                check = true;
            }
                return check;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm1();
        }

      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
      
        
        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseForm1()
        {
            this.Dispose();
            Form2 form2 = new Form2();
            form2.Show();
            
        }


     

        private void Save(DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.Yes)
            {

                if (Scanner.doneScanning && CheckInput() && emailList.CheckedItems.Count > 0 && !String.IsNullOrEmpty(destFile))
                {
                    Document doc = new Document();
                    doc.BarcodeNo = refNo.Text;
                    foreach (string employeeemail in emailList.CheckedItems.OfType<string>().ToList<string>())
                    {
                        doc.SendTo.Add(employeeemail);
                    }

                    doc.Remarks = employeeRemark.Text;
                    doc.DateCreated = dateCreated.Value;
                    doc.DateReceived = dateReceived.Value;
                    doc.EmployeeFrom = fromUser.Text;
                    doc.Transportation = transportation.Text;
                    doc.PrimaryDoc = primaryDoc.SelectedIndex;
                    doc.DocType = docType.SelectedIndex;
                    doc.Subject = subject.Text;
                    doc.UploadedFile = uploadTxt.Text;
                    doc.Tags = $"{Tag1Txt.Text},{Tag2Txt.Text},{Tag3Txt.Text},{Tag4Txt.Text}";
                    doc.DocumentLocation = destFile; //destfile
                    DocumentMethod docmet = new DocumentMethod(doc);
                    employee.ListEmail = docmet.GetEmployeeByEmail();
                    doc.LastRemarkID = docmet.GetLastRemarkID();
                    foreach (var employeeID in docmet.ListEmployeeID())
                    {
                        employee.ListEmployeeID = new List<string>();
                        employee.ListEmployeeID.Add(employeeID);
                    }
                    DocumentMethod docmet2 = new DocumentMethod(doc, employee);
                    InsertDocument(doc, docmet2);
                    EmailToUser(doc, docmet2);
                    CopyFile();
                }
                else
                {
                    MessageBox.Show($"Information not saved! Please provide the necessary information");
                }
            }
            else
            {
                MessageBox.Show($"Information not saved! Please provide the necessary information");
            }
        }

        private void InsertDocument(Document doc, DocumentMethod docmet2)
        {
            if (docmet2.InsertPendingDocument())
            {
            }
            else
            {
                MessageBox.Show($"PD not saved!");
            }
        }

        
        private void EmailToUser(Document doc, DocumentMethod docmet2)
        {
            if (docmet2.InsertDocument() && Email(doc.SendTo))
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(10000, "DOCUMENT SAVED & EMAIL SENT!", "The document has been saved and an email has been sent!", ToolTipIcon.Info);
                docCount.Text = docmet2.GetDocumentCount();
            }
        }

        public bool Email(List<string> emails)
        {
            bool messageSent = false;
            foreach (var email in emails)
            {
             
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("DTI MIMAROPA", "DTImimaropa4b@gmail.com"));
                message.To.Add(new MailboxAddress("Employee", email));
                message.Subject = "";

                var builder = new BodyBuilder();
                builder.TextBody = $@"{DateTime.Now.Date}
                                    Dear Employee,
                                        You have received a new document,please open 
                                    your [Document Tracking System], check at the 
                                    {refNo.Text} document and consider the remarks. 
                                        Thank you!
                                    Sincerely {employee.FirstName} {employee.LastName},
    ";
                message.Body = builder.ToMessageBody();

                try
                {
                    var client = new SmtpClient();

                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("DTImimaropa4b@gmail.com", "aezakmi4b");
                    client.Send(message);
                    client.Disconnect(true);

                    Console.WriteLine("Send Mail Success.");
                    messageSent = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Send Mail Failed : " + ex.Message);
                    messageSent = false;
                }

               
            }
            return messageSent;

        }

 
        private async void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            scanning = true;
            while (scanning)
            {
                await Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
            }

           
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(destFile))
            {
                Process.Start(destFile);
            }
        }

     

    

      
        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListScanners();
        }


        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to send this to other employees?", "Saving..", MessageBoxButtons.YesNo);
            Save(dialogResult);
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OfficeAndDivisionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            emailList.Items.Clear();
            //change the email base on the text of this list
            OfficeAndDivision officeAndDivision = new OfficeAndDivision();
            officeAndDivision.OfficesAndDivisions = officeAndDivisionList.SelectedItem.ToString();
            OfficeAndDivisionMethod officeAndDivisionMet = new OfficeAndDivisionMethod(officeAndDivision);
            officeAndDivision.OfficeAndDivisionID = officeAndDivisionMet.GetOfficeAndDivisionID();
            DocumentMethod docMeth = new DocumentMethod(null,null, officeAndDivision);
            foreach (var emails in docMeth.SearchEmails())
            {
                emailList.Items.Add(emails);
            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            using (openFileDialog1)
            {
                openFileDialog1.Multiselect = true;
                openFileDialog1.ShowDialog();
                List<string> files = new List<string>(openFileDialog1.FileNames);
                String listOfFile = null;
                foreach (var file in files)
                {
                        listOfFile += file + ",";
                }

              
                uploadTxt.Text = listOfFile.Remove(listOfFile.Length - 1); 
            }
           
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Tag4Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void AddTags(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<string> tags = new List<string>();
                tags.Add(Tag4Txt.Text);
                foreach(var tag in tags)
                {
                    Tag4Txt.Text = "";
                    Tag4Txt.Text += $",{tag}";
                }
               
            }
        }

        private void Tag4Txt_KeyDown(object sender, KeyEventArgs e)
        {
            AddTags(e);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
        }

        private void CopyFile()
        {
            int a = 0;
            string newPath = null;
            string ext = null;
            foreach (var files in SplitFiles())
            {
                string path = Path.GetFullPath(files);
                ext = Path.GetExtension(path);
                if (a >= 10)
                {
                    newPath = Path.GetFullPath($@"\\10.20.4.30\temp\{refNo.Text}{a}{ext}");
                }
                else
                {
                    newPath = Path.GetFullPath($@"\\10.20.4.30\temp\{refNo.Text}0{a}{ext}");
                }
               
                    File.Copy(path, newPath);
                a++;
            }
            uploadTxt.Text = "";
            MessageBox.Show("File has been moved!");
        }

        private List<string> SplitFiles()
        {
            List<string> path = new List<string>();
            List<string> i = new List<string>(uploadTxt.Text.Split(','));
            i.RemoveAt(i.Count() - 1);
            foreach (var io in i)
            {
                path.Add(io);
            }
            return path;

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
            
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            if (deadlineDate.Enabled)
            {
                deadlineDate.Enabled = false;
            }
            else
            {
                deadlineDate.Enabled = true;
            }
        }
    }
}
