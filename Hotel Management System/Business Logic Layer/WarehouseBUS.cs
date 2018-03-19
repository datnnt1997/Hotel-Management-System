using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using DataAccessLayer;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public class WarehouseBUS
    {
        private static WarehouseBUS instance;
        public static WarehouseBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WarehouseBUS();
                }
                return instance;
            }
        }
        public Boolean addproduct(WarehouseDTO product)
        {
            return WarehouseDAO.Instance.addproduct(product);
        }

        public void displayAll(DataGridView data)
        {
            data.DataSource = WarehouseDAO.Instance.displayAll();
        }
        public int getID()
        {
            int ID = 1;
            List<int> productList = WarehouseDAO.Instance.getID();
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
        public Boolean updateproduct(WarehouseDTO product)
        {
            return WarehouseDAO.Instance.updateproduct(product);
        }
        public Boolean deleteproduct(int ID)
        {
            return WarehouseDAO.Instance.deleteproduct(ID);
        }
    }
}
