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
    public partial class PromotionManager : Form
    {
        public PromotionManager()
        {
            InitializeComponent();
            vipPanel.Hide();
            proPanel.Show();
            IDTextBoxPromotion.Text = PromotionBUS.Instance.getID().ToString();
            PromotionBUS.Instance.displayAll(tableDataGridViewPromotion);
        }
        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            vipPanel.Hide();
            proPanel.Show();
            IDTextBoxPromotion.Text = PromotionBUS.Instance.getID().ToString();
            PromotionBUS.Instance.displayAll(tableDataGridViewPromotion);
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.backpanelleft.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            vipPanel.Show();
            proPanel.Hide();
            VIPBUS.Instance.displayAll(VIPDataGridView);
            VIPTextBoxLevel.Text = VIPBUS.Instance.getID().ToString();
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.backpanelleft.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nameTextBoxPromotion.Text == String.Empty || valueTextBoxPromotion.Text == String.Empty
               || conditionTextBoxPromotion.Text == String.Empty || timeDateTimePickerPromotion.Text == String.Empty|| descriptionTextBoxPromotion.Text==String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                PromotionDTO promotion = new PromotionDTO(Int32.Parse(IDTextBoxPromotion.Text), nameTextBoxPromotion.Text,Int32.Parse( valueTextBoxPromotion.Text), conditionTextBoxPromotion.Text,
                    timeDateTimePickerPromotion.Text, descriptionTextBoxPromotion.Text);
                if (PromotionBUS.Instance.addPromotion(promotion))
                {
                    MessageBox.Show("Add Promotion Successful!", "Message", MessageBoxButtons.OK);
                    PromotionBUS.Instance.displayAll(tableDataGridViewPromotion);
                    IDTextBoxPromotion.Text = PromotionBUS.Instance.getID().ToString();
                    nameTextBoxPromotion.Clear();
                    valueTextBoxPromotion.Clear();
                    conditionTextBoxPromotion.Clear();
                    timeDateTimePickerPromotion.Text = "";
                    descriptionTextBoxPromotion.Clear();
                }
                else
                {
                    MessageBox.Show("Add Promotion Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void tableDataGridViewPromotion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in tableDataGridViewPromotion.SelectedRows)
            {

                IDTextBoxPromotion.Text = row.Cells[0].Value.ToString();
                nameTextBoxPromotion.Text = row.Cells[1].Value.ToString();
                valueTextBoxPromotion.Text = row.Cells[2].Value.ToString();
                conditionTextBoxPromotion.Text = row.Cells[3].Value.ToString();
                timeDateTimePickerPromotion.Text = row.Cells[4].Value.ToString();
                descriptionTextBoxPromotion.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IDTextBoxPromotion.Text = PromotionBUS.Instance.getID().ToString();
            nameTextBoxPromotion.Clear();
            valueTextBoxPromotion.Clear();
            conditionTextBoxPromotion.Clear();
            timeDateTimePickerPromotion.Text = "";
            descriptionTextBoxPromotion.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nameTextBoxPromotion.Text == String.Empty || valueTextBoxPromotion.Text == String.Empty
               || conditionTextBoxPromotion.Text == String.Empty || timeDateTimePickerPromotion.Text == String.Empty || descriptionTextBoxPromotion.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                PromotionDTO promotion = new PromotionDTO(Int32.Parse(IDTextBoxPromotion.Text), nameTextBoxPromotion.Text, Int32.Parse(valueTextBoxPromotion.Text), conditionTextBoxPromotion.Text,
                    timeDateTimePickerPromotion.Text, descriptionTextBoxPromotion.Text);
                if (PromotionBUS.Instance.updatePromotion(promotion))
                {
                    MessageBox.Show("Update Promotion Successful!", "Message", MessageBoxButtons.OK);
                    PromotionBUS.Instance.displayAll(tableDataGridViewPromotion);
                    IDTextBoxPromotion.Text = PromotionBUS.Instance.getID().ToString();
                    nameTextBoxPromotion.Clear();
                    valueTextBoxPromotion.Clear();
                    conditionTextBoxPromotion.Clear();
                    timeDateTimePickerPromotion.Text = "";
                    descriptionTextBoxPromotion.Clear();
                }
                else
                {
                    MessageBox.Show("Update Promotion Faile!", "Message", MessageBoxButtons.OK);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PromotionBUS.Instance.deletePromotion(Int32.Parse(IDTextBoxPromotion.Text)))
            {
                MessageBox.Show("Delete Promotion Successful!", "Message", MessageBoxButtons.OK);
                PromotionBUS.Instance.displayAll(tableDataGridViewPromotion);
                IDTextBoxPromotion.Text = PromotionBUS.Instance.getID().ToString();
                nameTextBoxPromotion.Clear();
                valueTextBoxPromotion.Clear();
                conditionTextBoxPromotion.Clear();
                timeDateTimePickerPromotion.Text = "";
                descriptionTextBoxPromotion.Clear();
            }
            else
            {
                MessageBox.Show("Delete Room Type Faile!", "Message", MessageBoxButtons.OK);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (valueTextBoxLevel.Text == String.Empty || conditonVIPTextBoxLevel.Text == String.Empty )
            {
                MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                VIPDTO VIP = new VIPDTO(Int32.Parse(VIPTextBoxLevel.Text), Int32.Parse(valueTextBoxLevel.Text), float.Parse(conditonVIPTextBoxLevel.Text));
                if (VIPBUS.Instance.addVIP(VIP))
                {
                    MessageBox.Show("Add VIP Successful!", "Message", MessageBoxButtons.OK);
                    VIPBUS.Instance.displayAll(VIPDataGridView);
                    VIPTextBoxLevel.Text = VIPBUS.Instance.getID().ToString();
                    valueTextBoxLevel.Clear();
                    conditonVIPTextBoxLevel.Clear();
                }
                else
                {
                    MessageBox.Show("Add VIP Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            VIPBUS.Instance.displayAll(VIPDataGridView);
            VIPTextBoxLevel.Text = VIPBUS.Instance.getID().ToString();
            valueTextBoxLevel.Clear();
            conditonVIPTextBoxLevel.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (valueTextBoxLevel.Text == String.Empty || conditonVIPTextBoxLevel.Text == String.Empty)
            {
                MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                VIPDTO VIP = new VIPDTO(Int32.Parse(VIPTextBoxLevel.Text), Int32.Parse(valueTextBoxLevel.Text), float.Parse(conditonVIPTextBoxLevel.Text));
                if (VIPBUS.Instance.updateVIP(VIP))
                {
                    MessageBox.Show("Update VIP Successful!", "Message", MessageBoxButtons.OK);
                    VIPBUS.Instance.displayAll(VIPDataGridView);
                    VIPTextBoxLevel.Text = VIPBUS.Instance.getID().ToString();
                    valueTextBoxLevel.Clear();
                    conditonVIPTextBoxLevel.Clear();
                }
                else
                {
                    MessageBox.Show("Update VIP Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (VIPBUS.Instance.deleteVIP(Int32.Parse(VIPTextBoxLevel.Text)))
            {
                MessageBox.Show("Delete VIP Successful!", "Message", MessageBoxButtons.OK);
                VIPBUS.Instance.displayAll(VIPDataGridView);
                VIPTextBoxLevel.Text = VIPBUS.Instance.getID().ToString();
                valueTextBoxLevel.Clear();
                conditonVIPTextBoxLevel.Clear();
            }
            else
            {
                MessageBox.Show("Delete VIP Faile!", "Message", MessageBoxButtons.OK);
            }
        }

        private void VIPDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in VIPDataGridView.SelectedRows)
            {

                VIPTextBoxLevel.Text = row.Cells[0].Value.ToString();
                valueTextBoxLevel.Text = row.Cells[1].Value.ToString();
                conditonVIPTextBoxLevel.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}

