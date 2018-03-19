using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class FacilitiesDTO
    {
        private int iD;
        private String name;
        private float price;

        public FacilitiesDTO(int iD, string name, float price)
        {
            this.iD = iD;
            this.name = name;
            this.price = price;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
    }



}

