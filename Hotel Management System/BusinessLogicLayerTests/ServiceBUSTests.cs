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
    public class ServiceBUSTests
    {
        private ServiceDTO service;
        [TestMethod()]
        public void addServiceTest()
        {
            service = new ServiceDTO(1000, "Test", 1, "testt", 0, "Available");
            Boolean result = ServiceBUS.Instance.addService(service);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void updateServiceTest()
        {
            service = new ServiceDTO(1000, "Test", 1, "testt", 1000, "Unavailable");
            Boolean result = ServiceBUS.Instance.updateService(service);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void deleteServiceTest()
        {
            Boolean result = ServiceBUS.Instance.deleteService(1000);
            Assert.AreEqual(result, true);
        }
    }
}