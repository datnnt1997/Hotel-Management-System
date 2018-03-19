using Business_Logic_Layer;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            panelmain.Hide();
            changePanel.Hide();


        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel12_MouseHover(object sender, EventArgs e)
        {
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel14_MouseHover(object sender, EventArgs e)
        {
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel15_MouseHover(object sender, EventArgs e)
        {
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel15_MouseLeave(object sender, EventArgs e)
        {
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void panel20_MouseHover(object sender, EventArgs e)
        {
            this.panel20.BackColor = System.Drawing.Color.Gold;
        }

        private void panel20_MouseLeave(object sender, EventArgs e)
        {
            this.panel20.BackColor = System.Drawing.Color.Transparent;
        }

        private void panel17_MouseHover(object sender, EventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.Gold;
        }

        private void panel17_MouseLeave(object sender, EventArgs e)
        {
            this.panel17.BackColor = System.Drawing.Color.Transparent;
        }

        private void panel18_MouseHover(object sender, EventArgs e)
        {
            this.panel18.BackColor = System.Drawing.Color.Gold;
        }

        private void panel18_MouseLeave(object sender, EventArgs e)
        {
            this.panel18.BackColor = System.Drawing.Color.Transparent;
        }


        private void panel19_MouseHover(object sender, EventArgs e)
        {
            this.panel19.BackColor = System.Drawing.Color.Gold;
        }

        private void panel19_MouseLeave(object sender, EventArgs e)
        {
            this.panel19.BackColor = System.Drawing.Color.Transparent;
        }
        private int pClick = 0;
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pClick == 0)
            {
                this.panelmain.Show();
                pClick = 1;
            }
            else
            {
                this.panelmain.Hide();
                pClick = 0;
            }
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager") || (occupation.Equals("Receptionist"))))
            {
                CustomerManager cmform = new CustomerManager();
                this.Hide();
                cmform.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);
            }
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager")))
            {

                EmployeeManager emForm = new EmployeeManager();
            this.Hide();
            emForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);
            }
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if(occupation.Equals("Admin")|| (occupation.Equals("Manager") || (occupation.Equals("Receptionist")))){
                ReservationManager resForm = new ReservationManager();
                this.Hide();
                resForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);
            }
        }
            

        private void panel6_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager") || (occupation.Equals("Receptionist"))))
            {
                RoomManager roomForm = new RoomManager();
                this.Hide();
                roomForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);
            }
}

        private void panel11_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager") ))
            {
                    RentManagement rentForm = new RentManagement();
                this.Hide();
               rentForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager")))
            {
                FacilitiesManager facForm = new FacilitiesManager();
            this.Hide();
            facForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager")) || (occupation.Equals("Receptionist")))
            {
                PromotionManager proFrom = new PromotionManager();
                this.Hide();
                proFrom.Show();
            }
            else
            {
                    MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);

            }
        }


        private void panel10_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager")) || (occupation.Equals("Store Keeper")))
            {
                Warehouse warehouseForm = new Warehouse();
                this.Hide();
                warehouseForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager")) || (occupation.Equals("Engineer")))
            {
                Compensatory compensatoryForm = new Compensatory();
                this.Hide();
                compensatoryForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager")) || (occupation.Equals("Service Staff") || (occupation.Equals("Receptionist"))))
            {
                RequestService requestForm = new RequestService();
            this.Hide();
            requestForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);

            }
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            
            if (occupation=="Admin" || (occupation.Equals("Manager")))
            {
                ServicesManager serviceForm = new ServicesManager();
                this.Hide();
                serviceForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);

            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            String occupation = UserStatusBUS.Instance.getOccupation();
            if (occupation.Equals("Admin") || (occupation.Equals("Manager") || (occupation.Equals("Receptionist") || (occupation.Equals("Engineer")))))
            {
                RoomStatus roomStatusForm = new RoomStatus();
                this.Hide();
                roomStatusForm.Show();
            }
            else
            {
                MessageBox.Show("Access is denied", "Error", MessageBoxButtons.OK);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            ReservationBUS.Instance.update();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text == String.Empty || newPassTextBox.Text == String.Empty || confiTextBox.Text == String.Empty)
            {
                this.Button.ForeColor = System.Drawing.Color.Red;
                this.Button.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Button.Text = "Enter all information!";
            }
            else
            if (UserStatusBUS.Instance.getPass().Equals(oldPassTextBox.Text))
            {
                if (newPassTextBox.Text.Equals(confiTextBox.Text))
                {
                    UserBUS.Instance.changePassword(confiTextBox.Text, UserStatusBUS.Instance.getEID());
                    MessageBox.Show("Change Password Successful!", "Message", MessageBoxButtons.OK);
                    changePanel.Hide();
                }
                else
                {
                    this.Button.ForeColor = System.Drawing.Color.Red;
                    this.Button.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Button.Text = "New password are not correct!";
                }
            }
            else
            {
                this.Button.ForeColor = System.Drawing.Color.Red;
                this.Button.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Button.Text = "Old password are not correct!";
            }
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            changePanel.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            changePanel.Hide();

        }
    }
}

