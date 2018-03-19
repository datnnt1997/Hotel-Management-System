using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class RoomDTO
    {
        private String RID;
        private String RentID;
        private String location;
        private String type;
        private String status;

        public RoomDTO(string rID, string rentID, string location, string type, string status)
        {
            RID = rID;
            RentID = rentID;
            this.location = location;
            this.type = type;
            this.status = status;
        }

        public string RID1 { get => RID; set => RID = value; }
        public string RentID1 { get => RentID; set => RentID = value; }
        public string Location { get => location; set => location = value; }
        public string Type { get => type; set => type = value; }
        public string Status { get => status; set => status = value; }
    }
}
