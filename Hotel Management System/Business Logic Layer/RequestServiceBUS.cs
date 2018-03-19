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
    public class RequestServiceBUS
    {
        private static RequestServiceBUS instance;
        public static RequestServiceBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RequestServiceBUS();
                }
                return instance;
            }
        }
        public int getID()
        {
            int ID = 1;
            List<int> productList = RequestServiceDAO.Instance.getID();
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
        public Boolean addproduct(RequestServiceDTO product)
        {
            return RequestServiceDAO.Instance.addCompensatory(product);
        }
        public Boolean updateproduct(RequestServiceDTO product)
        {
            return RequestServiceDAO.Instance.updateCompensatory(product);
        }
        public Boolean deleteproduct(int ID)
        {
            return RequestServiceDAO.Instance.deleteCompensatory(ID);
        }
        public Boolean deleteRequest(int ID)
        {
            return RequestServiceDAO.Instance.deleteCompensatory(ID);
        }
        public List<RequestServiceDTO> getBill(int rentID)
        {
            return RequestServiceDAO.Instance.getBill(rentID);
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = RequestServiceDAO.Instance.displayAll();
        }
    }
}
