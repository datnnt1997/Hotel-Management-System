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
    public class CompensatoryBUSTests
    {
        private CompensatoryDTO compensatory;
        [TestMethod()]
        public void addCompensatoryTest1()
        {
          
            ReservationDTO reser = new ReservationDTO(1000, "C2233354122017", 0,"A701", "1/1/2020", "2/2/2020", "CheckIn");
            ReservationBUS.Instance.addReservation(reser);
            compensatory = new CompensatoryDTO(1000, "1/1/2020", 1000, "A701", 1, 10, 1000, 10000);
            Boolean result= CompensatoryBUS.Instance.addproduct(compensatory);
            Assert.AreEqual(result, true);
        }
        
        [TestMethod()]
        public void updateCompensatoryTest()
        {
            compensatory = new CompensatoryDTO(1000, "1/1/2020", 1000, "A701", 2, 10, 1000, 10000);
            Boolean result = CompensatoryBUS.Instance.updateproduct(compensatory);
            Assert.AreEqual(result, true);

        }
        [TestMethod()]
        public void deleteCompensatoryTest1()
        {
            Boolean result = CompensatoryBUS.Instance.deleteproduct(1000);
            Assert.AreEqual(result, true);
            ReservationBUS.Instance.deleteReservation(1000);
        }
        
    }
}