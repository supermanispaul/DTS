using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_Tracking_w_Barcode
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            userTypeF1.DropDownStyle = ComboBoxStyle.DropDownList;
            //ADD ITEMS TO TABLE
            AddItemsToTable();
            userTypeF1.SelectedIndex = 0;
        }

        private void AddItemsToTable()
        {
            Login login = new Login();
            foreach (string users in login.GetUserType())
            {
                userTypeF1.Items.Add(users.ToString());
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void CheckPassword()
        {
            if (!showPassword.Checked)
            {
                passWord.isPassword = true;
            }
            else
            {
                passWord.isPassword = false;
            }
        }

        private void Form2_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
           Application.Exit();
            /*   try
              {
                  DirectoryInfo d = new DirectoryInfo(@"\\10.20.4.30\temp\");//Assuming Test is your Folder
                  FileInfo[] Files = d.GetFiles("*.jpeg"); //Getting Text files
                  string str = "";
                  foreach (FileInfo file in Files)
                  {
                      str = file.Name;
                      File.Delete($@"\\10.20.4.30\temp\{str}");
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Cannot delete file" + ex.Message);
              }
              */

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ShowSignupForm();
        }

        private static void ShowSignupForm()
        {
            SignupForm signup = new SignupForm();
            signup.ShowDialog();
        }

        private void passWord_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void passWord_KeyDown(object sender, KeyEventArgs e)
        {
            LoginEvent(e);
        }

        private void LoginEvent(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {
            LoginEvent(e);
        }

        void Login()
        {
            Employees emp = new Employees();
            emp.Username = userName.Text;
            emp.Password = passWord.Text;
            emp.UserType = userTypeF1.Text;
            Login log = new Login();
            if (!log.LoggedIn(emp))
            {
                MessageBox.Show("Wrong credentials...");
            }
            else
            {
                if (emp.UserType == "Administrator")
                {
                    this.Hide();

                    Form1 form1 = new Form1(log);
                    form1.ShowDialog();
                   
                }
                else
                {
                    this.Hide();
                    Form3 form3 = new Form3(log);   
                    form3.ShowDialog();
                    
                    
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Process.Start($@"\\10.20.4.30\scanned-documents\DTI MIMAROPA PPE Inventory 3.17.xls");
        }
    }
}
