using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class UserDTO
    {
        private String eID;
        private String userName;
        private String passWord;

        public UserDTO(string eID, string userName, string passWord)
        {
            this.eID = eID;
            this.userName = userName;
            this.passWord = passWord;
        }

        public string EID { get => eID; set => eID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
    }
}
