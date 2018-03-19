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
    public class ReservationBUSTests
    {
        ReservationDTO reser;
        [TestMethod()]
        public void addReservationTest()
        {
            reser = new ReservationDTO(1000, "C2233354122017", 0, "A701", "1/1/2020", "2/2/2020", "CheckIn");
            Boolean result =ReservationBUS.Instance.addReservation(reser);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void updateReservationTest()
        {
            reser = new ReservationDTO(1000, "C2233354122017", 0, "A701", "1/1/2020", "2/2/2020", "Available");
            Boolean result = ReservationBUS.Instance.updateReservation(reser);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void deleteReservationTest()
        {
            Boolean result = ReservationBUS.Instance.deleteReservation(1000);
            Assert.AreEqual(result, true);
        }
    }
}