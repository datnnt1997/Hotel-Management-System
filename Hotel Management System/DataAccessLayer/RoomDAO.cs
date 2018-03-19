using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomDAO();
                }
                return instance;
            }
        }
        public Boolean addRoom(RoomDTO newRoom)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Room] VALUES(N'" + newRoom.RID1 + "',N'" + newRoom.RentID1 + "',N'" + newRoom.Location + "',N'"
                            + newRoom.Type + "',N'" + newRoom.Status + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public RoomDTO searchRoom(String roomID)
        {
            RoomDTO room = null;
            Connection connect = new Connection();
            String query = "Select * From Room where RID='" + roomID + "'";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    String rID = Reader["RID"].ToString();
                    String rentID = Reader["RentID"].ToString();
                    String location = Reader["Location"].ToString();
                    String type = Reader["Type"].ToString();
                    String status = Reader["Status"].ToString();
                    room = new RoomDTO(rID, rentID, location, type, status);
                }
                connect.close();
            }
            return room;
        }
        public String getType(String roomID)
        {
            Connection connect = new Connection();
            connect.open();
            RoomDTO room = null;
            String query = "SELECT * FROM [Room] WHERE RID='" + roomID + "'";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                String ID = item["RID"].ToString();
                String rentID = item["RentID"].ToString();
                String price = item["Location"].ToString();
                String Type = item["Type"].ToString();
                String status = item["Status"].ToString();
                room=new RoomDTO(ID, rentID, price, Type, status);

            }
            connect.close();
            return room.Type;

        }
        public String getRent(String roomID)
        {
            Connection connect = new Connection();
            connect.open();
            RoomDTO room = null;
            String query = "SELECT * FROM [Room] WHERE RID='" + roomID + "'";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                String ID = item["RID"].ToString();
                String rentID = item["RentID"].ToString();
                String price = item["Location"].ToString();
                String Type = item["Type"].ToString();
                String status = item["Status"].ToString();
                room = new RoomDTO(ID, rentID, price, Type, status);

            }
            connect.close();
            if (room == null) return null;
            return room.RentID1;

        }
        public Boolean updateRoom(RoomDTO room)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Room] SET RentID=N'" +room.RentID1  + "', Location = N'" + room.Location + "', Type =N'" + room.Type
                + "',Status =N'" + room.Status + "'where RID =N'"+room.RID1+"';";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean updateRoomStatus(String ID, String Status)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Room] SET Status =N'" + Status + "'where RID =N'" + ID + "';";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean updateOccupation(String type)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Room] SET Type=N'Null'" + "where Type =N'" + type + "';";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }

        public Boolean updateRent(int reserID ,String roomID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Room] SET RentID=" +reserID + "where RID =N'" + roomID + "';";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean deleteRoom(String ID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [Room] where RID =N'" + ID + "';";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;


        }
        public List<RoomDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<RoomDTO> roomList = new List<RoomDTO>();
            String query = "SELECT * FROM [Room]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {   
                String ID = item["RID"].ToString();
                String rentID = item["RentID"].ToString();
                String price = item["Location"].ToString();
                String Type = item["Type"].ToString();
                String status = item["Status"].ToString();
                roomList.Add(new RoomDTO(ID, rentID, price, Type, status));

            }
            connect.close();
            return roomList;

        }
        public Boolean addRoomFa(RoomFacilitiesDTO roomFa)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [RoomFacilities] VALUES(N'" + roomFa.RID1+ "',N'" + roomFa.FID1 + "','"+ roomFa.Quantity + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }

        public List<RoomDTO> getRoom(String type)
        {
            Connection connect = new Connection();
            connect.open();
            List<RoomDTO> roomList = new List<RoomDTO>();
            String query = "SELECT * FROM [Room] where Type='"+type+"'";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    String rID = Reader["RID"].ToString();
                    String rentID = Reader["RentID"].ToString();
                    String location = Reader["Location"].ToString();
                    String rtype = Reader["Type"].ToString();
                    String status = Reader["Status"].ToString();
                    roomList.Add(new RoomDTO(rID, rentID, location, rtype, status));

                }
            }
            connect.close();
            return roomList;
        }



    }
}
