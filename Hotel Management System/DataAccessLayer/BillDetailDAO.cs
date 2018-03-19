using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace DataAccessLayer
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance;
        public static BillDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDetailDAO();
                }
                return instance;
            }
        }

        public Boolean addbilldetail(BillDetailDTO bill)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [BillDetail] VALUES('" + bill.ID+ "','" + bill.BillID + "','" + bill.ProductID + "',N'" + bill.Name + "','" + bill.Quantity + "','" + bill.Price + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public List<BillDetailDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<BillDetailDTO> billdetailList = new List<BillDetailDTO>();
            String query = "SELECT * FROM [BillDetail]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["ID"].ToString());
                int billID = Int32.Parse(item["BillID"].ToString());
                int proID = Int32.Parse(item["ProductID"].ToString());
                String name = item["ProductName"].ToString();
                int quantity = Int32.Parse(item["Quantiy"].ToString());
                float price = float.Parse(item["Price"].ToString());

                billdetailList.Add(new BillDetailDTO(ID, billID, proID, name, quantity,price));

            }
            connect.close();
            return billdetailList;

        }
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> billdetailList = new List<int>();
            String query = "SELECT * FROM [BillDetail]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["ID"].ToString());


                billdetailList.Add(ID);
            }
            connect.close();
            return billdetailList;

        }
    }
}
