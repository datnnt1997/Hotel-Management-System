using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data;

namespace DataAccessLayer
{
    public class VIPDAO
    {
        private static VIPDAO instance;
        public static VIPDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VIPDAO();
                }
                return instance;
            }
        }

        public Boolean addVIP(VIPDTO vip)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [VIP] VALUES('" + vip.Level + "','" + vip.Value + "','" + vip.Condition + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public List<VIPDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<VIPDTO> VIPList = new List<VIPDTO>();
            String query = "SELECT * FROM [VIP]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int level = Int32.Parse( item["VipLevel"].ToString());
                int value = Int32.Parse(item["Value"].ToString());
                int condition = Int32.Parse(item["Condition"].ToString());
                VIPList.Add(new VIPDTO(level,value,condition));

            }
            connect.close();
            return VIPList;

        }
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> vipList = new List<int>();
            String query = "SELECT * FROM [VIP]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                int level = Int32.Parse(item["VipLevel"].ToString());


                vipList.Add(level);
            }
            connect.close();
            return vipList;

        }
        public int getValue(int vip)
        {
            Connection connect = new Connection();
            connect.open();
            int value = 0;
            String query = "SELECT * FROM [VIP] Where VipLevel="+vip+";";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {

                value = Int32.Parse(item["Value"].ToString());

            }
            connect.close();
            return value;

        }

        public Boolean updateVIP(VIPDTO vip)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[VIP] SET Value= '" + vip.Value+ "',Condition = '" + vip.Condition + "'where VipLevel =" + vip.Level + ";";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean deleteVIP(int level)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [VIP] where VipLevel =" + level + ";";
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
