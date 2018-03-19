using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class RoomTypeDTO
    {
        private String typeID;
        private String name;
        private int bed;
        private float price;
        private String description;
        public RoomTypeDTO(string typeID, string name, int bed, float price, string description)
        {
            this.typeID = typeID;
            this.name = name;
            this.bed = bed;
            this.price = price;
            this.description = description;
        }
        public string TypeID { get => typeID; set => typeID = value; }
        public string Name { get => name; set => name = value; }
        public int Bed { get => bed; set => bed = value; }
        public float Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
    }
}
