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
    public class ServiceCategoryBUSTests
    {
        private ServiceCategoryDTO type;
        [TestMethod()]
        public void addServiceTypeTest()
        {
            type = new ServiceCategoryDTO(1000, "Test", "Available");
            Boolean result=ServiceCategoryBUS.Instance.addType(type);
            Assert.AreEqual(result,true);
        }
        [TestMethod()]
        public void updateServiceTypeTest()
        {
            type = new ServiceCategoryDTO(1000, "Test", "Unavailable");
            Boolean result = ServiceCategoryBUS.Instance.updateType(type);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void getServiceTypeIDTest()
        {
            int result = ServiceCategoryBUS.Instance.getTypeID("Test");
            Assert.AreEqual(result, 1000);
        }
        [TestMethod()]
        public void deleteServiceTypeTest()
        {
            Boolean result = ServiceCategoryBUS.Instance.deleteType(1000);
            Assert.AreEqual(result, true);
        }
        
    }
}