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
    public class FacilitiesBUS
    {
        private static FacilitiesBUS instance;
        public static FacilitiesBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FacilitiesBUS();
                }
                return instance;
            }
        }
        public Boolean addproduct(FacilitiesDTO product)
        {
            return FacilitiesDAO.Instance.addproduct(product);
        }

        public void displayAll(DataGridView data)
        {
            data.DataSource = FacilitiesDAO.Instance.displayAll();
        }
        public String getName(int FID)
        {
            return FacilitiesDAO.Instance.getName(FID);
        }
        public int getID()
        {
            int ID = 1;
            List<int> productList = FacilitiesDAO.Instance.getID();
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
        public Boolean updateproduct(FacilitiesDTO product)
        {
            return FacilitiesDAO.Instance.updateproduct(product);
        }
        public Boolean deleteproduct(int ID)
        {
            return FacilitiesDAO.Instance.deleteproduct(ID);
        }
    }
}

