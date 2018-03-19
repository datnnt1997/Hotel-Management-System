using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTranferObject;

namespace Business_Logic_Layer
{
    public class UserStatusBUS
    {
        private static UserStatusBUS instance;
        public static UserStatusBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserStatusBUS();
                }
                return instance;
            }
        }
        public void setAccout(UserStatusDTO user)
        {
            UserStatusDAO.Instance.add(user);
        }
        public int getEID()
        {
            return UserStatusDAO.Instance.getEID();
        }
        public String getPass()
        {
            return UserStatusDAO.Instance.getPass();
        }
        public String getOccupation()
        {
            return UserStatusDAO.Instance.getOccupation();
        }
    }
}
