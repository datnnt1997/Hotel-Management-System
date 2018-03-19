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
    public class ReservationDAO
    {
        private static ReservationDAO instance;
        public static ReservationDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReservationDAO();
                }
                return instance;
            }
        }
        public List<ReservationDTO> getRoomReservation(String roomID)
        {
            List<ReservationDTO> room = new List<ReservationDTO>();
            Connection connect = new Connection();
            String query = "SELECT * FROM [Reservation] where RID=N'" + roomID + "'";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    int ReserID = Int32.Parse(Reader["ReserID"].ToString());
                    String CID = Reader["CID"].ToString();
                    int EID = Int32.Parse(Reader["EID"].ToString());
                    String RID = Reader["RID"].ToString();
                    String CheckIn = Reader["CheckIn"].ToString();
                    String CheckOut = Reader["CheckOut"].ToString();
                    String Status = Reader["Status"].ToString();
                    room.Add(new ReservationDTO(ReserID, CID, EID, RID, CheckIn, CheckOut, Status));
                }
            }
            connect.close();
            return room;
        }

        public ReservationDTO searchReservation(String rentID)
        {
            ReservationDTO reservation = null;
            Connection connect = new Connection();
            String query = "SELECT * FROM [Reservation] where ReserID=N'" + rentID + "'";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    int ReserID = Int32.Parse(Reader["ReserID"].ToString());
                    String CID = Reader["CID"].ToString();
                    int EID = Int32.Parse(Reader["EID"].ToString());
                    String RID = Reader["RID"].ToString();
                    String CheckIn = Reader["CheckIn"].ToString();
                    String CheckOut = Reader["CheckOut"].ToString();
                    String Status = Reader["Status"].ToString();
                    reservation=new ReservationDTO(ReserID, CID, EID, RID, CheckIn, CheckOut, Status);
                }
            }
            connect.close();
            return reservation;
        }
        public Boolean updateReservation(ReservationDTO reservation)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Reservation] SET  Status =N'" + reservation.Status + "'where ReserID =" + reservation.ReserID + ";"; 
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean deleteReservation(int ID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [Reservation] where ReserID =" + ID + ";";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean addReservation(ReservationDTO reser)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Reservation] VALUES('" + reser.ReserID + "',N'" + reser.CID + "','" + reser.EID + "',N'" 
                + reser.RID +"',N'" + reser.CheckIn +"',N'" + reser.CheckOut +"',N'" + reser.Status + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }

        public List<ReservationDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<ReservationDTO> reserList = new List<ReservationDTO>();
            String query = "SELECT * FROM [Reservation]";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    int ReserID = Int32.Parse(Reader["ReserID"].ToString());
                    String CID = Reader["CID"].ToString();
                    int EID = Int32.Parse(Reader["EID"].ToString());
                    String RID = Reader["RID"].ToString();
                    String CheckIn = Reader["CheckIn"].ToString();
                    String CheckOut = Reader["CheckOut"].ToString();
                    String Status = Reader["Status"].ToString();
                    reserList.Add(new ReservationDTO(ReserID, CID, EID, RID, CheckIn, CheckOut, Status));
                }
            }
            connect.close();
            return reserList;

        }

        public List<ReservationDTO> displaySearch(String cID)
        {
            Connection connect = new Connection();
            connect.open();
            List<ReservationDTO> reserList = new List<ReservationDTO>();
            String query = "SELECT * FROM [Reservation]";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    String CID = Reader["CID"].ToString();
                    String Status = Reader["Status"].ToString();
                    if (CID.Equals(cID) && !Status.Equals("CheckOut"))
                    {
                        int ReserID = Int32.Parse(Reader["ReserID"].ToString());
                        int EID = Int32.Parse(Reader["EID"].ToString());
                        String RID = Reader["RID"].ToString();
                        String CheckIn = Reader["CheckIn"].ToString();
                        String CheckOut = Reader["CheckOut"].ToString();
                        reserList.Add(new ReservationDTO(ReserID, CID, EID, RID, CheckIn, CheckOut, Status));
                    }
                }
            }
            connect.close();
            return reserList;

        }

        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> IDList = new List<int>();
            String query = "SELECT * FROM [Reservation]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["ReserID"].ToString());

                IDList.Add(ID);
            }
            connect.close();
            return IDList;

        }
    }
}
