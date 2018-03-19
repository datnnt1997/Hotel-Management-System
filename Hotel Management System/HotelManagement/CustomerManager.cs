using Business_Logic_Layer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class CustomerManager : Form
    {
        public CustomerManager()
        {
            InitializeComponent();
            updatePanel.Hide();
            searchPanel.Hide();
            deletePanel.Hide();
            viewPanel.Hide();
            addpanel.Show();
            IDTextBox.Text = "C" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void updatepanelleft_Click(object sender, EventArgs e)
        {
            addpanel.Hide();
            updatePanel.Show();
            deletePanel.Hide();
            viewPanel.Hide();
            searchPanel.Hide();
            this.addpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.viewpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.deletepanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.searchpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.updatepanelleft.BackColor = System.Drawing.Color.Gold;
        }

        private void deletepanelleft_Click(object sender, EventArgs e)
        {
            addpanel.Hide();
            updatePanel.Hide();
            deletePanel.Show();
            viewPanel.Hide();
            searchPanel.Hide();
            this.addpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.viewpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.deletepanelleft.BackColor = System.Drawing.Color.Gold;
            this.searchpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.updatepanelleft.BackColor = System.Drawing.Color.Goldenrod;
        }

        private void addpanelleft_Click(object sender, EventArgs e)
        {
            updatePanel.Hide();
            deletePanel.Hide();
            searchPanel.Hide();
            viewPanel.Hide();
            addpanel.Show();
            this.addpanelleft.BackColor = System.Drawing.Color.Gold;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.viewpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.deletepanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.searchpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.updatepanelleft.BackColor = System.Drawing.Color.Goldenrod;
            IDTextBox.Text = "C" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            passportTextBox.Focus();
        }

        private void searchpanelleft_Click(object sender, EventArgs e)
        {
            updatePanel.Hide();
            deletePanel.Hide();
            searchPanel.Show();
            viewPanel.Hide();
            addpanel.Hide();
            this.addpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.viewpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.deletepanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.searchpanelleft.BackColor = System.Drawing.Color.Gold;
            this.updatepanelleft.BackColor = System.Drawing.Color.Goldenrod;
        }

        private void viewpanelleft_Click(object sender, EventArgs e)
        {
            updatePanel.Hide();
            deletePanel.Hide();
            searchPanel.Hide();
            viewPanel.Show();
            addpanel.Hide();
            this.addpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.viewpanelleft.BackColor = System.Drawing.Color.Gold;
            this.deletepanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.searchpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.updatepanelleft.BackColor = System.Drawing.Color.Goldenrod;
            CustomerBUS.Instance.displayAll(customerTable);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == String.Empty || passportTextBox.Text == String.Empty || fNameTextBox.Text == String.Empty || lnameTextBox.Text == String.Empty || birthday.Text == String.Empty ||
           sexComboBox.Text == String.Empty || phoneTextBox.Text == String.Empty || emailTextBox.Text == String.Empty || addressTextBox.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                CustomerDTO cusNewCustomer = new CustomerDTO(IDTextBox.Text, passportTextBox.Text, fNameTextBox.Text, lnameTextBox.Text, birthday.Text,
                                                  sexComboBox.Text, phoneTextBox.Text, emailTextBox.Text, addressTextBox.Text, 0, 0);
                if (CustomerBUS.Instance.insertCustomer(cusNewCustomer))
                {
                    MessageBox.Show("Add Customer Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBox.Clear();
                    passportTextBox.Clear();
                    fNameTextBox.Clear();
                    lnameTextBox.Clear();
                    birthday.Value = DateTime.Now;
                    sexComboBox.SelectedItem = "";
                    phoneTextBox.Clear();
                    emailTextBox.Clear();
                    addressTextBox.Clear();
                    IDTextBox.Text = "C" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
                }
                else
                {
                    MessageBox.Show("Add Customer Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CIDTextBoxDel.Text == String.Empty && passportIDTextBoxDEL.Text == String.Empty)
            {
                MessageBox.Show("Please provide information to search!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                CustomerDTO customer = CustomerBUS.Instance.searchCustomer(CIDTextBoxDel.Text, passportIDTextBoxDEL.Text);
                if (customer != null)
                {
                    CIDTextBoxDel.Text = customer.CID;
                    passportIDTextBoxDEL.Text = customer.PassportID;
                    firstNameTextBoxDEL.Text = customer.FirstName;
                    lastNameTextBoxDEL.Text = customer.LastName;
                    birthDatedateTimePickerDEL.Text = customer.Birthday;
                    sexComboBoxDEL.Text = customer.Sex;
                    phoneTextBoxDEL.Text = customer.Phone;
                    emailTextBoxDEL.Text = customer.Email;
                    addressTextBoxDEL.Text = customer.Address;
                    vipTextBoxDEL.Text = customer.VIP.ToString();
                    moneyTextBoxDEL.Text = customer.Money.ToString();
                }
                else
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = new CustomerDTO(CIDTextBoxDel.Text, passportIDTextBoxDEL.Text, firstNameTextBoxDEL.Text, lastNameTextBoxDEL.Text,
                birthDatedateTimePickerDEL.Text, sexComboBoxDEL.Text, phoneTextBoxDEL.Text, emailTextBoxDEL.Text, addressTextBoxDEL.Text, Int32.Parse(vipTextBoxDEL.Text),
                float.Parse(moneyTextBoxDEL.Text));
            if (CustomerBUS.Instance.updateCustomer(customer))
            {
                MessageBox.Show("Update Customer Successful!", "Message", MessageBoxButtons.OK);
                CIDTextBoxDel.Clear();
                passportIDTextBoxDEL.Clear();
                firstNameTextBoxDEL.Clear();
                lastNameTextBoxDEL.Clear();
                birthDatedateTimePickerDEL.Value = DateTime.Now;
                sexComboBoxDEL.SelectedItem = "";
                phoneTextBoxDEL.Clear();
                emailTextBoxDEL.Clear();
                addressTextBoxDEL.Clear();
                vipTextBoxDEL.Clear();
                moneyTextBoxDEL.Clear();
            }
            else
            {
                MessageBox.Show("Update Customer Faile!", "Message", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CIDTextBoxSearch.Text == String.Empty && passportIDTextBoxSearch.Text == String.Empty)
            {
                MessageBox.Show("Please provide information to search!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                CustomerDTO customer = CustomerBUS.Instance.searchCustomer(CIDTextBoxSearch.Text, passportIDTextBoxSearch.Text);
                if (customer != null)
                {
                    CIDTextBoxSearch.Text = customer.CID;
                    passportIDTextBoxSearch.Text = customer.PassportID;
                    firstNameTextBoxSearch.Text = customer.FirstName;
                    lastNameTextBoxSearch.Text = customer.LastName;
                    textBox10.Text = customer.Birthday;
                    textBox11.Text=customer.Sex.ToString();
                    phoneTextBoxSearch.Text = customer.Phone;
                    emailTextBoxSearch.Text = customer.Email;
                    addressTextBoxSearch.Text = customer.Address;
                    vipTextBoxSearch.Text = customer.VIP.ToString();
                    moneyTextBoxSearch.Text = customer.Money.ToString();
                }
                else
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CIDTextBoxDelete.Text == String.Empty && passportIDtextBoxDelete.Text == String.Empty)
            {
                MessageBox.Show("Please provide information to search!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                CustomerDTO customer = CustomerBUS.Instance.searchCustomer(CIDTextBoxDelete.Text, passportIDtextBoxDelete.Text);
                if (customer != null)
                {
                    CIDTextBoxDelete.Text = customer.CID;
                    passportIDtextBoxDelete.Text = customer.PassportID;
                    firstNameTextBoxDelete.Text = customer.FirstName;
                    lastNameTextBoxDelete.Text = customer.LastName;
                    birthdayTextBoxDelete.Text = customer.Birthday;
                    genderTextBoxDelete.Text = customer.Sex;
                    phoneTextBoxDelete.Text = customer.Phone;
                    emailTextBoxDelete.Text = customer.Email;
                    addressTextBox1Delete.Text = customer.Address;
                    vipTextBoxDelete.Text = customer.VIP.ToString();
                    moneyTextBoxDelete.Text = customer.Money.ToString();
                }
                else
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {


            if (CustomerBUS.Instance.deleteCustomer(CIDTextBoxDelete.Text, passportIDtextBoxDelete.Text))
            {
                MessageBox.Show("Delete Customer Successful!", "Message", MessageBoxButtons.OK);
                CIDTextBoxDelete.Clear();
                passportIDtextBoxDelete.Clear();
                firstNameTextBoxDelete.Clear();
                lastNameTextBoxDelete.Clear();

                
                phoneTextBoxDelete.Clear();
                emailTextBoxDelete.Clear();
                addressTextBox1Delete.Clear();
            }
            else
            {
                MessageBox.Show("Delete Customer Faile!", "Message", MessageBoxButtons.OK);
            }

        }

        private void passportIDtextBoxDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4_Click(sender, e);
            }
        }

        private void passportIDTextBoxDEL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }

        private void passportIDTextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button6_Click(sender, e);
            }
        }
    }
}
