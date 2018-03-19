using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data;

namespace DataAccessLayer
{
    public class WarehouseDAO
    {
        private static WarehouseDAO instance;
        public static WarehouseDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WarehouseDAO();
                }
                return instance;
            }
        }

        public Boolean addproduct(WarehouseDTO product)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Warehouse] VALUES('" + product.ProductID + "','" + product.Name + "','" + product.Price + "','" + product.Quantity + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public List<WarehouseDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<WarehouseDTO> productList = new List<WarehouseDTO>();
            String query = "SELECT * FROM [Warehouse]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["ProductID"].ToString());
                String name = item["Name"].ToString();
                float price = float.Parse(item["Price"].ToString());
                int quantity = Int32.Parse(item["Quantity"].ToString());
                productList.Add(new WarehouseDTO(ID, name, price,quantity));

            }
            connect.close();
            return productList;

        }
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> productList = new List<int>();
            String query = "SELECT * FROM [Warehouse]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["ProductID"].ToString());


                productList.Add(ID);
            }
            connect.close();
            return productList;

        }

        public Boolean updateproduct(WarehouseDTO product)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Warehouse] SET Name=N'" + product.Name + "',Price = '" + product.Price + "',Quantity = '" + product.Quantity+ "'where ProductID =" + product.ProductID + ";";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean deleteproduct(int ID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [Warehouse] where ProductID =" + ID + ";";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;


        }
    }
}
