using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using DataTranferObject;
namespace HotelManagement
{
    public partial class EmployeeManager : Form
    {
        public EmployeeManager()
        {
            InitializeComponent();
            updatePanel.Hide();
            viewPanel.Hide();
            searchPanel.Hide();
            deletePanel.Hide();
            addPanel.Show();
            EIDTextBoxAdd.Text = EmployeeBUS.Instance.getID().ToString();
        }

        private void addpanelleft_Click(object sender, EventArgs e)
        {
            viewPanel.Hide();
            updatePanel.Hide();
            deletePanel.Hide();
            searchPanel.Hide();
            addPanel.Show();
            this.backpanelleft.BackColor = System.Drawing.Color.Navy;
            this.viewpanelleft.BackColor = System.Drawing.Color.Navy;
            this.updatepanelleft.BackColor = System.Drawing.Color.Navy;
            this.searchpanelleft.BackColor = System.Drawing.Color.Navy;
            this.deletepanelleft.BackColor = System.Drawing.Color.Navy;
            this.addpanelleft.BackColor = System.Drawing.Color.MediumBlue;
            EIDTextBoxAdd.Text=EmployeeBUS.Instance.getID().ToString();
        }

        private void deletepanelleft_Click(object sender, EventArgs e)
        {
            viewPanel.Hide();
            updatePanel.Hide();
            deletePanel.Show();
            searchPanel.Hide();
            addPanel.Hide();
            this.backpanelleft.BackColor = System.Drawing.Color.Navy;
            this.viewpanelleft.BackColor = System.Drawing.Color.Navy;
            this.updatepanelleft.BackColor = System.Drawing.Color.Navy;
            this.searchpanelleft.BackColor = System.Drawing.Color.Navy;
            this.deletepanelleft.BackColor = System.Drawing.Color.MediumBlue;
            this.addpanelleft.BackColor = System.Drawing.Color.Navy;
        }

        private void updatepanelleft_Click(object sender, EventArgs e)
        {
            viewPanel.Hide();
            updatePanel.Show();
            deletePanel.Hide();
            searchPanel.Hide();
            addPanel.Hide();
            this.backpanelleft.BackColor = System.Drawing.Color.Navy;
            this.viewpanelleft.BackColor = System.Drawing.Color.Navy;
            this.updatepanelleft.BackColor = System.Drawing.Color.MediumBlue;
            this.searchpanelleft.BackColor = System.Drawing.Color.Navy;
            this.deletepanelleft.BackColor = System.Drawing.Color.Navy;
            this.addpanelleft.BackColor = System.Drawing.Color.Navy;
        }

        private void searchpanelleft_Click(object sender, EventArgs e)
        {
            viewPanel.Hide();
            updatePanel.Hide();
            deletePanel.Hide();
            searchPanel.Show();
            addPanel.Hide();
            this.searchpanelleft.BackColor = System.Drawing.Color.MediumBlue;
            this.backpanelleft.BackColor = System.Drawing.Color.Navy;
            this.viewpanelleft.BackColor = System.Drawing.Color.Navy;
            this.updatepanelleft.BackColor = System.Drawing.Color.Navy;
            this.deletepanelleft.BackColor = System.Drawing.Color.Navy;
            this.addpanelleft.BackColor = System.Drawing.Color.Navy;
        }

        private void viewpanelleft_Click(object sender, EventArgs e)
        {
            viewPanel.Show();
            updatePanel.Hide();
            deletePanel.Hide();
            searchPanel.Hide();
            addPanel.Hide();
            this.backpanelleft.BackColor = System.Drawing.Color.Navy;
            this.viewpanelleft.BackColor = System.Drawing.Color.MediumBlue;
            this.updatepanelleft.BackColor = System.Drawing.Color.Navy;
            this.deletepanelleft.BackColor = System.Drawing.Color.Navy;
            this.searchpanelleft.BackColor = System.Drawing.Color.Navy;
            this.addpanelleft.BackColor = System.Drawing.Color.Navy;
            EmployeeBUS.Instance.displayAll(customerTable);
        }
        private void search_Click(object sender, EventArgs e)
        {
            if (EIDTextBoxSearch.Text == String.Empty )
            {
                MessageBox.Show("Please provide information to search!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                EmployeeDTO employee = EmployeeBUS.Instance.searchEmployee(EIDTextBoxSearch.Text);
                UserDTO user = UserBUS.Instance.searchEmployee(EIDTextBoxSearch.Text);
                if (employee != null && user !=null)
                {
                    EIDTextBoxSearch.Text = employee.EID.ToString() ;
                    fNameTextBoxSearch.Text = employee.FirstName;
                    lNameTextBoxSearch.Text = employee.LastName;
                    birthdayTextBoxSearch.Text = employee.Birthday;
                    sexTextBoxSearch.Text = employee.Sex.ToString()=="1" ? "Female" : "Male" ;
                    phoneTextBoxSearch.Text = employee.Phone.ToString();
                    emailTextBoxSearch.Text = employee.Email;
                    addressTextBoxSeach.Text = employee.Address;
                    occupationTextBoxSearch.Text = employee.Occupation;
                    salaryTextBoxSearch.Text = employee.Salary.ToString();
                    UsernameTextBoxSearch.Text = user.UserName;
                    passwordTextBoxSearch.Text = user.PassWord;

                }
                else
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK);
                }
            }
        }
        private void search_Update_Click(object sender, EventArgs e)
        {
            if (EIDTextBoxUpdate.Text == String.Empty)
            {
                MessageBox.Show("Please provide information to search!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                EmployeeDTO employee = EmployeeBUS.Instance.searchEmployee(EIDTextBoxUpdate.Text);
                UserDTO user = UserBUS.Instance.searchEmployee(EIDTextBoxUpdate.Text);
                if (employee != null && user != null)
                {
                    EIDTextBoxUpdate.Text = employee.EID.ToString();
                    fNameTextBoxUpdate.Text = employee.FirstName;
                    lNameTextBoxUpdate.Text = employee.LastName;
                    brithdayTextUpdate.Text = employee.Birthday;
                    genderTextUpdate.Text = employee.Sex.ToString() == "1" ? "Female" : "Male";
                    phoneTextBoxUpdate.Text = employee.Phone.ToString();
                    emailTextBoxUpdate.Text = employee.Email;
                    addressTextBoxUpdate.Text = employee.Address;
                    occupationTextBoxUpdata.Text = employee.Occupation;
                    salaryTextBoxUpdate.Text = employee.Salary.ToString();
                    usernameTextBoxUpdate.Text = user.UserName;
                    passwordTextBoxUpdate.Text = user.PassWord;

                }
                else
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK);
                }
            }
        }
        private void search_delete_Click(object sender, EventArgs e)
        {
            if (EIDTextBoxDelete.Text == String.Empty)
            {
                MessageBox.Show("Please provide information to search!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                EmployeeDTO employee = EmployeeBUS.Instance.searchEmployee(EIDTextBoxDelete.Text);
                UserDTO user = UserBUS.Instance.searchEmployee(EIDTextBoxDelete.Text);
                if (employee != null && user != null)
                {
                    EIDTextBoxDelete.Text = employee.EID.ToString() ;
                    fNameTextBoxDelete.Text = employee.FirstName;
                    lNameTextBoxDelete.Text = employee.LastName;
                    birthdaytTextBoxDelete.Text= employee.Birthday;
                    sexTextBoxDelete.Text = employee.Sex.ToString() == "1" ? "Female" : "Male";
                    phoneTextBoxDelete.Text = employee.Phone.ToString();
                    emailTextBoxDelete.Text = employee.Email;
                    addressTextBoxDelete.Text = employee.Address;
                    occupationTextBoxDelete.Text = employee.Occupation;
                    salaryTextBoxDelete.Text = employee.Salary.ToString();
                    usernameTextBoxDelete.Text = user.UserName;
                    passwordTextBoxDelete.Text = user.PassWord;

                }
                else
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK);
                }
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            EmployeeDTO employee = new EmployeeDTO(Int32.Parse( EIDTextBoxUpdate.Text), fNameTextBoxUpdate.Text, lNameTextBoxUpdate.Text,
                brithdayTextUpdate.Text, genderTextUpdate.Text, phoneTextBoxUpdate.Text, emailTextBoxUpdate.Text, addressTextBoxUpdate.Text, occupationTextBoxUpdata.Text,
               float.Parse( salaryTextBoxUpdate.Text));
            UserDTO user = new UserDTO(EIDTextBoxUpdate.Text, usernameTextBoxUpdate.Text, passwordTextBoxUpdate.Text);
            if (EmployeeBUS.Instance.updateEmployee(employee) && UserBUS.Instance.updateEmployee(user))
            {
                MessageBox.Show("Update Employe Successful!", "Message", MessageBoxButtons.OK);
                EIDTextBoxUpdate.Clear();
                fNameTextBoxUpdate.Clear();
                lNameTextBoxUpdate.Clear();
                brithdayTextUpdate.Value = DateTime.Now;
                genderTextUpdate.SelectedItem = "";
                phoneTextBoxUpdate.Clear();
                emailTextBoxUpdate.Clear();
                addressTextBoxUpdate.Clear();
                occupationTextBoxUpdata.SelectedItem = "";
                salaryTextBoxUpdate.Clear();
                usernameTextBoxUpdate.Clear();
                passwordTextBoxUpdate.Clear();
            }
            else
            {
                MessageBox.Show("Update Employe Faile!", "Message", MessageBoxButtons.OK);
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {


            if ( UserBUS.Instance.deleteEmployee(EIDTextBoxDelete.Text) && EmployeeBUS.Instance.deleteEmployee(EIDTextBoxDelete.Text))
            {
                
                MessageBox.Show("Delete Employe Successful!", "Message", MessageBoxButtons.OK);
                EIDTextBoxDelete.Clear();
                fNameTextBoxDelete.Clear();
                lNameTextBoxDelete.Clear();
                
                phoneTextBoxDelete.Clear();
                emailTextBoxDelete.Clear();
                addressTextBoxDelete.Clear();
                occupationTextBoxDelete.Clear();
                salaryTextBoxDelete.Clear();
                usernameTextBoxDelete.Clear();
                passwordTextBoxDelete.Clear();
            }
            else
            {
                MessageBox.Show("Delete Employe Faile!", "Message", MessageBoxButtons.OK);
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (EIDTextBoxAdd.Text == String.Empty || fNameTextBoxAdd.Text == String.Empty || lNameTextBoxAdd.Text == String.Empty || birthdayDateTimePickerAdd.Text == String.Empty ||
           sexComboBoxAdd.Text == String.Empty || phoneTextBoxAdd.Text == String.Empty || emailTextBoxAdd.Text == String.Empty || addressTextBoxAdd.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                EmployeeDTO cusNewEmployee = new EmployeeDTO(Int32.Parse( EIDTextBoxAdd.Text.ToString()), fNameTextBoxAdd.Text, lNameTextBoxAdd.Text, birthdayDateTimePickerAdd.Text, 
                                                  sexComboBoxAdd.Text, phoneTextBoxAdd.Text, emailTextBoxAdd.Text, addressTextBoxAdd.Text,
                                                  occupationComboBoxadd.Text, float.Parse(salaryTextBoxAdd.Text));
                UserDTO user = new UserDTO(EIDTextBoxAdd.Text, usernameTextBoxAdd.Text, passwordTextBoxAdd.Text);
                if (EmployeeBUS.Instance.insertEmployee(cusNewEmployee))
                {
                    UserBUS.Instance.insertUser(user);
                    MessageBox.Show("Add Employe Successful!", "Message", MessageBoxButtons.OK);
                    EIDTextBoxAdd.Text = EmployeeBUS.Instance.getID().ToString();
                    fNameTextBoxAdd.Clear();
                    lNameTextBoxAdd.Clear();
                    phoneTextBoxAdd.Clear();
                    emailTextBoxAdd.Clear();
                    addressTextBoxAdd.Clear();
                    occupationComboBoxadd.SelectedItem = "";
                    salaryTextBoxAdd.Clear();

                }
                else
                {
                    MessageBox.Show("Add Employe Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void EIDTextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Click(sender, e);
            }
        }

        private void EIDTextBoxDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_delete_Click(sender, e);
            }
        }

        private void EIDTextBoxUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_Update_Click(sender, e);
            }
        }
    }
}
