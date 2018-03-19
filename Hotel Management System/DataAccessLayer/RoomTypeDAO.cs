using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data;

namespace DataAccessLayer
{
    public class RoomTypeDAO
    {
        private static RoomTypeDAO instance;
        public static RoomTypeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomTypeDAO();
                }
                return instance;
            }
        }

        public Boolean addRoomType(RoomTypeDTO roomType)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [RoomCategoryID] VALUES(N'" + roomType.TypeID + "',N'" + roomType.Name + "','" + roomType.Bed + "','"
                            + roomType.Price + "',N'" + roomType.Description+ "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;

        }

        public List<RoomTypeDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<RoomTypeDTO> roomTypeList = new List<RoomTypeDTO>();
            String query = "SELECT * FROM [RoomCategoryID]";
            System.Data.DataTable data = connect.executeQuery(query);
            foreach (System.Data.DataRow item in data.Rows)
            {
                String categoryID = item["CategoryID"].ToString();
                String name = item["Name"].ToString();
                int bed = Int32.Parse(item["Bed"].ToString());
                float price = float.Parse(item["Price"].ToString());
                String description = item["Description"].ToString();
                roomTypeList.Add(new RoomTypeDTO(categoryID,name, bed, price, description));
            }
            connect.close();
            return roomTypeList;

        }
        public float getPrice(String type)
        {
            Connection connect = new Connection();
            connect.open();
            float value = 0;
            String query = "SELECT * FROM [RoomCategoryID] Where CategoryID='" + type + "';";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                value = float.Parse(item["Price"].ToString());

            }
            connect.close();
            return value;

        }

        public Boolean updateRoomType(RoomTypeDTO roomType)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE [RoomCategoryID] SET Name= N'" + roomType.Name + "',Bed='" + roomType.Bed + "',Price='" + roomType.Price + "'," +
                "Description=N'" + roomType.Description + "'where CategoryID ='" + roomType.TypeID + "'";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }

        public Boolean deleteRoomType(String typeID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [RoomCategoryID] where CategoryID ='" + typeID+ "'";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public List<String> getType()
        {
            Connection connect = new Connection();
            connect.open();
            List<String> roomTypeList = new List<String>();
            String query = "SELECT * FROM [RoomCategoryID]";
            System.Data.DataTable data = connect.executeQuery(query);
            foreach (System.Data.DataRow item in data.Rows)
            {
                roomTypeList.Add(item["CategoryID"].ToString());
            }
            connect.close();
            return roomTypeList;

        }
    }
}
