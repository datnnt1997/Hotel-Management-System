using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public  class PromotionDTO
    {
        private int iD;
        private String name;
        private int value;
        private String condition;
        private String time;
        private String description;

        public PromotionDTO(int ID, string name, int value, string condition, string time, string description)
        {
            iD = ID;
            this.name = name;
            this.value = value;
            this.condition = condition;
            this.time = time;
            this.description = description;
        }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Value { get => value; set => this.value = value; }
        public string Condition { get => condition; set => condition = value; }
        public string Time { get => time; set => time = value; }
        public string Description { get => description; set => description = value; }
       
    }
}
