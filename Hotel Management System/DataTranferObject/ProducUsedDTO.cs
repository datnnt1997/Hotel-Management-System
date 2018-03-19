using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class ProducUsedDTO
    {

        private int productID;
        private String name;
        private int quantity;
        private float price;
        private float total;

        public ProducUsedDTO(int productID, string name, int quantity, float price, float total)
        {
            this.productID = productID;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.total = total;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
        public float Total { get => total; set => total = value; }
    }
}
