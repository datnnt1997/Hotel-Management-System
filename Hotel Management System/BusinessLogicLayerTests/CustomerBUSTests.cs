using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace Business_Logic_Layer.Tests
{
    [TestClass()]
    public class CustomerBUSTests
    {
        private CustomerDTO customer;
        [TestMethod()]
        public void insertCustomerTest()
        {
            customer = new CustomerDTO("C10522122017", "1234567899", "Ngô Nguyễn Trọng", "Đắt", "01/18/1997","Male","0938918200", "dat821168@gmail.com.vn", "KTX", 0, 0);
            Boolean result = CustomerBUS.Instance.insertCustomer(customer);
            Assert.AreEqual(result, true);
        }

        [TestMethod()]
        public void UpdateCustomerTest()
        {
            customer = new CustomerDTO("C10522122017", "1234567899", "Ngô Nguyễn Trọng", "Đắt", "01/18/1997", "Male", "0938918200", "dat821168@gmail.com.vn", "Ton Duc Thang University", 0, 0);
            Boolean result = CustomerBUS.Instance.updateCustomer(customer);
            Assert.AreEqual(result, true);
            CustomerBUS.Instance.deleteCustomer("C10522122017", "");
        }
       [TestMethod()]
        public void deleteCustomerTest()
        {
            customer = new CustomerDTO("C1052213332017", "", "  ", "", "", "", "", "", "", 0, 0);
            CustomerBUS.Instance.insertCustomer(customer);
            Boolean result = CustomerBUS.Instance.deleteCustomer("C1052213332017", "");
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void searchCustomerTest()
        {
            customer = new CustomerDTO("C1052213332017", "", "  ", "", "", "", "", "", "", 0, 0);
            CustomerBUS.Instance.insertCustomer(customer);
            CustomerDTO result = CustomerBUS.Instance.searchCustomer("C1052213332017", "");
            Assert.AreEqual(result.CID, customer.CID);
            CustomerBUS.Instance.deleteCustomer("C1052213332017","");
        }
        [TestMethod()]
        public void getMoneyTest()
        {
            customer = new CustomerDTO("C1052213332017", "", "  ", "", "", "", "", "", "", 0, 0);
            CustomerBUS.Instance.insertCustomer(customer);
            float result = CustomerBUS.Instance.getMoney("C1052213332017");
            Assert.AreEqual(result, 0);
            CustomerBUS.Instance.deleteCustomer("C1052213332017", "");
        }
        [TestMethod()]
        public void updateMoneyTest()
        {
            customer = new CustomerDTO("C1052213332017", "", "  ", "", "", "", "", "", "", 0, 0);
            CustomerBUS.Instance.insertCustomer(customer);
            Boolean result = CustomerBUS.Instance.updateMoney("C1052213332017",1,1000);
            Assert.AreEqual(result, true);
            CustomerBUS.Instance.deleteCustomer("C1052213332017", "");
        }



    }
}