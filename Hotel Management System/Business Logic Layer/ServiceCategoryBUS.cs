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
    public class ServiceCategoryBUS
    {
        private static ServiceCategoryBUS instance;
        public static ServiceCategoryBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceCategoryBUS();
                }
                return instance;
            }
        }
        // Thêm Type mới 
        public Boolean addType(ServiceCategoryDTO type)
        {
            return ServiceCategoryDAO.Instance.addType(type);
        }
        // Hiển thị danh sách Type
        public void displayAll(DataGridView data)
        {
            data.DataSource = ServiceCategoryDAO.Instance.displayAll();
        }
        // Lấy ID mới
        public int getID()
        {
            int ID = 1;
            List<int> IDList = ServiceCategoryDAO.Instance.getID();
            foreach (int pro in IDList)
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
        // Cập nhật Type
        public Boolean updateType(ServiceCategoryDTO type)
        {
            return ServiceCategoryDAO.Instance.updateType(type);
        }
        // Xóa Type đã tồn tại
        public Boolean deleteType(int ID)
        {
            return ServiceCategoryDAO.Instance.deleteType(ID);
        }
        // Lấy Type Service 
        public void getType(ComboBox box)
        {
            List<ServiceCategoryDTO> typeList = ServiceCategoryDAO.Instance.displayAll();
            box.Items.Clear();
            foreach (ServiceCategoryDTO strTmp in typeList)
            {
                box.Items.Add(strTmp.Name);
            }
        }
        // Lấy Type Service 
        public int getTypeID(String name)
        {
            List<ServiceCategoryDTO> typeList = ServiceCategoryDAO.Instance.displayAll();
            foreach (ServiceCategoryDTO strTmp in typeList)
            {
                if (strTmp.Name.Equals(name)) return strTmp.ID;
            }
            return 0;
        }
        // Lấy Type Service 
        public String getTypeName(int ID)
        {
            List<ServiceCategoryDTO> typeList = ServiceCategoryDAO.Instance.displayAll();
            foreach (ServiceCategoryDTO strTmp in typeList)
            {
                if (strTmp.ID==ID) return strTmp.Name;
            }
            return "";
        }
    }
}
