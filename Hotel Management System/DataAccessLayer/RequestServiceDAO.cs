using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace DataAccessLayer
{
    public class RequestServiceDAO
    {
        private static RequestServiceDAO instance;
        public static RequestServiceDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RequestServiceDAO();
                }
                return instance;
            }
        }
        public Boolean addCompensatory(RequestServiceDTO com)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [UseService] VALUES('" + com.ID + "',N'" + com.Date + "','" + com.RentID + "',N'" + com.RID
                + "',N'" + com.FID + "','" + com.Quantity + "','" + com.Price + "',N'" + com.Total + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean updateCompensatory(RequestServiceDTO com)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[UseService] SET Date=N'" + com.Date + "',RentID = '" + com.RentID + "',RID =N'"
                + com.RID + "',FID ='" + com.FID + "',Quantity =N'" + com.Quantity + "',Price = '" + com.Price + "',Total = '" + com.Total + "'where RequestID =" + com.ID + ";";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean deleteCompensatory(int ID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [UseService] where RentID =" + ID + ";";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean deleteRequest(int ID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [UseService] where RequestID =" + ID + ";";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public List<RequestServiceDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<RequestServiceDTO> list = new List<RequestServiceDTO>();
            String query = "SELECT * FROM [Compensatory]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["RequestID"].ToString());
                String date = item["Date"].ToString();
                int rentID = Int32.Parse(item["RentID"].ToString());
                String RID = item["RID"].ToString();
                int FID = Int32.Parse(item["FID"].ToString());
                int quantity = Int32.Parse(item["Quantity"].ToString());
                float price = float.Parse(item["Price"].ToString());
                float total = float.Parse(item["Total"].ToString());
                list.Add(new RequestServiceDTO(ID, date, rentID, RID, FID, quantity, price, total));
            }
            connect.close();
            return list;

        }
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> productList = new List<int>();
            String query = "SELECT * FROM [UseService]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["RequestID"].ToString());


                productList.Add(ID);
            }
            connect.close();
            return productList;

        }
        public List<RequestServiceDTO> getBill(int rentID)
        {
            Connection connect = new Connection();
            connect.open();
            List<RequestServiceDTO> productList = new List<RequestServiceDTO>();
            String query = "SELECT * FROM [UseService] where RentID =" + rentID + ";";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["RequestID"].ToString());
                String date = item["Date"].ToString();
                int RentID = Int32.Parse(item["RentID"].ToString());
                String room = item["RID"].ToString();
                int FID = Int32.Parse(item["FID"].ToString());
                int quantity = Int32.Parse(item["Quantity"].ToString());
                float price = float.Parse(item["Price"].ToString());
                float total = float.Parse(item["Total"].ToString());
                productList.Add(new RequestServiceDTO(ID, date, RentID, room, FID, quantity, price, total));

            }
            connect.close();
            return productList;

        }
    }
}
