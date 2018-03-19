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
    public class EmployeeBUSTests
    {
        private EmployeeDTO employee;
        [TestMethod()]
        public void insertEmployeeTest()
        {
            employee = new EmployeeDTO(10000, "Ngô Nguyễn Trọng", "Đắt", "01/18/1997", "Male", "0938918200", "dat821168@gmail.com", "Ton Duc Thang University", "Manager",1000);
            Boolean result = EmployeeBUS.Instance.insertEmployee(employee);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void searchEmployeeTest()
        {
            employee = new EmployeeDTO(10000, "Ngô Nguyễn Trọng", "Đắt", "01/18/1997", "Male", "0938918200", "dat821168@gmail.com", "Ton Duc Thang University", "Manager", 1000);
            EmployeeDTO result = EmployeeBUS.Instance.searchEmployee("10000");
            Console.WriteLine(result.LastName + " " + employee.LastName);
            Assert.AreEqual(result.LastName, employee.LastName);
        }
        [TestMethod()]
        public void updateEmployeeTest()
        {
            employee = new EmployeeDTO(10000, "Ngô Nguyễn Trọng", "Đắt", "01/18/1997", "Male", "0938918200", "dat821168@gmail.com", "Domitory of Ton Duc Thang University", "Manager", 1000);
            Boolean result = EmployeeBUS.Instance.updateEmployee(employee);
            Assert.AreEqual(result, true);
            EmployeeBUS.Instance.deleteEmployee("10000");
        }
        [TestMethod()]
        public void deleteEmployeeTest()
        {
            employee = new EmployeeDTO(10000, "Ngô Nguyễn Trọng", "Đắt", "01/18/1997", "Male", "0938918200", "dat821168@gmail.com", "Domitory of Ton Duc Thang University", "Manager", 1000);
            EmployeeBUS.Instance.insertEmployee(employee);
            Boolean result = EmployeeBUS.Instance.deleteEmployee("10000");
            Assert.AreEqual(result, true);
        }
        

    }
}