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
    public class RequestServiceBUSTests
    {
        RequestServiceDTO requestService;
        [TestMethod()]
        public void addRequestServiceTest()
        {
            ReservationDTO reser = new ReservationDTO(1000, "C2233354122017", 0, "A701", "1/1/2020", "2/2/2020", "CheckIn");
            ReservationBUS.Instance.addReservation(reser);
            requestService = new RequestServiceDTO( 1000, "1/1/2020", 1000, "A701", 1, 10, 1000, 10000);
            Boolean result=RequestServiceBUS.Instance.addproduct(requestService);
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void updateRequestServiceTest()
        {
            requestService = new RequestServiceDTO(1000, "1/1/2020", 1000, "A701", 2, 10, 1000, 10000);
            Boolean result = RequestServiceBUS.Instance.updateproduct(requestService);
            Assert.AreEqual(result, true);

        }
        [TestMethod()]
        public void deleteRequestServiceTest()
        {
            Boolean result = RequestServiceBUS.Instance.deleteproduct(1000);
            Assert.AreEqual(result, true);
            ReservationBUS.Instance.deleteReservation(1000);
        }
    }
}