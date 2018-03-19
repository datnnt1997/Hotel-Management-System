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
    public partial class ServicesManager : Form
    {
        public ServicesManager()
        {
            InitializeComponent();
            updatePanel.Hide();
     
            viewPanel.Hide();
            typePanel.Hide();
            addpanel.Show();
            ServiceCategoryBUS.Instance.getType(typeComboBoxAdd);
            IDTextBoxAdd.Text = ServiceBUS.Instance.getID().ToString();
        }

        private void addpanelleft_Click(object sender, EventArgs e)
        {
            updatePanel.Hide();

            viewPanel.Hide();
            typePanel.Hide();
            addpanel.Show();
            this.addpanelleft.BackColor = System.Drawing.Color.LimeGreen;
            this.viewpanelleft.BackColor = System.Drawing.Color.Green;
            this.updatepanelleft.BackColor = System.Drawing.Color.Green;
      
            this.searchpanelleft.BackColor = System.Drawing.Color.Green;
            this.backpanelleft.BackColor = System.Drawing.Color.Green;
            ServiceCategoryBUS.Instance.getType(typeComboBoxAdd);
            IDTextBoxAdd.Text = ServiceBUS.Instance.getID().ToString();
        }

       

        private void updatepanelleft_Click(object sender, EventArgs e)
        {
            updatePanel.Show();
    
            typePanel.Hide();
            viewPanel.Hide();
            addpanel.Hide();
            this.addpanelleft.BackColor = System.Drawing.Color.Green;
            this.updatepanelleft.BackColor = System.Drawing.Color.LimeGreen;
            this.viewpanelleft.BackColor = System.Drawing.Color.Green;
            this.searchpanelleft.BackColor = System.Drawing.Color.Green;
            this.backpanelleft.BackColor = System.Drawing.Color.Green;
            ServiceCategoryBUS.Instance.getType(typeIDComboBoxUpdate);
        }

        private void searchpanelleft_Click(object sender, EventArgs e)
        {
            updatePanel.Hide();
       
            typePanel.Show();
            addpanel.Hide();
            viewPanel.Hide();
            this.addpanelleft.BackColor = System.Drawing.Color.Green;
            this.updatepanelleft.BackColor = System.Drawing.Color.Green;
   
            this.viewpanelleft.BackColor = System.Drawing.Color.Green;
            this.searchpanelleft.BackColor = System.Drawing.Color.LimeGreen;
            this.backpanelleft.BackColor = System.Drawing.Color.Green;
            IDTextBoxtype.Text = ServiceCategoryBUS.Instance.getID().ToString();
            ServiceCategoryBUS.Instance.displayAll(typeDataGridView);
        }

        private void viewpanelleft_Click(object sender, EventArgs e)
        {
            updatePanel.Hide();
       
            typePanel.Hide();
            addpanel.Hide();
            viewPanel.Show();
            this.addpanelleft.BackColor = System.Drawing.Color.Green;
            this.updatepanelleft.BackColor = System.Drawing.Color.Green;
       
            this.viewpanelleft.BackColor = System.Drawing.Color.LimeGreen;
            this.searchpanelleft.BackColor = System.Drawing.Color.Green;
            this.backpanelleft.BackColor = System.Drawing.Color.Green;
            ServiceBUS.Instance.displayAll(serviceTable);
        }

        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }
        /*
         * 
         * Xử lý Service Category
         * 
         */
        /// <summary>
        ///  Thêm type mới
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBoxType.Text == String.Empty || statusComboBoxType.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ServiceCategoryDTO type = new ServiceCategoryDTO(Int32.Parse(IDTextBoxtype.Text), nameTextBoxType.Text, statusComboBoxType.Text);
                if(ServiceCategoryBUS.Instance.addType(type))
                {
                    MessageBox.Show("Add Type Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBoxtype.Text = ServiceCategoryBUS.Instance.getID().ToString();
                    ServiceCategoryBUS.Instance.displayAll(typeDataGridView);
                    nameTextBoxType.Clear();
                    statusComboBoxType.Text = "";
                }
                else
                {
                    MessageBox.Show("Add Type Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }
        /// <summary>
        ///  Xóa các dữ liệu đã nhập
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            IDTextBoxtype.Text = ServiceCategoryBUS.Instance.getID().ToString();
            ServiceCategoryBUS.Instance.displayAll(typeDataGridView);
            nameTextBoxType.Clear();
            statusComboBoxType.Text = "";
        }
        /// <summary>
        ///  Cập nhật lại type đã tồn tại
        /// </summary>
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameTextBoxType.Text == String.Empty || statusComboBoxType.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ServiceCategoryDTO type = new ServiceCategoryDTO(Int32.Parse(IDTextBoxtype.Text), nameTextBoxType.Text, statusComboBoxType.Text);
                if (ServiceCategoryBUS.Instance.updateType(type))
                {
                    MessageBox.Show("Add Update Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBoxtype.Text = ServiceCategoryBUS.Instance.getID().ToString();
                    ServiceCategoryBUS.Instance.displayAll(typeDataGridView);
                    nameTextBoxType.Clear();
                    statusComboBoxType.Text = "";
                }
                else
                {
                    MessageBox.Show("Add Update Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }
        /// <summary>
        ///  Xóa type đã tồn tại
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ServiceCategoryBUS.Instance.deleteType(Int32.Parse(IDTextBoxtype.Text)))
            {
                MessageBox.Show("Delete Type Successful!", "Message", MessageBoxButtons.OK);
                IDTextBoxtype.Text = ServiceCategoryBUS.Instance.getID().ToString();
                ServiceCategoryBUS.Instance.displayAll(typeDataGridView);
                nameTextBoxType.Clear();
                statusComboBoxType.Text = "";
            }
            else
            {
                MessageBox.Show("Delete Type Faile!", "Message", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        ///  Hiển thị thông tin type đã chọn
        /// </summary>
        private void typeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in typeDataGridView.SelectedRows)
            {
                IDTextBoxtype.Text = row.Cells[0].Value.ToString();
                nameTextBoxType.Text = row.Cells[1].Value.ToString();
                statusComboBoxType.Text = row.Cells[2].Value.ToString();
            }
        }
        /*
        * 
        * Xử lý Service
        * 
        */
        /// <summary>
        ///  Thêm service mới
        /// </summary>
        private void addButtonService_Click(object sender, EventArgs e)
        {
            if (nameTextBoxAdd.Text == String.Empty || typeComboBoxAdd.Text == String.Empty|| descriptionTextBoxAdd.Text == String.Empty || priceTextBoxAdd.Text == String.Empty
                || statusComboBoxAdd.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ServiceDTO service = new ServiceDTO(Int32.Parse(IDTextBoxAdd.Text), nameTextBoxAdd.Text, ServiceCategoryBUS.Instance.getTypeID(typeComboBoxAdd.Text.ToString()),descriptionTextBoxAdd.Text
                    ,float.Parse(priceTextBoxAdd.Text.ToString()),statusComboBoxAdd.Text);
                if (ServiceBUS.Instance.addService(service))
                {
                    MessageBox.Show("Add Service Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBoxAdd.Text = ServiceBUS.Instance.getID().ToString();
                    nameTextBoxAdd.Clear();
                    statusComboBoxType.Text = "";
                    descriptionTextBoxAdd.Clear();
                    priceTextBoxAdd.Clear();
                    typeComboBoxAdd.Text = "";

                }
                else
                {
                    MessageBox.Show("Add Type Faile!", "Message", MessageBoxButtons.OK);
                }
            }
        }

        private void SearchButtonService_Click(object sender, EventArgs e)
        {
            if(IDTextBoxUpdate.Text == String.Empty)
            {
                MessageBox.Show("Please provide information to search!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ServiceDTO service = ServiceBUS.Instance.searchService(Int32.Parse(IDTextBoxUpdate.Text));
                if (service != null)
                {
                    IDTextBoxUpdate.Text = service.ID.ToString(); ;
                    nameTextBoxUpdate.Text = service.Name;
                    typeIDComboBoxUpdate.Text = ServiceCategoryBUS.Instance.getTypeName(service.TypeID);
                    descriptionTextBoxUpdate.Text = service.Description;
                    priceTextBoxUpdate.Text = service.Price.ToString(); ;
                    statusComboBoxUpdate.Text = service.Status;
                }
                else
                {
                    MessageBox.Show("No data found", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void updateButtonService_Click(object sender, EventArgs e)
        {
            if (nameTextBoxUpdate.Text == String.Empty || typeIDComboBoxUpdate.Text == String.Empty || descriptionTextBoxUpdate.Text == String.Empty || priceTextBoxUpdate.Text == String.Empty
                || statusComboBoxUpdate.Text == String.Empty)
            {
                MessageBox.Show("Pleas provide all information", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ServiceDTO service = new ServiceDTO(Int32.Parse(IDTextBoxUpdate.Text), nameTextBoxUpdate.Text, ServiceCategoryBUS.Instance.getTypeID(typeIDComboBoxUpdate.Text.ToString()), descriptionTextBoxUpdate.Text
                    , float.Parse(priceTextBoxUpdate.Text.ToString()), statusComboBoxUpdate.Text);
                if (ServiceBUS.Instance.updateService(service))
                {
                    MessageBox.Show("update Service Successful!", "Message", MessageBoxButtons.OK);
                    IDTextBoxAdd.Clear();
                    nameTextBoxAdd.Clear();
                    statusComboBoxType.Text = "";
                    descriptionTextBoxAdd.Clear();
                    priceTextBoxAdd.Clear();
                    typeComboBoxAdd.Text = "";
                    ServiceCategoryBUS.Instance.getType(typeIDComboBoxUpdate);

                }
                else
                {
                    MessageBox.Show("Add Service Faile!", "Message", MessageBoxButtons.OK);
                }
            }

        }

        private void deleteButtonService_Click(object sender, EventArgs e)
        {
            if (nameTextBoxUpdate.Text == String.Empty || typeIDComboBoxUpdate.Text == String.Empty || descriptionTextBoxUpdate.Text == String.Empty || priceTextBoxUpdate.Text == String.Empty
                || statusComboBoxUpdate.Text == String.Empty)
            {
                MessageBox.Show("Please Search before delete", "Error", MessageBoxButtons.OK);
            }
            if (ServiceBUS.Instance.deleteService(Int32.Parse(IDTextBoxUpdate.Text)))
            {
                MessageBox.Show("Delete Service Successful!", "Message", MessageBoxButtons.OK);
                IDTextBoxAdd.Clear();
                nameTextBoxAdd.Clear();
                statusComboBoxType.Text = "";
                descriptionTextBoxAdd.Clear();
                priceTextBoxAdd.Clear();
                typeComboBoxAdd.Text = "";
                ServiceCategoryBUS.Instance.getType(typeIDComboBoxUpdate);

            }
            else
            {
                MessageBox.Show("Delete Service Faile!", "Message", MessageBoxButtons.OK);
            }
        }
    }
}

