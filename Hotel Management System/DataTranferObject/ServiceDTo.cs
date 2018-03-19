using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class ServiceDTO
    {
        private int iD;
        private String name;
        private int typeID;
        private String description;
        private float price;
        private String status;

        public ServiceDTO(int iD, string name, int typeID, string description, float price, string status)
        {
            this.iD = iD;
            this.name = name;
            this.typeID = typeID;
            this.description = description;
            this.price = price;
            this.status = status;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int TypeID { get => typeID; set => typeID = value; }
        public string Description { get => description; set => description = value; }
        public float Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }
    }
}
