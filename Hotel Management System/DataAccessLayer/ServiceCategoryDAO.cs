using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace DataAccessLayer
{
    public class ServiceCategoryDAO
    {
        private static ServiceCategoryDAO instance;
        public static ServiceCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceCategoryDAO();
                }
                return instance;
            }
        }
        // Thêm Type cho Service
        public Boolean addType(ServiceCategoryDTO type)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [ServiceCategory] VALUES('" + type.ID + "','" + type.Name + "','" + type.Status+ "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        // Lấy danh sách Type
        public List<ServiceCategoryDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<ServiceCategoryDTO> typeList = new List<ServiceCategoryDTO>();
            String query = "SELECT * FROM [ServiceCategory]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["CategoryID"].ToString());
                String name = item["Name"].ToString();
                String status = item["Status"].ToString();
                typeList.Add(new ServiceCategoryDTO(ID, name, status));

            }
            connect.close();
            return typeList;

        }
        // Lấy danh sách ID type
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> IDList = new List<int>();
            String query = "SELECT * FROM [ServiceCategory]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["CategoryID"].ToString());


                IDList.Add(ID);
            }
            connect.close();
            return IDList;

        }
        // Cập nhật lại Type của Service
        public Boolean updateType(ServiceCategoryDTO type)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[ServiceCategory] SET Name=N'" + type.Name + "',Status = '" + type.Status + "'where CategoryID =" + type.ID + ";";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        // Xóa Type đã tồn tại
        public Boolean deleteType(int ID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [ServiceCategory] where CategoryID =" + ID + ";";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;


        }
      
    }
}
