using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class RequestServiceDTO
    {
        private int iD;
        private String date;
        private int rentID;
        private String rID;
        private int fID;
        private int quantity;
        private float price;
        private float total;

        public RequestServiceDTO(int iD, string date, int rentID, string rID, int fID, int quantity, float price, float total)
        {
            this.iD = iD;
            this.date = date;
            this.rentID = rentID;
            this.rID = rID;
            this.fID = fID;
            this.quantity = quantity;
            this.price = price;
            this.total = total;
        }

        public int ID { get => iD; set => iD = value; }
        public string Date { get => date; set => date = value; }
        public int RentID { get => rentID; set => rentID = value; }
        public string RID { get => rID; set => rID = value; }
        public int FID { get => fID; set => fID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
        public float Total { get => total; set => total = value; }
    }
}
