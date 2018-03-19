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
    public class ReservationBUS
    {
        private static ReservationBUS instance;
        public static ReservationBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReservationBUS();
                }
                return instance;
            }
        }
        public void displayAll(DataGridView data)
        {
            data.DataSource = ReservationDAO.Instance.displayAll();
        }
        public void displaySearch(DataGridView data,String CID)
        {
            data.DataSource = ReservationDAO.Instance.displaySearch(CID);
        }
        public ReservationDTO searchReservation(String rentID, String roomID)
        {
            if (rentID != String.Empty)
            {
               return ReservationDAO.Instance.searchReservation(rentID);
                
            }
            else
            {
                rentID = RoomBUS.Instance.getRent(roomID);
                return ReservationDAO.Instance.searchReservation(rentID);
            }

        }
        public Boolean addReservation(ReservationDTO reser)
        {
            return ReservationDAO.Instance.addReservation(reser);
        }
        public int getID()
        {
            int ID = 1;
            List<int> reserList = ReservationDAO.Instance.getID();
            foreach (int reser in reserList)
            {
                if (reser == ID)
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
        public void update()
        {
            List<ReservationDTO> listreservation = ReservationDAO.Instance.displayAll();
            foreach(ReservationDTO reservation in listreservation)
            {
                if (DateTime.Parse(DateTime.Parse(reservation.CheckIn).ToShortDateString()) < DateTime.Parse((DateTime.Now.ToShortDateString())) )
                {
                    if (reservation.Status.Equals("Reserved") )
                    {
                        deleteReservation(reservation.ReserID);
                    }
                }
                if (reservation.Status.Equals("Fail")){
                    deleteReservation(reservation.ReserID);
                }
            }
        }
        public Boolean updateReservation(ReservationDTO reser)
        {
            return ReservationDAO.Instance.updateReservation(reser);
        }
        public Boolean deleteReservation(int ID)
        {
            return ReservationDAO.Instance.deleteReservation(ID);
        }
    }
}
