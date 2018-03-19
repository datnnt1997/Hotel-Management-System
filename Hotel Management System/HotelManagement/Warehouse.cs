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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
            IDTextBox.Text = WarehouseBUS.Instance.getID().ToString();
           WarehouseBUS.Instance.displayAll(warehouseDataGridView);
        }
        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == String.Empty || priceTextBox.Text == String.Empty || quantityTextBox.Text ==String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                WarehouseDTO product = new WarehouseDTO(Int32.Parse(IDTextBox.Text), nameTextBox.Text, float.Parse(priceTextBox.Text), Int32.Parse(quantityTextBox.Text));
                if (WarehouseBUS.Instance.addproduct(product))
                {
                    MessageBox.Show("Add product Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBox.Text = WarehouseBUS.Instance.getID().ToString();
                    WarehouseBUS.Instance.displayAll(warehouseDataGridView);
                    nameTextBox.Clear();
                    priceTextBox.Clear();
                    quantityTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Add product Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = WarehouseBUS.Instance.getID().ToString();
            WarehouseBUS.Instance.displayAll(warehouseDataGridView);
            nameTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == String.Empty || priceTextBox.Text == String.Empty || quantityTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                WarehouseDTO product = new WarehouseDTO(Int32.Parse(IDTextBox.Text), nameTextBox.Text, float.Parse(priceTextBox.Text), Int32.Parse(quantityTextBox.Text));
                if (WarehouseBUS.Instance.updateproduct(product))
                {
                    MessageBox.Show("Update product Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBox.Text = WarehouseBUS.Instance.getID().ToString();
                    WarehouseBUS.Instance.displayAll(warehouseDataGridView);
                    nameTextBox.Clear();
                    priceTextBox.Clear();
                    quantityTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Update product Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (WarehouseBUS.Instance.deleteproduct(Int32.Parse(IDTextBox.Text)))
            {
                MessageBox.Show("Delete product Successful!", "Message", MessageBoxButtons.OK);
                IDTextBox.Text = WarehouseBUS.Instance.getID().ToString();
                WarehouseBUS.Instance.displayAll(warehouseDataGridView);
                nameTextBox.Clear();
                priceTextBox.Clear();
                quantityTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Delete product Faile!", "Message", MessageBoxButtons.OK);
            }
        }

        private void warehouseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in warehouseDataGridView.SelectedRows)
            {
                IDTextBox.Text = row.Cells[0].Value.ToString();
                nameTextBox.Text = row.Cells[1].Value.ToString();
                priceTextBox.Text = row.Cells[2].Value.ToString();
                quantityTextBox.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}