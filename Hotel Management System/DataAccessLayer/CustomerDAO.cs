using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }
        public List<CustomerDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<CustomerDTO> customer = new List<CustomerDTO>();
            String query = "SELECT * FROM [Customer]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                String cID = item["CID"].ToString();
                String passportID = item["PassportID"].ToString();
                String firstName = item["FirstName"].ToString();
                String lastName = item["LastName"].ToString();
                String birthday = item["Birthday"].ToString();
                String sex =  item["Sex"].ToString();
                String phone = item["Phone"].ToString();
                String email = item["Email"].ToString(); ;
                String address = item["Address"].ToString(); ;
                int vIP = (int)item["Vip"];
                float money = float.Parse(item["TotalMoney"].ToString());
                customer.Add(new CustomerDTO(cID, passportID, firstName, lastName, birthday, sex, phone, email, address, vIP, money));
            }
            connect.close();
            return customer;

        }

 
        public bool deleteCustomer(string string1, object strCustomerID, string string2, object strPassportID)
        {
            throw new NotImplementedException();
        }

        public Boolean insertCustomer(CustomerDTO cusNewCustomer)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Customer] VALUES(N'" + cusNewCustomer.CID + "',N'" + cusNewCustomer.PassportID + "',N'" + cusNewCustomer.FirstName + "',N'"
                            + cusNewCustomer.LastName + "',N'" + cusNewCustomer.Birthday + "',N'" + cusNewCustomer.Sex + "',N'" + cusNewCustomer.Phone + "',N'"
                            + cusNewCustomer.Email + "',N'" + cusNewCustomer.Address + "','" + cusNewCustomer.VIP + "','" + cusNewCustomer.Money + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;

        }
        public CustomerDTO searchCustomer(String strCustomerID, String strPassportID)
        {
            CustomerDTO customer = null;
            Connection connect = new Connection();
            String query = "Select * From Customer where CID='" + strCustomerID + "' Or PassportID='" + strPassportID + "'";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    String cID = Reader["CID"].ToString();
                    String passportID = Reader["PassportID"].ToString();
                    String firstName = Reader["FirstName"].ToString();
                    String lastName = Reader["LastName"].ToString();
                    String birthday = Reader["Birthday"].ToString();
                    String sex = Reader["Sex"].ToString();
                    String phone = Reader["Phone"].ToString();
                    String email = Reader["Email"].ToString(); ;
                    String address = Reader["Address"].ToString(); ;
                    int vIP = (int)Reader["Vip"];
                    float money = float.Parse((Reader["TotalMoney"].ToString()));
                    customer = new CustomerDTO(cID, passportID, firstName, lastName, birthday, sex, phone, email, address, vIP, money);
                }
                connect.close();
            }
            return customer;

        }
        public Boolean updateCustomer(CustomerDTO customer)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE Customer SET PassportID= N'" + customer.PassportID + "',FirstName=N'" + customer.FirstName + "',LastName=N'" + customer.LastName + "'," +
                "Birthday=N'" + customer.Birthday + "',Sex=N'" + customer.Sex + "',Phone=N'" + customer.Phone + "',Email=N'" + customer.Email + "',Address=N'" + customer.Address + "',Vip='" + customer.VIP + "'," +
                "TotalMoney='" + customer.Money + "' where CID='" + customer.CID + "'";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean updatemoney(String CID, int VIP,float money)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE Customer SET Vip='" + VIP + "'," +
                "TotalMoney='" + money + "' where CID='" +CID + "'";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public float getMoney(String ID)
        {
            float money = 0;
            Connection connect = new Connection();
            String query = "Select * From Customer where CID='" + ID +"'";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                     money = float.Parse((Reader["TotalMoney"].ToString()));
                }
                connect.close();
            }
            return money;

        }
        public Boolean deleteCustomer(String strCustomerID, String strPassportID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [Customer] where CID='" + strCustomerID + "' Or PassportID='" + strPassportID + "'";
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
