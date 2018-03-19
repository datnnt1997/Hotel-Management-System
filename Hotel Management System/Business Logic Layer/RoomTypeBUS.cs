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
    public class RoomTypeBUS
    {
        private static RoomTypeBUS instance;
        public static RoomTypeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomTypeBUS();
                }
                return instance;
            }
        }

        public Boolean addRoomType(RoomTypeDTO roomType)
        {
            return RoomTypeDAO.Instance.addRoomType(roomType);
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = RoomTypeDAO.Instance.displayAll();
        }
        public Boolean updateRoomType(RoomTypeDTO roomType)
        {
            return RoomTypeDAO.Instance.updateRoomType(roomType);
        }
        public Boolean deleteRoomType(String typeID)
        {
            return RoomTypeDAO.Instance.deleteRoomType(typeID);
        }
        public float getPrice(String type)
        {
            return RoomTypeDAO.Instance.getPrice(type);
        }
        public void getType(ComboBox box)
        {
            List<String> typeList=RoomTypeDAO.Instance.getType();
            box.Items.Clear();
            foreach (String strTmp in typeList) {
                box.Items.Add(strTmp);
             }
        }
        public Boolean CheckID(String ID)
        {
            List<RoomTypeDTO> list = RoomTypeDAO.Instance.displayAll();
            foreach (RoomTypeDTO room in list)
            {
                if (room.TypeID.Equals(ID)) return false;
            }
            return true;
        }

    }
}
