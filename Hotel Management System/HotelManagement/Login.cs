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
    public partial class Login : Form
    {
        private string cs;

        public Login()
        {
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            UserBUS user = new UserBUS();
            if (PassTextBox.Text.ToString() == String.Empty && userTextBox.Text.ToString() == String.Empty)
            {
                this.loginButton.ForeColor = System.Drawing.Color.Red;
                this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.loginButton.ForeColor = System.Drawing.Color.Red;
                loginButton.Text = "Please provide Username and Password";
                PassTextBox.Text = "";
            }
            else
            if (userTextBox.Text == "")
            {
                this.loginButton.ForeColor = System.Drawing.Color.Red;
                this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                loginButton.Text = "Please provide Username";
                PassTextBox.Text = "";
            }
            else if (PassTextBox.Text.ToString() == String.Empty)
            {
                this.loginButton.ForeColor = System.Drawing.Color.Red;
                this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                loginButton.Text = "Please provide Password";
                PassTextBox.Text = "";
            }
            else if (user.Login(userTextBox.Text.ToString(), PassTextBox.Text.ToString()))
            {
                int EID = UserBUS.Instance.searchEmployeeID(userTextBox.Text);
                String Occupation = UserBUS.Instance.searchOccupation(UserBUS.Instance.searchEmployeeID(userTextBox.Text));
                UserStatusBUS.Instance.setAccout(new UserStatusDTO(0, userTextBox.Text, PassTextBox.Text, EID, Occupation));
                HomePage hpform = new HomePage();
                this.Hide();
                hpform.Show();
            }
            else
            {
                this.loginButton.ForeColor = System.Drawing.Color.Red;
                this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                loginButton.Text = "Username or Password are not correct!";
            }
        }
        private void userTextBox_Click(object sender, EventArgs e)
        {
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginButton.Text = "Sign in";

        }

        private void loginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserBUS user = new UserBUS();
                if (PassTextBox.Text.ToString() == String.Empty && userTextBox.Text.ToString() == String.Empty)
                {
                    this.loginButton.ForeColor = System.Drawing.Color.Red;
                    this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.loginButton.ForeColor = System.Drawing.Color.Red;
                    loginButton.Text = "Please provide Username and Password";
                    PassTextBox.Text = "";
                }
                else
                if (userTextBox.Text == "")
                {
                    this.loginButton.ForeColor = System.Drawing.Color.Red;
                    this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    loginButton.Text = "Please provide Username";
                    PassTextBox.Text = "";
                }
                else if (PassTextBox.Text.ToString() == String.Empty)
                {
                    this.loginButton.ForeColor = System.Drawing.Color.Red;
                    this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    loginButton.Text = "Please provide Password";
                    PassTextBox.Text = "";
                }
                else if (user.Login(userTextBox.Text.ToString(), PassTextBox.Text.ToString()))
                {
                    int EID = UserBUS.Instance.searchEmployeeID(userTextBox.Text);
                    String Occupation = UserBUS.Instance.searchOccupation(UserBUS.Instance.searchEmployeeID(userTextBox.Text));
                    UserStatusBUS.Instance.setAccout(new UserStatusDTO(0, userTextBox.Text, PassTextBox.Text, EID, Occupation));
                    HomePage hpform = new HomePage();
                    this.Hide();
                    hpform.Show();
                }
                else
                {
                    this.loginButton.ForeColor = System.Drawing.Color.Red;
                    this.loginButton.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    loginButton.Text = "Username or Password are not correct!";
                }
            }
        }
    }
}
