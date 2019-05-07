using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_Tracking_w_Barcode
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            Signup sup = new Signup();
            TypeUser.DataSource = sup.GetUserType();
            officeList.DataSource = sup.GetOfficeDivision();
            TypeUser.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(IDemp.Text))
                EmpIDx.Visible = true;
            else
                EmpIDx.Visible = false;
            if (string.IsNullOrWhiteSpace(NameF.Text))
                FNamex.Visible = true;
            else
                FNamex.Visible = false;
            if (string.IsNullOrWhiteSpace(NameL.Text))
                LastNameX.Visible = true;
            else
                LastNameX.Visible = false;
            if (string.IsNullOrWhiteSpace(NameU.Text))
                UserNameX.Visible = true;
            else
                UserNameX.Visible = false;
            if (string.IsNullOrWhiteSpace(WPass.Text))
                PasswordX.Visible = true;
            else
                PasswordX.Visible = false;
            if (string.IsNullOrWhiteSpace(MailE.Text))
                EmailX.Visible = true;
            else
                EmailX.Visible = false;
            if (string.IsNullOrWhiteSpace(TypeUser.SelectedItem.ToString()))
                UserX.Visible = true;
            else
                UserX.Visible = false;
            if (string.IsNullOrWhiteSpace(NoCp.Text))
                CpX.Visible = true;
            else
                CpX.Visible = false;
            if (string.IsNullOrWhiteSpace(officeList.SelectedItem.ToString()))
                officeX.Visible = true;
            else
                officeX.Visible = false;


            if (!(string.IsNullOrWhiteSpace(IDemp.Text) || 
                string.IsNullOrWhiteSpace(NameF.Text) || 
                string.IsNullOrWhiteSpace(NameL.Text) ||
                string.IsNullOrWhiteSpace(NameU.Text) ||
                string.IsNullOrWhiteSpace(WPass.Text) ||
                string.IsNullOrWhiteSpace(MailE.Text) ||
                string.IsNullOrWhiteSpace(TypeUser.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(NoCp.Text))) { 
                Employees employees = new Employees();
                employees.EmployeeID = IDemp.Text;
                employees.FirstName = NameF.Text;
                employees.LastName = NameL.Text;
                employees.Username = NameU.Text;
                employees.Password = WPass.Text;
                
                try
                {
                    var test = new MailAddress(MailE.Text);
                    employees.Email = MailE.Text;
                    employees.CellphoneNo = NoCp.Text;
                    int selectedTypeUser = TypeUser.SelectedIndex + 1;
                    employees.UserTypeID = selectedTypeUser;
                    employees.OfficeAndDivisionID = officeList.SelectedIndex + 1;
                    Signup signUp = new Signup();
                    signUp.InsertEmployee(employees);
                    MessageBox.Show("You're now Registered!");

                    IDemp.Text  = "EmployeeID";
                    NameF.Text = "First Name";
                    NameL.Text = "Last Name";
                    NameU.Text = "Username";
                    WPass.Text  = "password";
                    MailE.Text = "Email";
                    TypeUser.SelectedItem = 0;
                    NoCp.Text = "Cellphone Number";
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(@"Please put a right Email. 
                                       "+ ex.Message);
                    EmailX.Visible = true;
                }
                
            }
            else
            {
                MessageBox.Show("Please fill in the required fields!");
            }


        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void NoCp_OnValueChanged(object sender, EventArgs e)
        {
            if (NoCp.Text.Length == 12)
            {
                MessageBox.Show("Maximum of 11 digits");
                NoCp.Text = "";
            }
        }

        private void NoCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void OfficeList_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void IDemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
