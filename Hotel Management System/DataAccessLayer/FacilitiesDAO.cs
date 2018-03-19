using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace DataAccessLayer
{
    public class FacilitiesDAO
    {
        private static FacilitiesDAO instance;
        public static FacilitiesDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FacilitiesDAO();
                }
                return instance;
            }
        }
        //Thêm sản phẩm
        public Boolean addproduct(FacilitiesDTO product)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Facilities] VALUES('" + product.ID + "',N'" + product.Name + "','" + product.Price  + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        // Lấy danh sách sản phẩm
        public List<FacilitiesDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<FacilitiesDTO> productList = new List<FacilitiesDTO>();
            String query = "SELECT * FROM [Facilities]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["FID"].ToString());
                String name = item["Name"].ToString();
                float price = float.Parse(item["Price"].ToString());
                productList.Add(new FacilitiesDTO(ID, name, price));

            }
            connect.close();
            return productList;

        }
        public String getName(int FID)
        {
            Connection connect = new Connection();
            connect.open();
            String name = "";
            String query = "SELECT * FROM [Facilities] where FID =" + FID + ";";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                name = item["Name"].ToString();
            }
            connect.close();
            return name;

        }
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> productList = new List<int>();
            String query = "SELECT * FROM [Facilities]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["FID"].ToString());


                productList.Add(ID);
            }
            connect.close();
            return productList;

        }

        public Boolean updateproduct(FacilitiesDTO product)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Facilities] SET Name=N'" + product.Name + "',Price = '" + product.Price  + "'where FID =" + product.ID + ";";
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
            String strQuery = "DELETE FROM [Facilities] where FID =" + ID + ";";
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
