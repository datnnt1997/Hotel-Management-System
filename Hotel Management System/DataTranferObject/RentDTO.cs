using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class RentDTO
    {
        private int rentID;
        private String cID;
        private int eID;
        private String rID;
        private String checkIn;
        private String checkOut;
        private String status;

        public RentDTO(int rentID, string cID, int eID, string rID, string checkIn, string checkOut, string status)
        {
            this.rentID = rentID;
            this.cID = cID;
            this.eID = eID;
            this.rID = rID;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.status = status;
        }

        public int RentID { get => rentID; set => rentID = value; }
        public string CID { get => cID; set => cID = value; }
        public int EID { get => eID; set => eID = value; }
        public string RID { get => rID; set => rID = value; }
        public string CheckIn { get => checkIn; set => checkIn = value; }
        public string CheckOut { get => checkOut; set => checkOut = value; }
        public string Status { get => status; set => status = value; }
    }
}
