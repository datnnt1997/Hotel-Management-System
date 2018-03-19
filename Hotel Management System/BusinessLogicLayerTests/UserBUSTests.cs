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
    public class UserBUSTests
    {
        private UserDTO user;
        [TestMethod()]
        public void InsertUserTest()
        {
           EmployeeDTO employee = new EmployeeDTO(10000, "Ngô Nguyễn Trọng", "Đắt", "01/18/1997", "Male", "0938918200", "dat821168@gmail.com", "Ton Duc Thang University", "Manager", 1000);
           EmployeeBUS.Instance.insertEmployee(employee);
            user = new UserDTO("10000", "test", "test");
            Boolean result = UserBUS.Instance.insertUser(user);
            Assert.AreEqual(result,true);
        }
        [TestMethod()]
        public void LoginTrueTest()
        {
            Boolean result = UserBUS.Instance.Login("test", "test");
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void LoginFalseTest()
        {
            Boolean result = UserBUS.Instance.Login("test", "test1");
            Assert.AreEqual(result, false);
        }
        [TestMethod()]
        public void searchUserTest()
        {
            UserDTO result = UserBUS.Instance.searchEmployee("10000");
            Assert.AreEqual(result.UserName, "test");
        }
        [TestMethod()]
        public void searchEmployeeIDTest()
        {
            int result = UserBUS.Instance.searchEmployeeID("test");
            Assert.AreEqual(result,10000);
        }
        [TestMethod()]
        public void changeEmployeePasswordTest()
        {
            Boolean result = UserBUS.Instance.changePassword("test1",10000);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void searchEmployeePasswordTest()
        {
            String result = UserBUS.Instance.searchPassword("test");
            Assert.AreEqual(result, "test1");
        }
        [TestMethod()]
        public void DeleteTest()
        {
            Boolean result = UserBUS.Instance.deleteEmployee("10000");
            Assert.AreEqual(result, true);
            EmployeeBUS.Instance.deleteEmployee("10000");
        }
    }
}