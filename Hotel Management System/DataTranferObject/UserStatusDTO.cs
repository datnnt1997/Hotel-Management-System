using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class UserStatusDTO
    {
        private int iD;
        private String username;
        private String passsword;
        private int eID;
        private String Occuppation;

        public UserStatusDTO(int iD, string username, string passsword, int eID, string occuppation)
        {
            this.iD = iD;
            this.username = username;
            this.passsword = passsword;
            this.eID = eID;
            Occuppation = occuppation;
        }

        public int ID { get => iD; set => iD = value; }
        public string Username { get => username; set => username = value; }
        public string Passsword { get => passsword; set => passsword = value; }
        public int EID { get => eID; set => eID = value; }
        public string Occuppation1 { get => Occuppation; set => Occuppation = value; }
    }
}
