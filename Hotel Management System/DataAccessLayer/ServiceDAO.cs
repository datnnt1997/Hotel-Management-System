using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data;

namespace DataAccessLayer
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceDAO();
                }
                return instance;
            }
        }
        // Thêm Service
        public Boolean addService(ServiceDTO service)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Service] VALUES('" + service.ID + "',N'" + service.Name + "','" + service.TypeID + "',N'" 
                + service.Description + "','" + service.Price + "','"+ service.Status + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        // Lấy danh sách service
        public List<ServiceDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<ServiceDTO> serviceList = new List<ServiceDTO>();
            String query = "SELECT * FROM [Service]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int ID = Int32.Parse(item["ServiceID"].ToString());
                String name = item["Name"].ToString();
                int typeID = Int32.Parse(item["CatagoryID"].ToString());
                String description = item["Description"].ToString();
                float price = float.Parse(item["Price"].ToString());
                String status = item["Status"].ToString();
                serviceList.Add(new ServiceDTO(ID, name,typeID,description,price,status));

            }
            connect.close();
            return serviceList;

        }
        // Lấy danh sách ID service
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> IDList = new List<int>();
            String query = "SELECT * FROM [Service]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["ServiceID"].ToString());


                IDList.Add(ID);
            }
            connect.close();
            return IDList;

        }
        // Cập nhật lại Service
        public Boolean updateService(ServiceDTO service)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Service] SET Name=N'" + service.Name + "',CatagoryID = '" + service.TypeID+ "',Description =N'" + service.Description
                + "',Price = '" + service.Price + "',Status =N'" + service.Status+ "'where ServiceID =" +service.ID+ ";";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        // Xóa Service đã tồn tại
        public Boolean deleteService(int ID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [Service] where ServiceID =" + ID + ";";
            if (connect.executeDelete(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        // Lấy danh sách service
        public ServiceDTO searchService(int SID)
        {
            Connection connect = new Connection();
            connect.open();
            ServiceDTO service = null;
            String query = "SELECT * FROM [Service] where ServiceID =" + SID + ";";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int ID = Int32.Parse(item["ServiceID"].ToString());
                String name = item["Name"].ToString();
                int typeID = Int32.Parse(item["CatagoryID"].ToString());
                String description = item["Description"].ToString();
                float price = float.Parse(item["Price"].ToString());
                String status = item["Status"].ToString();
                 service = new ServiceDTO(ID, name, typeID, description, price, status);
            }
            connect.close();
            return service;

        }
        // Lấy tên service
        public String getName(int SID)
        {
            Connection connect = new Connection();
            connect.open();
            String name = "";
            String query = "SELECT * FROM [Service] where ServiceID =" + SID + ";";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                name = item["Name"].ToString();
            }
            connect.close();
            return name;

        }
    }
}
