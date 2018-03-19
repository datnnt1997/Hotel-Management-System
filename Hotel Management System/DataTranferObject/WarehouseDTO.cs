using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class WarehouseDTO
    {
        private int productID;
        private String name;
        private float price;
        private int quantity;

        public WarehouseDTO(int productID, string name, float price, int quantity)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
      
    }
}
