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
    public class FacilitiesBUSTests
    {
        FacilitiesDTO facility;
        [TestMethod()]
        public void addFacilitiesTest()
        {
            facility = new FacilitiesDTO(10000, "test", 0);
            Boolean result = FacilitiesBUS.Instance.addproduct(facility);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void getNameFacilitiesTest()
        {
            String result = FacilitiesBUS.Instance.getName(10000);
            Assert.AreEqual(result, "test");
        }
        [TestMethod()]
        public void updateFacilitiesTest()
        {
            facility = new FacilitiesDTO(10000, "test", 1000);
            Boolean result = FacilitiesBUS.Instance.updateproduct(facility);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void deleteFacilitiesTest()
        {
            Boolean result = FacilitiesBUS.Instance.deleteproduct(10000);
            Assert.AreEqual(result, true);
        }
    }
}