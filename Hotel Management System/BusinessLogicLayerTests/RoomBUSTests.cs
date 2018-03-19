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
    public class RoomBUSTests
    {
        private RoomDTO room;
        [TestMethod()]
        public void addRoomTest()
        {
            room = new RoomDTO("D1000", "", "D10", "SUP1", "Available");
            Boolean result = RoomBUS.Instance.addRoom(room);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void searchRoomTest()
        {
            room = new RoomDTO("D1000", "", "D10", "SUP1", "Available");
            RoomDTO result = RoomBUS.Instance.searchRoom("D1000");
            Assert.AreEqual(result.RID1, room.RID1);
        }
        [TestMethod()]
        public void getRoomTypeTest()
        {
            String result = RoomBUS.Instance.getType("D1000");
            Assert.AreEqual(result,"SUP1");
        }
        [TestMethod()]
        public void updateRoomTest()
        {
            room = new RoomDTO("D1000", "", "D10", "DLX3", "Available");
            Boolean result = RoomBUS.Instance.updateRoom(room);
            Assert.AreEqual(result,true);
        }
        [TestMethod()]
        public void updateRoomReserTest()
        {
            room = new RoomDTO("D1000", "", "D10", "DLX3", "Available");
            Boolean result = RoomBUS.Instance.updateRent(10,"D1000");
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void getRoomRentTest()
        {
            String result = RoomBUS.Instance.getRent("D1000");
            Assert.AreEqual(result, "10");
        }
        [TestMethod()]
        public void checkRoomIDFalseTest()
        {
            Boolean result = RoomBUS.Instance.CheckID("D1000");
            Assert.AreEqual(result, false);
        }
        [TestMethod()]
        public void getRoomTest()
        {
            RoomDTO result = RoomBUS.Instance.getRoom("SUP1", "12/14/2023", "12/15/2023");
            Assert.AreEqual(result.RID1, "A506");
        }
        [TestMethod()]
        public void checkRoomIDTrueTest()
        {
            Boolean result = RoomBUS.Instance.CheckID("D1001");
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void updateRoomStatusTest()
        {
            room = new RoomDTO("D1000", "", "D10", "DLX3", "Available");
            Boolean result = RoomBUS.Instance.updateRoomStatus("D1000","Cleaning");
            Assert.AreEqual(result, true);
            RoomBUS.Instance.deleteRoom("D1000");

        }
        [TestMethod()]
        public void deleteRoomTest()
        {
            room = new RoomDTO("D1000", "", "D10", "SUP1", "Available");
            RoomBUS.Instance.addRoom(room);
            Boolean result = RoomBUS.Instance.deleteRoom("D1000");
            Assert.AreEqual(result, true);
        }
    }
}