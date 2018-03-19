using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTranferObject;
using Business_Logic_Layer;

namespace HotelManagement
{
    public partial class ReservationManager : Form
    {
        public ReservationManager()
        {
            InitializeComponent();
            createPanel.Show();
            updatePanel.Hide();
            viewPanel.Hide();
            RoomTypeBUS.Instance.getType(TypeComboBoxCreate);
            reserIDTextBoxCreate.Text = ReservationBUS.Instance.getID().ToString();
            EIDTextBoxCreat.Text = UserStatusBUS.Instance.getEID().ToString();
            billPanel.Hide();
        }
        private void creatPanelLeft_Click(object sender, EventArgs e)
        {
            this.creatPanelLeft.BackColor = System.Drawing.Color.Gold;
            this.updatePanelLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.viewPanelLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            createPanel.Show();
            updatePanel.Hide();
            viewPanel.Hide();
            RoomTypeBUS.Instance.getType(TypeComboBoxCreate);
            reserIDTextBoxCreate.Text = ReservationBUS.Instance.getID().ToString();

        }
        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void updatePanelLeft_Click(object sender, EventArgs e)
        {
            this.creatPanelLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.updatePanelLeft.BackColor = System.Drawing.Color.Gold;
            this.viewPanelLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            createPanel.Hide();
            updatePanel.Show();
            viewPanel.Hide();
            billPanel.Hide();
            /// clear
            checkInTextBoxupdate.Clear();
            rentIDTextBoxupdate.Clear();
            roomIDTextBoxCreate.Clear();
            checkOutTextBoxupdate.Clear();
            statusComboBoxUpdate.Text = "";
            roomIDTextBoxupdate.Clear();
            EIDTextBoxupdate.Clear();
            roomTypeTextBoxupdate.Clear();
            CIDTextBoxupdate.Clear();
            passportTextBoxupdate.Clear();
            fNameTextBoxupdate.Clear();
            lNameTextBoxupdate.Clear();
            birthdayTextBoxupdate.Clear();
            sexTextBoxupdate.Clear();
            phoneTextBoxUpdate.Clear();
            emailTextBoxupdate.Clear();
            addressTextBoxupdate.Clear();
        }

        private void viewPanelLeft_Click(object sender, EventArgs e)
        {
            this.creatPanelLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.updatePanelLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.viewPanelLeft.BackColor = System.Drawing.Color.Gold;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            createPanel.Hide();
            updatePanel.Hide();
            viewPanel.Show();
            ReservationBUS.Instance.displayAll(reservationDataGridView);
            ReservationBUS.Instance.update();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TypeComboBoxCreate.Text == String.Empty)
            {
                MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK);
            }
            else if(DateTime.Parse(checkinDateTimePickerCreate.Value.ToShortDateString()) > DateTime.Parse(checkOutDateTimePickerCreate.Value.ToShortDateString()))
            {
                  MessageBox.Show("CheckIn > CheckOut", "Error", MessageBoxButtons.OK);
            }
            else if (DateTime.Parse(checkinDateTimePickerCreate.Value.ToShortDateString()) < DateTime.Parse(DateTime.Now.ToShortDateString()))
            {
                MessageBox.Show("CheckIn < Now", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RoomDTO room = RoomBUS.Instance.getRoom(TypeComboBoxCreate.Text, checkinDateTimePickerCreate.Text, checkOutDateTimePickerCreate.Text);
                if(room == null)
                {
                    MessageBox.Show("Don't Have Room", "Error", MessageBoxButtons.OK);
                    roomIDTextBoxCreate.Clear();
                }
                else
                {
                    roomIDTextBoxCreate.Text = room.RID1.ToString();
                }
            }

        }
        // them khach hang moi 
        private void button2_Click(object sender, EventArgs e)
        {
            if (CIDTextBoxCreate.Text == String.Empty || passportIDTextBoxCreate.Text == String.Empty || fNameTextBoxCreate.Text == String.Empty || lNameTextBoxCreate.Text == String.Empty 
                || brithDayDateTimePickerCreate.Text == String.Empty || sexComboBoxCreate.Text == String.Empty || phoneTextBoxCreate.Text == String.Empty 
                || emailTextBoxCreate.Text == String.Empty || addressTextBoxCreate.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                String cusID= "C" + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
                CustomerDTO cusNewCustomer = new CustomerDTO(cusID, passportIDTextBoxCreate.Text, fNameTextBoxCreate.Text, lNameTextBoxCreate.Text, brithDayDateTimePickerCreate.Text,
                                                  sexComboBoxCreate.Text, phoneTextBoxCreate.Text, emailTextBoxCreate.Text, addressTextBoxCreate.Text, 0, 0);
                if (CustomerBUS.Instance.insertCustomer(cusNewCustomer))
                {
                    MessageBox.Show("Add Customer Successful!", "Message", MessageBoxButtons.OK);
                    CIDTextBoxCreate.Clear();
                    passportIDTextBoxCreate.Clear();
                    fNameTextBoxCreate.Clear();
                    lNameTextBoxCreate.Clear();
                    brithDayDateTimePickerCreate.Value = DateTime.Now;
                    sexComboBoxCreate.SelectedItem = "";
                    phoneTextBoxCreate.Clear();
                    emailTextBoxCreate.Clear();
                    addressTextBoxCreate.Clear();
                }
                else
                {
                    MessageBox.Show("Add Customer Faile!", "Message", MessageBoxButtons.OK);
                }
            }

        }

        private void CIDTextBoxCreate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CIDTextBoxCreate.Text == String.Empty && passportIDTextBoxCreate.Text == String.Empty)
                {

                }
                else
                {
                    CustomerDTO customer = CustomerBUS.Instance.searchCustomer(CIDTextBoxCreate.Text, passportIDTextBoxCreate.Text);
                    if (customer != null)
                    {
                        CIDTextBoxCreate.Text = customer.CID;
                        passportIDTextBoxCreate.Text = customer.PassportID;
                        fNameTextBoxCreate.Text = customer.FirstName;
                        lNameTextBoxCreate.Text = customer.LastName;
                        brithDayDateTimePickerCreate.Text = customer.Birthday;
                        sexComboBoxCreate.Text = customer.Sex;
                        phoneTextBoxCreate.Text = customer.Phone;
                        emailTextBoxCreate.Text = customer.Email;
                        addressTextBoxCreate.Text = customer.Address;
                    }
                    else
                    {

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CIDTextBoxCreate.Text == String.Empty || roomIDTextBoxCreate.Text == String.Empty || checkinDateTimePickerCreate.Text == String.Empty || checkOutDateTimePickerCreate.Text == String.Empty
               || emailTextBoxCreate.Text == String.Empty || addressTextBoxCreate.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ReservationDTO reservation = new ReservationDTO(Int32.Parse(reserIDTextBoxCreate.Text),CIDTextBoxCreate.Text, Int32.Parse(EIDTextBoxCreat.Text),roomIDTextBoxCreate.Text, checkinDateTimePickerCreate.Text, checkOutDateTimePickerCreate.Text, comboBox6.Text);
                if (ReservationBUS.Instance.addReservation(reservation))
                {
                    MessageBox.Show("Add Reservation Successful!", "Message", MessageBoxButtons.OK);
                    if (comboBox6.Text == "CheckIn")
                    {
                        RoomBUS.Instance.updateRent(Int32.Parse(reserIDTextBoxCreate.Text), roomIDTextBoxCreate.Text);
                    }
                    CIDTextBoxCreate.Clear();
                    passportIDTextBoxCreate.Clear();
                    fNameTextBoxCreate.Clear();
                    lNameTextBoxCreate.Clear();
                    brithDayDateTimePickerCreate.Value = DateTime.Now;
                    sexComboBoxCreate.SelectedItem = "";
                    phoneTextBoxCreate.Clear();
                    emailTextBoxCreate.Clear();
                    addressTextBoxCreate.Clear();
                    TypeComboBoxCreate.Text = "";
                    roomIDTextBoxCreate.Clear();
                    comboBox6.Text = "";
                    reserIDTextBoxCreate.Text = ReservationBUS.Instance.getID().ToString();
                }
                else
                {
                    MessageBox.Show("Add Reservation Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rentIDTextBoxupdate.Text == String.Empty && roomIDTextBoxupdate.Text == String.Empty)
            {
                MessageBox.Show("Please provide information to search!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ReservationDTO reservation = ReservationBUS.Instance.searchReservation(rentIDTextBoxupdate.Text, roomIDTextBoxupdate.Text);
                if (reservation != null)
                {
                    checkInTextBoxupdate.Text = reservation.CheckIn;
                    rentIDTextBoxupdate.Text = reservation.ReserID.ToString();
                    roomIDTextBoxCreate.Text = reservation.RID.ToString();
                    checkOutTextBoxupdate.Text = reservation.CheckOut;
                    statusComboBoxUpdate.Text = reservation.Status;
                    roomIDTextBoxupdate.Text = reservation.RID;
                    EIDTextBoxupdate.Text = UserStatusBUS.Instance.getEID().ToString();
                    roomTypeTextBoxupdate.Text = RoomBUS.Instance.getType(reservation.RID.ToString());
                    CustomerDTO customer = CustomerBUS.Instance.searchCustomer(reservation.CID,"");
                    CIDTextBoxupdate.Text = customer.CID;
                    passportTextBoxupdate.Text = customer.PassportID;
                    fNameTextBoxupdate.Text = customer.FirstName;
                    lNameTextBoxupdate.Text = customer.LastName;
                    birthdayTextBoxupdate.Text = customer.Birthday;
                    sexTextBoxupdate.Text= customer.Sex; 
                     phoneTextBoxUpdate.Text = customer.Phone;
                    emailTextBoxupdate.Text = customer.Email;
                     addressTextBoxupdate.Text = customer.Address;
                    }
                else
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rentIDTextBoxupdate.Text == String.Empty || roomIDTextBoxupdate.Text == String.Empty || checkInTextBoxupdate.Text == String.Empty || checkOutTextBoxupdate.Text == String.Empty
               || emailTextBoxupdate.Text == String.Empty || addressTextBoxupdate.Text == String.Empty|| statusComboBoxUpdate.Text==String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ReservationDTO reservation = new ReservationDTO(Int32.Parse(rentIDTextBoxupdate.Text), CIDTextBoxupdate.Text, Int32.Parse(EIDTextBoxupdate.Text), roomIDTextBoxupdate.Text, checkInTextBoxupdate.Text, checkInTextBoxupdate.Text, statusComboBoxUpdate.Text);
                if (ReservationBUS.Instance.updateReservation(reservation))
                {
                    if(statusComboBoxUpdate.Text=="CheckIn")
                    {
                        RoomBUS.Instance.updateRent(Int32.Parse(rentIDTextBoxupdate.Text), roomIDTextBoxupdate.Text);
                    }
                    MessageBox.Show("Update Reservation Successful!", "Message", MessageBoxButtons.OK);
                    /// clear
                    checkInTextBoxupdate.Clear();
                    rentIDTextBoxupdate.Clear();
                    roomIDTextBoxCreate.Clear();
                    checkOutTextBoxupdate.Clear();
                    statusComboBoxUpdate.Text = "";
                    roomIDTextBoxupdate.Clear();
                    EIDTextBoxupdate.Clear();
                    roomTypeTextBoxupdate.Clear();
                    CIDTextBoxupdate.Clear();
                    passportTextBoxupdate.Clear();
                    fNameTextBoxupdate.Clear();
                    lNameTextBoxupdate.Clear();
                    birthdayTextBoxupdate.Clear();
                    sexTextBoxupdate.Clear();
                    phoneTextBoxUpdate.Clear();
                    emailTextBoxupdate.Clear();
                    addressTextBoxupdate.Clear();
                }
                else
                {
                    MessageBox.Show("Add Reservation Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

     

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            billPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            billPanel.Show();
            billIDTextBox.Text = BillBUS.Instance.getID().ToString();
            RentIDTextBox.Text = rentIDTextBoxupdate.Text;
            EIDTextBox.Text = EIDTextBoxupdate.Text;
            roomTextBox.Text = roomIDTextBoxupdate.Text;
            CIDTextBox.Text = CIDTextBoxupdate.Text;
            nameTextBox.Text = lNameTextBoxupdate.Text;
            passTextBox.Text = passportTextBoxupdate.Text;
            phoneTextBox.Text = phoneTextBoxUpdate.Text;
            emailTextBox.Text = emailTextBoxupdate.Text;
            addressTextBox.Text = addressTextBoxupdate.Text;
            checkInTextBox.Text = checkInTextBoxupdate.Text;
            checkOutTextBox.Text = DateTime.Now.ToString();
            PromotionBUS.Instance.displayAll(tableDataGridViewPromotion);
            CustomerDTO customer = CustomerBUS.Instance.searchCustomer(CIDTextBox.Text, "");
            VIPTextBox.Text = customer.VIP.ToString();
            valueTextBox.Text = VIPBUS.Instance.getValue(customer.VIP).ToString();
            promotionTextBox.Text = "0";
            int date = 0;
            System.TimeSpan diff2 = DateTime.Now - DateTime.Parse(checkInTextBoxupdate.Text);
            if (diff2.Days==0)
            {
                date = diff2.Days + 1;
            }
            else
            {
                date = diff2.Days;
            }

            float price = RoomTypeBUS.Instance.getPrice(roomTypeTextBoxupdate.Text) * date * (1-(float.Parse(valueTextBox.Text) / 100));
          
            rentPriceTextBox.Text = price.ToString();
            float productPrice=BillDetailBUS.Instance.getBill(billDataGridView,Int32.Parse(RentIDTextBox.Text));
            totalTextBox.Text = (price + productPrice).ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillDTO bill = new BillDTO(Int32.Parse(billIDTextBox.Text), Int32.Parse(RentIDTextBox.Text));
            BillBUS.Instance.addbill(bill);
            foreach (DataGridViewRow row in billDataGridView.Rows)
            {
                BillDetailDTO billdetail = new BillDetailDTO(BillDetailBUS.Instance.getID(), Int32.Parse(billIDTextBox.Text), Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(),
                    Int32.Parse(row.Cells[2].Value.ToString()), float.Parse(row.Cells[4].Value.ToString()));

                BillDetailBUS.Instance.addbill(billdetail);
                
            }
           
            CompensatoryBUS.Instance.deleteproduct(Int32.Parse(RentIDTextBox.Text));
            RequestServiceBUS.Instance.deleteproduct(Int32.Parse(RentIDTextBox.Text));
            ReservationDTO reservation = new ReservationDTO(Int32.Parse(rentIDTextBoxupdate.Text), CIDTextBoxupdate.Text, Int32.Parse(EIDTextBoxupdate.Text), roomIDTextBoxupdate.Text, checkInTextBoxupdate.Text, checkInTextBoxupdate.Text, "CheckOut");
            ReservationBUS.Instance.updateReservation(reservation);
            float money = CustomerBUS.Instance.getMoney(CIDTextBoxupdate.Text);
            money += float.Parse(totalTextBox.Text);
            CustomerBUS.Instance.updateMoney(CIDTextBoxupdate.Text, VIPBUS.Instance.checkVIP(money), money);
            checkInTextBoxupdate.Clear();
            rentIDTextBoxupdate.Clear();
            roomIDTextBoxCreate.Clear();
            checkOutTextBoxupdate.Clear();
            statusComboBoxUpdate.Text = "";
            roomIDTextBoxupdate.Clear();
            EIDTextBoxupdate.Clear();
            roomTypeTextBoxupdate.Clear();
            CIDTextBoxupdate.Clear();
            passportTextBoxupdate.Clear();
            fNameTextBoxupdate.Clear();
            lNameTextBoxupdate.Clear();
            birthdayTextBoxupdate.Clear();
            sexTextBoxupdate.Clear();
            phoneTextBoxUpdate.Clear();
            emailTextBoxupdate.Clear();
            addressTextBoxupdate.Clear();
            
            MessageBox.Show("Payment Successfull!", "Message", MessageBoxButtons.OK);
            billPanel.Hide();

        }

        private void promotionTextBox_Leave(object sender, EventArgs e)
        {
            int date = 0;
            System.TimeSpan diff2 = DateTime.Now - DateTime.Parse(checkInTextBoxupdate.Text);
            if (diff2.Days == 0)
            {
                date = diff2.Days + 1;
            }
            else
            {
                date = diff2.Days;
            }
            rentPriceTextBox.Text = (((1 - (float.Parse(promotionTextBox.Text) / 100)) * (RoomTypeBUS.Instance.getPrice(roomTypeTextBoxupdate.Text) * date * (1 - (float.Parse(valueTextBox.Text) / 100))))).ToString();
            float productPrice = BillDetailBUS.Instance.getBill(billDataGridView, Int32.Parse(RentIDTextBox.Text));
            totalTextBox.Text = (float.Parse(rentPriceTextBox.Text) + productPrice).ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = CustomerBUS.Instance.searchCustomer("", searchPasspordTextBox.Text);
            if (customer == null)
            {
                MessageBox.Show("Customer doesn't exit", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ReservationBUS.Instance.displaySearch(reservationDataGridView, customer.CID);
            }
        }

        private void searchPasspordTextBox_Leave(object sender, EventArgs e)
        {
            ReservationBUS.Instance.displayAll(reservationDataGridView);
        }

        private void reservationDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String rentID="";
            foreach (DataGridViewRow row in reservationDataGridView.SelectedRows)
            {
                rentID = row.Cells[0].Value.ToString();
            }
            ReservationDTO reservation = ReservationBUS.Instance.searchReservation(rentID,"");
            if (reservation != null)
            {
                checkInTextBoxupdate.Text = reservation.CheckIn;
                rentIDTextBoxupdate.Text = reservation.ReserID.ToString();
                roomIDTextBoxCreate.Text = reservation.RID.ToString();
                checkOutTextBoxupdate.Text = reservation.CheckOut;
                statusComboBoxUpdate.Text = reservation.Status;
                roomIDTextBoxupdate.Text = reservation.RID;
                EIDTextBoxupdate.Text = UserStatusBUS.Instance.getEID().ToString();
                roomTypeTextBoxupdate.Text = RoomBUS.Instance.getType(reservation.RID.ToString());
                CustomerDTO customer = CustomerBUS.Instance.searchCustomer(reservation.CID, "");
                CIDTextBoxupdate.Text = customer.CID;
                passportTextBoxupdate.Text = customer.PassportID;
                fNameTextBoxupdate.Text = customer.FirstName;
                lNameTextBoxupdate.Text = customer.LastName;
                birthdayTextBoxupdate.Text = customer.Birthday;
                sexTextBoxupdate.Text = customer.Sex;
                phoneTextBoxUpdate.Text = customer.Phone;
                emailTextBoxupdate.Text = customer.Email;
                addressTextBoxupdate.Text = customer.Address;
            }
            viewPanel.Hide();
            updatePanel.Show();
            this.creatPanelLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.updatePanelLeft.BackColor = System.Drawing.Color.Gold;
            this.viewPanelLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
        }
    }
}

