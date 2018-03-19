using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class RentDAO
    {
        private static RentDAO instance;
        public static RentDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RentDAO();
                }
                return instance;
            }
        }
        public Boolean addRent(RentDTO rent)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Rent] VALUES('" + rent.RentID + "',N'" + rent.CID + "',N'" + rent.EID + "',N'"
                            + rent.RID+ "',N'" + rent.CheckIn + "',N'" + rent.CheckOut + "',N'" + rent.Status + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;

        }
        public List<RentDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<RentDTO> rentList = new List<RentDTO>();
            String query = "SELECT * FROM [Reservation]";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    int ReserID = Int32.Parse(Reader["RentID"].ToString());
                    String CID = Reader["CID"].ToString();
                    int EID = Int32.Parse(Reader["EID"].ToString());
                    String RID = Reader["RID"].ToString();
                    String CheckIn = Reader["CheckIn"].ToString();
                    String CheckOut = Reader["CheckOut"].ToString();
                    String Status = Reader["Status"].ToString();
                    rentList.Add(new RentDTO(ReserID, CID, EID, RID, CheckIn, CheckOut, Status));
                }
            }
            connect.close();
            return rentList;

        }
    }
}
