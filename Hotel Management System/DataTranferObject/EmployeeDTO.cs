using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class EmployeeDTO
    {
        private int eID;
        private String firstName;
        private String lastName;
        private String birthday;
        private String sex;
        private String phone;
        private String email;
        private String address;
        private String occupation;
        private float salary;

        public EmployeeDTO(int eID, string firstName, string lastName, string birthday, string sex, String phone, string email, string address, string occupation, float salary)
        {
            this.eID = eID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.sex = sex;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.occupation = occupation;
            this.salary = salary;
        }

        public int EID { get => eID; set => eID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public String Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public float Salary { get => salary; set => salary = value; }
    }
}
