using DAO_QuanLY;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class RoomDetailBUS
    {
        public static DataTable GetRoomDetailList(string RoomId)
        {
            return RoomDetailDAO.GetRoomDetailList(RoomId);
        }
        public static bool InsertRoomDetail(RoomDetailDTO room)
        {
            if (RoomDAO.CheckRoomByID(room.RoomID) || string.IsNullOrWhiteSpace(room.RoomID))
            {
                return false;
            }
            return RoomDetailDAO.InsertRoomDetail(room);
        }
        public static bool UpdateRoomDetail(RoomDetailDTO room)
        {
            if (RoomDAO.CheckRentedRoomByID(room.RoomID))
            {
                return false;
            }
            return RoomDetailDAO.UpdateRoomDetail(room);
        }
        public static bool DeleteRoomDetail(string RoomID)
        {
            if (RoomDAO.CheckRentedRoomByID(RoomID))
            {
                return false;
            }
            return RoomDetailDAO.DeleteRoomDetail(RoomID);
        }
        
        //khach hang
        public static DataTable GetRoomDetailListCustomer(string RoomId)
        {
            return RoomDetailDAO.GetRoomDetailList(RoomId);
        }
        public static bool RoomDetail_InsertCustomer(string RoomId, string CMND, int MA_LOAI_KHACH, string TEN_KHACH, string DIA_CHI)
        {
            if (RoomDAO.CheckRoomByID(RoomId) || string.IsNullOrWhiteSpace(RoomId))
            {
                return false;
            }
            return RoomDetailDAO.RoomDetail_InsertCustomer(RoomId,  CMND,  MA_LOAI_KHACH,  TEN_KHACH,  DIA_CHI);

        }
        public static bool RoomDetail_DeleteCustomer(string RoomId, string CMND)
        {
            if (RoomDAO.CheckRoomByID(RoomId) || string.IsNullOrWhiteSpace(RoomId))
            {
                return false;
            }
            return RoomDetailDAO.RoomDetail_DeleteCustomer(RoomId,  CMND);

        }
    }
}
