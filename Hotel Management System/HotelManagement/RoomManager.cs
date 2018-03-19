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
    public partial class RoomManager : Form
    {
        public RoomManager()
        {
            InitializeComponent();
            typePanel.Hide();
            RoomTypeBUS.Instance.getType(roomTypeComboBoxAdd);
 
            RoomBUS.Instance.displayAll(roomDataGridView);
        }
        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void AddPanelLeft_Click(object sender, EventArgs e)
        {
            addpanel.Show();
          
            typePanel.Hide();
            this.AddPanelLeft.BackColor = System.Drawing.Color.DodgerBlue;
         
            this.typepanelleft.BackColor = System.Drawing.Color.DarkBlue;
            this.backpanelleft.BackColor = System.Drawing.Color.DarkBlue;
            RoomTypeBUS.Instance.getType(roomTypeComboBoxAdd);
            RoomBUS.Instance.displayAll(roomDataGridView);

        }

       

        private void panel5_Click(object sender, EventArgs e)
        {
            addpanel.Hide();
        
            typePanel.Show();
            this.AddPanelLeft.BackColor = System.Drawing.Color.DarkBlue;
         
            this.typepanelleft.BackColor = System.Drawing.Color.DodgerBlue;
            this.backpanelleft.BackColor = System.Drawing.Color.DarkBlue;
            RoomTypeBUS.Instance.displayAll(roomtypeDataGridView);
        }

        private void addButtonType_Click(object sender, EventArgs e)
        {
            if (!RoomTypeBUS.Instance.CheckID(roomTypeIDTexBoxType.Text))
            {
                MessageBox.Show("Room Type ID already exists!", "Error", MessageBoxButtons.OK);
                roomTypeIDTexBoxType.Focus();
            }else
            if (roomTypeIDTexBoxType.Text == String.Empty || nameTexBoxType.Text == String.Empty || bedTexBoxType.Text == String.Empty || priceTexBoxType.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RoomTypeDTO roomType = new RoomTypeDTO(roomTypeIDTexBoxType.Text, nameTexBoxType.Text, Int32.Parse(bedTexBoxType.Text), float.Parse(priceTexBoxType.Text),
                    descriptionTexBoxType.Text);
                if (RoomTypeBUS.Instance.addRoomType(roomType))
                {
                    MessageBox.Show("Add Room Type Successful!", "Message", MessageBoxButtons.OK);
                    RoomTypeBUS.Instance.displayAll(roomtypeDataGridView);
                    roomTypeIDTexBoxType.Clear();
                    nameTexBoxType.Clear();
                    bedTexBoxType.Clear();
                    priceTexBoxType.Clear();
                    descriptionTexBoxType.Clear();
                    roomTypeIDTexBoxType.Focus();
                }
                else
                {
                    MessageBox.Show("Add Room Type Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }
   private void updateButtonType_Click(object sender, EventArgs e)
        {
            RoomTypeDTO roomType = new RoomTypeDTO(roomTypeIDTexBoxType.Text, nameTexBoxType.Text, Int32.Parse(bedTexBoxType.Text), float.Parse(priceTexBoxType.Text),
                descriptionTexBoxType.Text);
            if (RoomTypeBUS.Instance.updateRoomType(roomType))
            {
                MessageBox.Show("Update Room Type Successful!", "Message", MessageBoxButtons.OK);
                RoomTypeBUS.Instance.displayAll(roomtypeDataGridView);
                roomTypeIDTexBoxType.Clear();
                nameTexBoxType.Clear();
                bedTexBoxType.Clear();
                priceTexBoxType.Clear();
                descriptionTexBoxType.Clear();
                roomTypeIDTexBoxType.Focus();

            }
            else
            {
                MessageBox.Show("Update Customer Faile!", "Message", MessageBoxButtons.OK);
            }

        }

        private void roomtypeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in roomtypeDataGridView.SelectedRows)
            {
               
                roomTypeIDTexBoxType.Text= row.Cells[0].Value.ToString();
                nameTexBoxType.Text = row.Cells[1].Value.ToString();
                bedTexBoxType.Text = row.Cells[2].Value.ToString();
                priceTexBoxType.Text = row.Cells[3].Value.ToString();
                descriptionTexBoxType.Text = row.Cells[4].Value.ToString();
            }
        }

        private void DeleteuttonType_Click(object sender, EventArgs e)
        {
            RoomBUS.Instance.updateOccupation(roomTypeIDTexBoxType.Text);
            if (RoomTypeBUS.Instance.deleteRoomType(roomTypeIDTexBoxType.Text))
            {
                MessageBox.Show("Delete Room Type Successful!", "Message", MessageBoxButtons.OK);
                RoomTypeBUS.Instance.displayAll(roomtypeDataGridView);
                roomTypeIDTexBoxType.Clear();
                nameTexBoxType.Clear();
                bedTexBoxType.Clear();
                priceTexBoxType.Clear();
                descriptionTexBoxType.Clear();
                roomTypeIDTexBoxType.Focus();
            }
            else
            {
                MessageBox.Show("Delete Room Type Faile!", "Message", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!RoomBUS.Instance.CheckID(roomIDTextBoxAdd.Text))
            {
                MessageBox.Show("Room ID already exists!", "Error", MessageBoxButtons.OK);
                roomIDTextBoxAdd.Focus();
            }else

            if (roomIDTextBoxAdd.Text == String.Empty || locationTextBoxAdd.Text == String.Empty || roomTypeComboBoxAdd.Text == String.Empty || StatusComboBoxAdd.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RoomDTO newRoom = new RoomDTO(roomIDTextBoxAdd.Text, "", locationTextBoxAdd.Text,roomTypeComboBoxAdd.Text, StatusComboBoxAdd.Text);
               if( RoomBUS.Instance.addRoom(newRoom))
                {
                    MessageBox.Show("Add Room Successful!", "Message", MessageBoxButtons.OK);
                    RoomBUS.Instance.displayAll(roomDataGridView);
                    roomIDTextBoxAdd.Clear();
                    locationTextBoxAdd.Clear();
                    StatusComboBoxAdd.Text = "";
                    roomTypeComboBoxAdd.Text = "";
                    RoomBUS.Instance.displayAll(roomDataGridView);
                }
                else
                {
                    MessageBox.Show("Add Room Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            if (roomIDTextBoxAdd.Text == String.Empty || locationTextBoxAdd.Text == String.Empty || roomTypeComboBoxAdd.Text == String.Empty || StatusComboBoxAdd.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RoomDTO newRoom = new RoomDTO(roomIDTextBoxAdd.Text, "", locationTextBoxAdd.Text, roomTypeComboBoxAdd.Text, StatusComboBoxAdd.Text);
                List<RoomFacilitiesDTO> facilities = new List<RoomFacilitiesDTO>();
 
                if (RoomBUS.Instance.addRoom(newRoom))
                {
                    MessageBox.Show("Update Room Successful!", "Message", MessageBoxButtons.OK);
                    roomIDTextBoxAdd.Clear();
                    locationTextBoxAdd.Clear();
                    StatusComboBoxAdd.Text = "";
                    roomTypeComboBoxAdd.Text = "";
                    RoomBUS.Instance.displayAll(roomDataGridView);
                }
                else
                {
                    MessageBox.Show("Update Room Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            roomIDTextBoxAdd.Clear();
            locationTextBoxAdd.Clear();
            StatusComboBoxAdd.Text = "";
            roomTypeComboBoxAdd.Text = "";
            RoomBUS.Instance.displayAll(roomDataGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roomIDTextBoxAdd.Text == String.Empty || locationTextBoxAdd.Text == String.Empty || roomTypeComboBoxAdd.Text == String.Empty || StatusComboBoxAdd.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RoomDTO newRoom = new RoomDTO(roomIDTextBoxAdd.Text, "", locationTextBoxAdd.Text, roomTypeComboBoxAdd.Text, StatusComboBoxAdd.Text);
 

                if (RoomBUS.Instance.updateRoom(newRoom))
                {
                    MessageBox.Show("Update Room Successful!", "Message", MessageBoxButtons.OK);
                    roomIDTextBoxAdd.Clear();
                    locationTextBoxAdd.Clear();
                    StatusComboBoxAdd.Text = "";
                    roomTypeComboBoxAdd.Text = "";
                    RoomBUS.Instance.displayAll(roomDataGridView);
                }
                else
                {
                    MessageBox.Show("Update Room Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (roomIDTextBoxAdd.Text == String.Empty || locationTextBoxAdd.Text == String.Empty || roomTypeComboBoxAdd.Text == String.Empty || StatusComboBoxAdd.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RoomDTO newRoom = new RoomDTO(roomIDTextBoxAdd.Text, "", locationTextBoxAdd.Text, roomTypeComboBoxAdd.Text, StatusComboBoxAdd.Text);
  

                if (RoomBUS.Instance.deleteRoom(newRoom.RID1))
                {
                    MessageBox.Show("Delete Room Successful!", "Message", MessageBoxButtons.OK);
                    roomIDTextBoxAdd.Clear();
                    locationTextBoxAdd.Clear();
                    StatusComboBoxAdd.Text = "";
                    roomTypeComboBoxAdd.Text = "";
                    RoomBUS.Instance.displayAll(roomDataGridView);
                }
                else
                {
                    MessageBox.Show("Delete Room Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void roomDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in roomDataGridView.SelectedRows)
            {
                roomIDTextBoxAdd.Text = row.Cells[0].Value.ToString();
                
                locationTextBoxAdd.Text = row.Cells[2].Value.ToString();
                roomTypeComboBoxAdd.Text = row.Cells[3].Value.ToString();
                StatusComboBoxAdd.Text = row.Cells[4].Value.ToString();
            }
        }

        private void roomTypeIDTexBoxType_Leave(object sender, EventArgs e)
        {
            
        }

        private void roomIDTextBoxAdd_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
