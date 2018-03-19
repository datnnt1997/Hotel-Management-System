using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class RoomFacilitiesDTO
    {
        private int ID;
        private String RID;
        private String FID;
        private int quantity;

        public RoomFacilitiesDTO(int iD, string rID, string fID, int quantity)
        {
            ID = iD;
            RID = rID;
            FID = fID;
            this.quantity = quantity;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string RID1 { get => RID; set => RID = value; }
        public string FID1 { get => FID; set => FID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
