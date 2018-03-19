using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        public Boolean insertUser(UserDTO user)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "insert into [USER] values(N'" + user.EID +"',N'"+ user.UserName + "',N'" +user.PassWord + "')" ;
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;

        }
        public Boolean login(String username, String password)
        {
            Connection connect = new Connection();
            connect.open();
            String query = "SELECT * FROM [USER] WHERE username='" + username + "'and password='" + password + "'";
            DataTable data = connect.executeQuery(query);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            connect.close();

        }
        public UserDTO searchEmployee(String strEmployeeID)
        {
            UserDTO user = null;
            Connection connect = new Connection();
            String query = "Select * From [USER] where EID='" + strEmployeeID + "' ";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    String eID = Reader["EID"].ToString();

                    String username = Reader["username"].ToString();
                    String password = Reader["password"].ToString();



                    user = new UserDTO(eID,username,password);
                }
                connect.close();
            }
            return user;

        }
        public int searchEmployeeID(String username)
        {
            String eID = "";
           Connection connect = new Connection();
            String query = "Select * From [USER] where username='" + username + "' ";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    eID = Reader["EID"].ToString();

                }
                connect.close();
            }
            return Int32.Parse(eID);

        }
        public String searchPassword(String username)
        {
            String pass = "";
            Connection connect = new Connection();
            String query = "Select * From [USER] where username='" + username + "' ";
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
        public String searchOccupation(int EID)
        {
            String occupation = "";
            Connection connect = new Connection();
            String query = "Select * From [Employee] where EID='" + EID + "' ";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    occupation = Reader["Occupation"].ToString();
                }

                connect.close();
            }
            return occupation;

        }
        public Boolean deleteEmployee(String strEmployeeID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [USER] where EID='" + strEmployeeID + "'";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;


        }
        public Boolean updateEmployee(UserDTO user)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE [USER] SET password=N'" + user.PassWord + "'where EID='" + user.EID + "'";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean changePass(String pass,int EID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE [USER] SET password=N'" + pass + "'where EID=" + EID + "";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
    }
}
