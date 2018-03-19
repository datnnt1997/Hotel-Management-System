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
   public class EmployeeBUS
    {
        private static EmployeeBUS instance;
        public static EmployeeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeBUS();
                }
                return instance;
            }
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = EmployeeDAO.Instance.displayAll();
        }
        public EmployeeDTO searchEmployee(String strEmployeeID)
        {
            return EmployeeDAO.Instance.searchEmployee(strEmployeeID);
        }
        public Boolean updateEmployee(EmployeeDTO employee)
        {
            return EmployeeDAO.Instance.updateEmployee(employee);
        }
        public Boolean deleteEmployee(String strEmployeeID)
        {
            return EmployeeDAO.Instance.deleteEmployee(strEmployeeID);
        }
        public Boolean insertEmployee(EmployeeDTO cusNewEmployee)
        {
            return EmployeeDAO.Instance.insertEmployee(cusNewEmployee);
        }
        public int getID()
        {
            int ID = 0;
            List<int> productList = EmployeeDAO.Instance.getID();
            foreach (int pro in productList)
            {
                if (pro == ID)
                {
                    ID++;
                }
                else
                {
                    return ID;
                }
            }
            return ID;
        }
    }
}
