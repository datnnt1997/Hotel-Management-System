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
    public class VIPBUSTests
    {
        private VIPDTO vip;
        [TestMethod()]
        public void addVIPTest()
        {
            vip = new VIPDTO(10, 50, 1000000);
            Boolean result=VIPBUS.Instance.addVIP(vip);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void getVIPValueTest()
        {
            int result = VIPBUS.Instance.getValue(10);
            Assert.AreEqual(result, 50);
        }
        [TestMethod()]
        public void checkVIPTest()
        {
            int result = VIPBUS.Instance.checkVIP(1000000);
            Assert.AreEqual(result, 10);
        }
        [TestMethod()]
        public void updateVIPTest()
        {
            vip = new VIPDTO(10, 60, 1000000);
            Boolean result = VIPBUS.Instance.updateVIP(vip);
            Assert.AreEqual(result, true);
            VIPBUS.Instance.deleteVIP(10);
        }
        [TestMethod()]
        public void deleteVIPTest()
        {
            vip = new VIPDTO(10, 60, 1000000);
            VIPBUS.Instance.addVIP(vip);
            Boolean result = VIPBUS.Instance.deleteVIP(10);
            Assert.AreEqual(result, true);
        }
    }
}