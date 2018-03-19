using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public  class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return instance;
            }
        }

        public Boolean addbill(BillDTO bill)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Bill] VALUES('" + bill.BillID + "','" + bill.RentID1  + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public List<BillDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<BillDTO> billList = new List<BillDTO>();
            String query = "SELECT * FROM [Bill]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["BillID"].ToString());
                int rentID = Int32.Parse(item["RentID"].ToString());
                billList.Add(new BillDTO(ID, rentID));

            }
            connect.close();
            return billList;

        }
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> billList = new List<int>();
            String query = "SELECT * FROM [Bill]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["BillID"].ToString());


                billList.Add(ID);
            }
            connect.close();
            return billList;

        }

    }
}
