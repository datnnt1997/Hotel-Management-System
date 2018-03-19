using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataTranferObject;
namespace Business_Logic_Layer
{
    public class UserBUS
    {
        private static UserBUS instance;
        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserBUS();
                }
                return instance;
            }
        }
        public Boolean Login(String username, String password)
        {
            UserDAO user = new UserDAO();
            return user.login(username, password);

        }
        public Boolean insertUser(UserDTO user)
        {
            return UserDAO.Instance.insertUser(user);
        }
        public UserDTO searchEmployee(String strEmployeeID)
        {
            return UserDAO.Instance.searchEmployee(strEmployeeID);
        }
        public int searchEmployeeID(String username)
        {
            return UserDAO.Instance.searchEmployeeID(username);
        }
        public String searchPassword(String username)
        {
            return UserDAO.Instance.searchPassword(username);
        }
        public Boolean changePassword(String pass, int EID)
        {
            return UserDAO.Instance.changePass(pass, EID);
        }
        public String searchOccupation(int EID)
        {
            return UserDAO.Instance.searchOccupation(EID);
        }
        public Boolean deleteEmployee(String strEmployeeID)
        {
            return UserDAO.Instance.deleteEmployee(strEmployeeID);
        }
        public Boolean updateEmployee(UserDTO employee)
        {
            return UserDAO.Instance.updateEmployee(employee);
        }
    }
}
