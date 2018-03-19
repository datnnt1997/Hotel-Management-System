using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace Business_Logic_Layer
{
    public class VIPBUS
    {
        private static VIPBUS instance;
        public static VIPBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VIPBUS();
                }
                return instance;
            }
        }
        public Boolean addVIP(VIPDTO vip)
        {
            return VIPDAO.Instance.addVIP(vip);
        }
        public int getValue(int vip)
        {
            return VIPDAO.Instance.getValue(vip);
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = VIPDAO.Instance.displayAll();
        }
        public int checkVIP(float money)
        {
            int level = 0;
           List<VIPDTO> list= VIPDAO.Instance.displayAll();
            foreach(VIPDTO vip in list)
            {
                if (money <= vip.Value)
                {
                    return level;
                }
                else
                {
                    level = vip.Level;
                }

            }
            return level;
        }
        public int getID()
        {
            int ID = 0;
            List<int> promotionList = VIPDAO.Instance.getID();
            foreach (int pro in promotionList)
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
        public Boolean updateVIP(VIPDTO vip)
        {
            return VIPDAO.Instance.updateVIP(vip);
        }
        public Boolean deleteVIP(int level)
        {
            return VIPDAO.Instance.deleteVIP(level);
        }
    }
}
