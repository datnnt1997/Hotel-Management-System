using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class BillDTO
    {
        private int billID;
        private int RentID;

        public BillDTO(int billID, int rentID)
        {
            this.billID = billID;
            RentID = rentID;
        }

        public int BillID { get => billID; set => billID = value; }
        public int RentID1 { get => RentID; set => RentID = value; }
    }
}
