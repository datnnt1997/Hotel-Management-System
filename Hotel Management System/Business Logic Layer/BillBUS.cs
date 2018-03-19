using DataAccessLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public class BillBUS
    {
        private static BillBUS instance;
        public static BillBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillBUS();
                }
                return instance;
            }
        }
        public Boolean addbill(BillDTO bill)
        {
            return BillDAO.Instance.addbill(bill);
        }

        public void displayAll(DataGridView data)
        {
            data.DataSource = BillDAO.Instance.displayAll();
        }
        public int getID()
        {
            int ID = 1;
            List<int> billList = BillDAO.Instance.getID();
            foreach (int bill in billList)
            {
                if (bill == ID)
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
