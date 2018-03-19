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
    public class CompensatoryBUS
    {
        private static CompensatoryBUS instance;
        public static CompensatoryBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CompensatoryBUS();
                }
                return instance;
            }
        }
        public int getID()
        {
            int ID = 1;
            List<int> productList = CompensatoryDAO.Instance.getID();
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
        public Boolean addproduct(CompensatoryDTO product)
        {
            return CompensatoryDAO.Instance.addCompensatory(product);
        }
        public Boolean updateproduct(CompensatoryDTO product)
        {
            return CompensatoryDAO.Instance.updateCompensatory(product);
        }
        public Boolean deleteproduct(int ID)
        {
            return CompensatoryDAO.Instance.deleteCompensatory(ID);
        }
        public Boolean deleterequest(int ID)
        {
            return CompensatoryDAO.Instance.deleteRequest(ID);
        }
        public List<CompensatoryDTO> getBill(int rentID)
        {
            return CompensatoryDAO.Instance.getBill(rentID);
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = CompensatoryDAO.Instance.displayAll();
        }

    }
}
