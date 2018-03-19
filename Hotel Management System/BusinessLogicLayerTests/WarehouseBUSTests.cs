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
    public class WarehouseBUSTests
    {
        private WarehouseDTO warehouse;
        [TestMethod()]
        public void addWarehouseTruetTest()
        {
            warehouse = new WarehouseDTO(1000, "test", 0, 10);
            Boolean result = WarehouseBUS.Instance.addproduct(warehouse);
            Assert.AreEqual(result, true);
        }
     
        [TestMethod()]
        public void updateWarehouseTest()
        {
            warehouse = new WarehouseDTO(1000, "test", 0, 100);
            Boolean result = WarehouseBUS.Instance.updateproduct(warehouse);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void addWarehouseTest()
        {
            Boolean result = WarehouseBUS.Instance.deleteproduct(1000);
            Assert.AreEqual(result, true);
        }

    }
}