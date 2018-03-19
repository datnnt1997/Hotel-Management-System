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
    public class RoomTypeBUSTests
    {
        private RoomTypeDTO roomtype;
        [TestMethod()]
        public void addRoomTypeTest()
        {
            roomtype = new RoomTypeDTO("Test","Test Type",0,0,"Test Case");
            Boolean result = RoomTypeBUS.Instance.addRoomType(roomtype);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void updateTypeTest()
        {
            roomtype = new RoomTypeDTO("Test", "Test Type", 1, 100, "Test Case");
            Boolean result = RoomTypeBUS.Instance.updateRoomType(roomtype);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void getPriceRoomTypeTest()
        {
            float result = RoomTypeBUS.Instance.getPrice("Test");
            Assert.AreEqual(result, 100);
        }
        [TestMethod()]
        public void checkRoomTypeIDFalseTest()
        {
            Boolean result = RoomTypeBUS.Instance.CheckID("Test");
            Assert.AreEqual(result, false);
            RoomTypeBUS.Instance.deleteRoomType("Test");
        }
        [TestMethod()]
        public void checkRoomTypeIDTrueTest()
        {
            Boolean result = RoomTypeBUS.Instance.CheckID("Test1");
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void deleteTypeTest()
        {
            roomtype = new RoomTypeDTO("Test", "Test Type", 0, 0, "Test Case");
            RoomTypeBUS.Instance.addRoomType(roomtype);
            Boolean result = RoomTypeBUS.Instance.deleteRoomType("Test");
            Assert.AreEqual(result, true);
        }
    }
}