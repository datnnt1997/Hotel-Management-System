using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class ServiceCategoryDTO
    {
        private int iD;
        private String name;
        private String status;

        public ServiceCategoryDTO(int iD, string name, String status)
        {
            this.iD = iD;
            this.name = name;
            this.status = status;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public String Status { get => status; set => status = value; }
    }
}
