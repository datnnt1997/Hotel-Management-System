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
    public partial class Compensatory : Form
    {
        public Compensatory()
        {
            InitializeComponent();
            FacilitiesBUS.Instance.displayAll(productDataGridView);
            DateTimePicker.Value = DateTime.Now;
            viewPanel.Hide();
        }
        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void Compensatory_Load(object sender, EventArgs e)
        {
            FacilitiesBUS.Instance.displayAll(productDataGridView);
            IDTextBox.Text = CompensatoryBUS.Instance.getID().ToString();
            DateTimePicker.Value = DateTime.Now;
        }

        private void productDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in productDataGridView.SelectedRows)
            {
                productTextBox.Text = row.Cells[0].Value.ToString();
                priceTextBox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void textBox19_Leave(object sender, EventArgs e)
        {
            float total=float.Parse(priceTextBox.Text)*Int32.Parse(quantityTextBox.Text);
            totablTextBox.Text = total.ToString();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (rentTextBox.Text == String.Empty || totablTextBox.Text == String.Empty || productTextBox.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                CompensatoryDTO com = new CompensatoryDTO(Int32.Parse(IDTextBox.Text), DateTimePicker.Text, Int32.Parse(rentTextBox.Text), roomIDTextBox.Text,
                    Int32.Parse(productTextBox.Text), Int32.Parse(quantityTextBox.Text), float.Parse(priceTextBox.Text), float.Parse(totablTextBox.Text));
                if (CompensatoryBUS.Instance.addproduct(com))
                {
                    MessageBox.Show("Add product Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBox.Text = CompensatoryBUS.Instance.getID().ToString();
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

        private void button13_Click(object sender, EventArgs e)
        {
            rentTextBox.Text= RoomBUS.Instance.getRent(roomIDTextBox.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = CompensatoryBUS.Instance.getID().ToString();
            roomIDTextBox.Clear();
            rentTextBox.Clear();
            productTextBox.Clear();
            quantityTextBox.Clear();
            priceTextBox.Clear();
            totablTextBox.Clear();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            viewPanel.Hide();
            addPanel.Show();
            this.viewPanelLeft.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.createPanelLeft.BackColor = System.Drawing.Color.Khaki;
        }

        private void viewPanelLeft_Click(object sender, EventArgs e)
        {
            viewPanel.Show();
            this.viewPanelLeft.BackColor = System.Drawing.Color.Khaki;
            this.createPanelLeft.BackColor = System.Drawing.Color.PaleGoldenrod;
            CompensatoryBUS.Instance.displayAll(compensatoryTable);
        }
        private String ID = "";
        private void compensatoryTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                compensatoryTable.CurrentCell = compensatoryTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                compensatoryTable.Rows[e.RowIndex].Selected = true;
                compensatoryTable.Focus();
                ID=compensatoryTable.SelectedRows[0].Cells[0].Value.ToString();
               // MessageBox.Show(ID, "error", MessageBoxButtons.OK);

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompensatoryBUS.Instance.deleterequest(Int32.Parse(ID));
            CompensatoryBUS.Instance.displayAll(compensatoryTable);
        }
    }
}
