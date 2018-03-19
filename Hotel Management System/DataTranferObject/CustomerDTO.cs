using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class CustomerDTO
    {
        private String cID;
        private String passportID;
        private String firstName;
        private String lastName;
        private String birthday;
        private String sex; 
        private String phone;
        private String email;
        private String address;
        private int vIP;
        private float money;

        public CustomerDTO(string cID, string passportID, string firstName, string lastName, string birthday, string sex, string phone, string email, string address, int vIP, float money)
        {
            this.cID = cID;
            this.passportID = passportID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.sex = sex;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.vIP = vIP;
            this.money = money;
        }

        public string CID { get => cID; set => cID = value; }
        public string PassportID { get => passportID; set => passportID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public int VIP { get => vIP; set => vIP = value; }
        public float Money { get => money; set => money = value; }
    }
}
