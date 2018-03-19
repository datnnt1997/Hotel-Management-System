using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;
using System.Data;

namespace DataAccessLayer
{
    public class PromotionDAO
    {
        private static PromotionDAO instance;
        public static PromotionDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PromotionDAO();
                }
                return instance;
            }
        }
        public Boolean addPromotion(PromotionDTO promotion)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "INSERT INTO [Promotion] VALUES('" + promotion.ID + "',N'" + promotion.Name + "','" + promotion.Value + "',N'"
                            + promotion.Condition + "',N'" + promotion.Time + "',N'" + promotion.Description + "')";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public List<PromotionDTO> displayAll()
        {
            Connection connect = new Connection();
            connect.open();
            List<PromotionDTO> promotionList = new List<PromotionDTO>();
            String query = "SELECT * FROM [Promotion]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
                String name = item["Name"].ToString();

                String condition = item["Condition"].ToString();
                String time = item["Time"].ToString();
                String description = item["Description"].ToString();
                int ID = (int)item["PromotionID"];
                int value = (int)item["Value"];
                DateTime timePro = DateTime.Parse(time);
                if (timePro < DateTime.Now)
                {
                    deletePromotion(ID);
                }
                else
                {
                    promotionList.Add(new PromotionDTO(ID, name, value, condition, time, description));
                }
            }
            connect.close();
            return promotionList;

        }
        public List<int> getID()
        {
            Connection connect = new Connection();
            connect.open();
            List<int> IDList = new List<int>();
            String query = "SELECT * FROM [Promotion]";
            DataTable data = connect.executeQuery(query);
            foreach (DataRow item in data.Rows)
            {
   
                int ID = (int)item["PromotionID"];
    

                IDList.Add(ID);
            }
            connect.close();
            return IDList;

        }

        public Boolean updatePromotion(PromotionDTO promotion)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "UPDATE[Promotion] SET Name = N'" + promotion.Name + "',Value = '" + promotion.Value + "',Condition = N'" + promotion.Condition + "',Time = N'" + promotion.Time + "',Description = N'" + promotion.Description + "' where PromotionID =" + promotion.ID + ";";
            if (connect.insertQuery(strQuery))
            {
                connect.close();
                return true;
            }
            connect.close();
            return false;
        }
        public Boolean deletePromotion(int ID)
        {
            Connection connect = new Connection();
            connect.open();
            String strQuery = "DELETE FROM [Promotion] where PromotionID='" + ID + "'";
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
