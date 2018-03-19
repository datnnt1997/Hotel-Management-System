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
    public class ServiceBUS
    {
            private static ServiceBUS instance;
            public static ServiceBUS Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new ServiceBUS();
                    }
                    return instance;
                }
            }
            // Thêm Service mới 
            public Boolean addService(ServiceDTO service)
            {
                return ServiceDAO.Instance.addService(service);
            }
            // Hiển thị danh sách Service
            public void displayAll(DataGridView data)
            {
                data.DataSource = ServiceDAO.Instance.displayAll();
            }
            // Lấy ID mới
            public int getID()
            {
                int ID = 1;
                List<int> IDList = ServiceDAO.Instance.getID();
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
            // Cập nhật Service đã tồn tại
            public Boolean updateService(ServiceDTO service)
            {
                return ServiceDAO.Instance.updateService(service);
            }
            // Xóa Service đã tồn tại
            public Boolean deleteService(int ID)
            {
                return ServiceDAO.Instance.deleteService(ID);
            }
            public ServiceDTO searchService(int ID)
            {
            return ServiceDAO.Instance.searchService(ID);
            }
        // Lấy tên service
                public String getName(int SID)
                {
                    return ServiceDAO.Instance.getName(SID);
                }
    }
}
