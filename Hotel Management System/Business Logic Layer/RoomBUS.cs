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
    public class RoomBUS
    {
        private static RoomBUS instance;
        public static RoomBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomBUS();
                }
                return instance;
            }
        }
        public Boolean updateRoom(RoomDTO Room)
        {
            if (RoomDAO.Instance.updateRoom(Room))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean updateRoomStatus(String ID, String status)
        {
            if (RoomDAO.Instance.updateRoomStatus(ID,status))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean updateOccupation(String type)
        {
            if (RoomDAO.Instance.updateOccupation(type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean updateRent(int rentID,String RoomID)
        {
            if (RoomDAO.Instance.updateRent(rentID, RoomID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean deleteRoom(String RoomID)
        {
            if (RoomDAO.Instance.deleteRoom(RoomID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean addRoom(RoomDTO newRoom)
        {
            if (RoomDAO.Instance.addRoom(newRoom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = RoomDAO.Instance.displayAll();
        }
        public List<RoomDTO> display()
        {
            return RoomDAO.Instance.displayAll();
        }
        public RoomDTO searchRoom(String roomID)
        {
            return RoomDAO.Instance.searchRoom(roomID);
        }
        public String getType(String roomID)
        {
            return RoomDAO.Instance.getType(roomID);
        }
        public String getRent(String roomID)
        {
            return RoomDAO.Instance.getRent(roomID);
        }
        public RoomDTO getRoom(String type,String checkIn, String checkOut)
        {
            DateTime timeIn = DateTime.Parse(checkIn);
            DateTime timeOut = DateTime.Parse(checkOut);
            List<RoomDTO> listroom = RoomDAO.Instance.getRoom(type);
            foreach(RoomDTO room in listroom)
            {
                List<ReservationDTO> listreservation=ReservationDAO.Instance.getRoomReservation(room.RID1);
                int count = 0;
                foreach(ReservationDTO reservation in listreservation)
                {   if (count > 0) break;
                    DateTime resTimeIn = DateTime.Parse(reservation.CheckIn);
                    DateTime resTimeOut = DateTime.Parse(reservation.CheckOut);
                    if (timeIn >= resTimeIn && timeIn <= resTimeOut) count++;
                    if (timeIn <= resTimeIn && timeOut >= resTimeIn) count++;
                }
                if (count == 0) return room;
            }
            return null;
        }
        public Boolean CheckID(String ID)
        {
            List<RoomDTO> list = RoomDAO.Instance.displayAll();
            foreach(RoomDTO room in list)
            {
                if (room.RID1.Equals(ID)) return false;
            }
            return true;
        }
    }
}
