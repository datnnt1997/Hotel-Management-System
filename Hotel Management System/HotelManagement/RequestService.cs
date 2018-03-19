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
    public partial class RequestService : Form
    {
        public RequestService()
        {
            InitializeComponent();
            ServiceBUS.Instance.displayAll(DataGridView);
            DateTimePicker.Value = DateTime.Now;
            viewPanel.Hide();
        }

        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage HomeForm = new HomePage();
            this.Hide();
            HomeForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = RequestServiceBUS.Instance.getID().ToString();
            roomIDTextBox.Clear();
            rentTextBox.Clear();
            productTextBox.Clear();
            quantityTextBox.Clear();
            priceTextBox.Clear();
            totablTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rentTextBox.Text = RoomBUS.Instance.getRent(roomIDTextBox.Text);
        }

        private void RequestService_Load(object sender, EventArgs e)
        {
            ServiceBUS.Instance.displayAll(DataGridView);
            IDTextBox.Text = RequestServiceBUS.Instance.getID().ToString();
            DateTimePicker.Value = DateTime.Now;
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView.SelectedRows)
            {
                productTextBox.Text = row.Cells[0].Value.ToString();
                priceTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            float total = float.Parse(priceTextBox.Text) * Int32.Parse(quantityTextBox.Text);
            totablTextBox.Text = total.ToString();
        }

        private void quantityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int num = Int32.Parse(quantityTextBox.Text);
                float total = float.Parse(priceTextBox.Text) * Int32.Parse(quantityTextBox.Text);
                quantityTextBox.Text = num.ToString();
                totablTextBox.Text = total.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (rentTextBox.Text == String.Empty || totablTextBox.Text == String.Empty || productTextBox.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                RequestServiceDTO com = new RequestServiceDTO(Int32.Parse(IDTextBox.Text), DateTimePicker.Text, Int32.Parse(rentTextBox.Text), roomIDTextBox.Text,
                    Int32.Parse(productTextBox.Text), Int32.Parse(quantityTextBox.Text), float.Parse(priceTextBox.Text), float.Parse(totablTextBox.Text));
                if (RequestServiceBUS.Instance.addproduct(com))
                {
                    MessageBox.Show("Add product Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBox.Text = RequestServiceBUS.Instance.getID().ToString();
                    roomIDTextBox.Clear();
                    rentTextBox.Clear();
                    productTextBox.Clear();
                    quantityTextBox.Clear();
                    priceTextBox.Clear();
                    totablTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Add product Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void createPanelLeft_Click(object sender, EventArgs e)
        {
            viewPanel.Hide();
            this.viewPanelLeft.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.createPanelLeft.BackColor = System.Drawing.Color.Khaki;
        }

        private void viewPanelLeft_Click(object sender, EventArgs e)
        {
            viewPanel.Show();
            this.viewPanelLeft.BackColor = System.Drawing.Color.Khaki;
            this.createPanelLeft.BackColor = System.Drawing.Color.PaleGoldenrod;
            RequestServiceBUS.Instance.displayAll(requestTable);
        }
        private String ID = "";
        private void requestTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                requestTable.CurrentCell = requestTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                requestTable.Rows[e.RowIndex].Selected = true;
                requestTable.Focus();
                ID = requestTable.SelectedRows[0].Cells[0].Value.ToString();
                // MessageBox.Show(ID, "error", MessageBoxButtons.OK);

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestServiceBUS.Instance.deleteRequest(Int32.Parse(ID));
            RequestServiceBUS.Instance.displayAll(requestTable);
        }
    }
}
