using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTranferObject;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public class RentBUS
    {
        private static RentBUS instance;
        public static RentBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RentBUS();
                }
                return instance;
            }
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = RentDAO.Instance.displayAll();
        }
       /* public Boolean addReservation(RentDTO reser)
        {
            return RentDAO.Instance.addReservation(reser);
        }*/
       /* public int getID()
        {
            int ID = 1;
            List<int> reserList = RentDTO.Instance.getID();
            foreach (int reser in reserList)
            {
                if (reser == ID)
                {
                    ID++;
                }
                else
                {
                    return ID;
                }
            }
            return ID;
        }*/
    }
}
