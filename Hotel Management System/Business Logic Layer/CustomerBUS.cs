using DataAccessLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;
        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerBUS();
                }
                return instance;
            }
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = CustomerDAO.Instance.displayAll();
        }
        public Boolean insertCustomer(CustomerDTO cusNewCustomer)
        {
            return CustomerDAO.Instance.insertCustomer(cusNewCustomer);
        }
        public CustomerDTO searchCustomer(String strCustomerID, String strPassportID)
        {
            return CustomerDAO.Instance.searchCustomer(strCustomerID, strPassportID);
        }
        public Boolean updateCustomer(CustomerDTO customer)
        {
            return CustomerDAO.Instance.updateCustomer(customer);
        }
        public Boolean deleteCustomer(String strCustomerID, String strPassportID)
        {
            return CustomerDAO.Instance.deleteCustomer(strCustomerID, strPassportID);
        }
        public float getMoney(String ID)
        {
            return CustomerDAO.Instance.getMoney(ID);
        }
        public Boolean updateMoney(String ID, int VIP, float money)
        {
            return CustomerDAO.Instance.updatemoney(ID, VIP, money);
        }

    }
}
