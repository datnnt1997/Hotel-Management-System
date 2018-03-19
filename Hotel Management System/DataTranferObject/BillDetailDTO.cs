using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class BillDetailDTO
    {
        private int iD;
        private int billID;
        private int productID;
        private String name;
        private int quantity;
        private float price;

        public BillDetailDTO(int iD, int billID, int productID, string name, int quantity, float price)
        {
            this.iD = iD;
            this.billID = billID;
            this.productID = productID;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
    }
}
