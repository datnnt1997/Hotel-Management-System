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
    public partial class FacilitiesManager : Form
    {
        public FacilitiesManager()
        {
            InitializeComponent();
            IDTextBox.Text = FacilitiesBUS.Instance.getID().ToString();
            FacilitiesBUS.Instance.displayAll(DataGridView);
        }
        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == String.Empty || priceTextBox.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                FacilitiesDTO product = new FacilitiesDTO(Int32.Parse(IDTextBox.Text), nameTextBox.Text, float.Parse(priceTextBox.Text));
                if (FacilitiesBUS.Instance.addproduct(product))
                {
                    MessageBox.Show("Add product Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBox.Text = FacilitiesBUS.Instance.getID().ToString();
                    FacilitiesBUS.Instance.displayAll(DataGridView);
                    nameTextBox.Clear();
                    priceTextBox.Clear();
                   
                }
                else
                {
                    MessageBox.Show("Add product Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = FacilitiesBUS.Instance.getID().ToString();
            FacilitiesBUS.Instance.displayAll(DataGridView);
            nameTextBox.Clear();
            priceTextBox.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == String.Empty || priceTextBox.Text == String.Empty )
            {
                MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                FacilitiesDTO product = new FacilitiesDTO(Int32.Parse(IDTextBox.Text), nameTextBox.Text, float.Parse(priceTextBox.Text));
                if (FacilitiesBUS.Instance.updateproduct(product))
                {
                    MessageBox.Show("Update product Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBox.Text = FacilitiesBUS.Instance.getID().ToString();
                    FacilitiesBUS.Instance.displayAll(DataGridView);
                    nameTextBox.Clear();
                    priceTextBox.Clear();
 
                }
                else
                {
                    MessageBox.Show("Update product Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (FacilitiesBUS.Instance.deleteproduct(Int32.Parse(IDTextBox.Text)))
            {
                MessageBox.Show("Delete product Successful!", "Message", MessageBoxButtons.OK);
                IDTextBox.Text = FacilitiesBUS.Instance.getID().ToString();
                FacilitiesBUS.Instance.displayAll(DataGridView);
                nameTextBox.Clear();
                priceTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Delete product Faile!", "Message", MessageBoxButtons.OK);
            }
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView.SelectedRows)
            {
                IDTextBox.Text = row.Cells[0].Value.ToString();
                nameTextBox.Text = row.Cells[1].Value.ToString();
                priceTextBox.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
