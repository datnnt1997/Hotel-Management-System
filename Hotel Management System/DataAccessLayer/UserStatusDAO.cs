using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserStatusDAO
    {
        private static UserStatusDAO instance;
        public static UserStatusDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserStatusDAO();
                }
                return instance;
            }
        }
        public Boolean add(UserStatusDTO user)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[UserStatus] SET Username=N'" + user.Username + "',password = N'" + user.Passsword+ "' ,EID = '" + user.EID + "',Occuppation = '" + user.Occuppation1 + "'where ID =" + 0 + ";";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public int getEID()
        {
            String rEID = "";
            Connection connect = new Connection();
            String query = "Select * From [UserStatus] where ID='" + 0 + "' ";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    rEID = Reader["EID"].ToString();
                }

                connect.close();
            }
            return Int32.Parse(rEID);

        }
        public String getOccupation()
        {
            String rEID = "";
            Connection connect = new Connection();
            String query = "Select * From [UserStatus] where ID='" + 0 + "' ";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    rEID = Reader["Occuppation"].ToString();
                }

                connect.close();
            }
            return rEID;

        }
        public String getPass()
        {
            String pass= "";
            Connection connect = new Connection();
            String query = "Select * From [UserStatus] where ID='" + 0 + "' ";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    pass = Reader["password"].ToString();
                }

                connect.close();
            }
            return pass;

        }
    }
}
