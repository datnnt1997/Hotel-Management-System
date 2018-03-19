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
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        private string passportID;

        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeDAO();
                }
                return instance;
            }
        }
        public List<EmployeeDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<EmployeeDTO> employee = new List<EmployeeDTO>();
            String query = "SELECT * FROM [Employee]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int eID = Int32.Parse( item["EID"].ToString());
                
                String firstName = item["FirstName"].ToString();
                String lastName = item["LastName"].ToString();
                String birthday = item["Birthday"].ToString();
                String sex = item["Sex"].ToString();
                String phone = item["Phone"].ToString();

                String email = item["Email"].ToString();
                String address = item["Address"].ToString();
                String occupation = item["Occupation"].ToString();
                float salary = float.Parse( item["Salary"].ToString() );


                employee.Add(new EmployeeDTO(eID, firstName, lastName, birthday, sex,phone,email,address,occupation,salary));
            }
            connect.close();
            return employee;

        }
        public EmployeeDTO searchEmployee(String strEmployeeID)
        {
            EmployeeDTO employee = null;
            Connection connect = new Connection();
            String query = "Select * From Employee where EID='" + strEmployeeID + "' ";
            SqlCommand cmd = new SqlCommand(query, connect.open());
            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    int eID = Int32.Parse( Reader["EID"].ToString());

                    String firstName = Reader["FirstName"].ToString();
                    String lastName = Reader["LastName"].ToString();
                    String birthday = Reader["Birthday"].ToString();
                    String sex = Reader["Sex"].ToString();
                    String phone = Reader["Phone"].ToString();
                    String email = Reader["Email"].ToString();
                    String address = Reader["Address"].ToString();
                    String occupation = Reader["Occupation"].ToString();
                    float salary = float.Parse( Reader["Salary"].ToString());


                    employee = new EmployeeDTO(eID, firstName, lastName, birthday, sex, phone, email, address, occupation, salary);
                }
                connect.close();
            }
            return employee;

        }
        public Boolean updateEmployee(EmployeeDTO employee)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE Employee SET FirstName=N'" + employee.FirstName + "',LastName=N'" + employee.LastName + "'," +
                "Birthday='" + employee.Birthday + "',Sex='" + employee.Sex + "',Phone=N'" + employee.Phone + "',Email=N'" + employee.Email + "',Address=N'" + employee.Address + "',Occupation='" + employee.Occupation + "'," +
                "Salary='" + employee.Salary + "' where EID='" + employee.EID + "'";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean deleteEmployee(String strEmployeeID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [Employee] where EID='" + strEmployeeID + "'";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;


        }
        public Boolean insertEmployee(EmployeeDTO employee)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "insert into Employee values(" + employee.EID + ",N'" + employee.FirstName + "',N'" + employee.LastName + "',N'"
                            + employee.Birthday + "','" + employee.Sex + "',N'" + employee.Phone + "','" + employee.Email + "',N'"
                            + employee.Address + "',N'" + employee.Occupation + "'," + employee.Salary+ ")";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;

        }
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> productList = new List<int>();
            String query = "SELECT * FROM [Employee]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["EID"].ToString());


                productList.Add(ID);
            }
            connect.close();
            return productList;

        }
    }
}
