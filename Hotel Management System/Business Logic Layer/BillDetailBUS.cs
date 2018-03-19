using DataAccessLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public class BillDetailBUS
    {
        private static BillDetailBUS instance;
        public static BillDetailBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDetailBUS();
                }
                return instance;
            }
        }
        public Boolean addbill(BillDetailDTO billdeltail)
        {
            return BillDetailDAO.Instance.addbilldetail(billdeltail);
        }

        public void displayAll(DataGridView data)
        {
            data.DataSource = BillDetailDAO.Instance.displayAll();
        }
        public int getID()
        {
            int ID = 1;
            List<int> billList = BillDetailDAO.Instance.getID();
            foreach (int bill in billList)
            {
                if (bill == ID)
                {
                    ID++;
                }
                else
                {
                    return ID;
                }
            }
            return ID;
        }
        public float getBill(DataGridView data,int rentID)
        {
            float totalprice = 0;
            List<CompensatoryDTO> listcom = CompensatoryBUS.Instance.getBill(rentID);
            List<RequestServiceDTO> listservice = RequestServiceBUS.Instance.getBill(rentID);
            List<ProducUsedDTO> listbill = new List<ProducUsedDTO>();
            foreach(CompensatoryDTO com in listcom)
            {
                    int productID=com.FID;
                    String name=FacilitiesBUS.Instance.getName(com.FID);
                    int quantity=com.Quantity;
                    float price=com.Price;
                    float total=com.Total;
                totalprice += total;
                listbill.Add(new ProducUsedDTO(productID, name, quantity, price, total));
            }
            foreach (RequestServiceDTO ser in listservice)
            {
                int productID = ser.FID;
                String name = ServiceBUS.Instance.getName(ser.FID);
                int quantity = ser.Quantity;
                float price = ser.Price;
                float total = ser.Total;
                totalprice += total;
                listbill.Add(new ProducUsedDTO(productID, name, quantity, price, total));
            }
            data.DataSource = listbill;
            return totalprice;
        }
    }
}
