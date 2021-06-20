using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAO_QuanLY
{
    public class RoomDetailDAO:DBconnection
    {
        public static DataTable GetRoomDetailList(string RoomId)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var query = $"SELECT * FROM CT_PHONG WHERE ROOM_ID='{RoomId}' AND IS_DELETE=0";

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                var dt = new DataTable();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool InsertRoomDetail(RoomDetailDTO room)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("RoomDetail_Insert", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ROOM_ID", room.RoomID));
                command.Parameters.Add(new SqlParameter("@HONG_VAT_TU", room.HONG_VAT_TU));
                command.Parameters.Add(new SqlParameter("@SUA_VAT_TU", room.SUA_VAT_TU));

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool UpdateRoomDetail(RoomDetailDTO room)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("RoomDetail_Update", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ROOM_ID", room.RoomID));
                command.Parameters.Add(new SqlParameter("@HONG_VAT_TU", room.HONG_VAT_TU));
                command.Parameters.Add(new SqlParameter("@SUA_VAT_TU", room.SUA_VAT_TU));

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool DeleteRoomDetail(string RoomID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var query = $"DELETE CT_PHONG WHERE ROOM_ID = '{RoomID}'";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        //list customer
        public static DataTable GetRoomDetailListCustomer(string RoomId)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command = new SqlCommand("RoomDetail_GetListCustomer", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ROOM_ID", RoomId));
                command.ExecuteNonQuery();
                var dt = new DataTable();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool RoomDetail_InsertCustomer(string RoomId,string CMND,int MA_LOAI_KHACH,string TEN_KHACH,string DIA_CHI)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("RoomDetail_InsertCustomer", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ROOM_ID", RoomId));
                command.Parameters.Add(new SqlParameter("@CMND", CMND));
                command.Parameters.Add(new SqlParameter("@MA_LOAI_KHACH", MA_LOAI_KHACH));
                command.Parameters.Add(new SqlParameter("@NAME", TEN_KHACH));
                command.Parameters.Add(new SqlParameter("@DIACHI", DIA_CHI));
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool RoomDetail_UpdateCustomer(string RoomId, string CMND, int MA_LOAI_KHACH, string TEN_KHACH, string DIA_CHI)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                var command = new SqlCommand("RoomDetail_UpdateCustomer", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ROOM_ID", RoomId));
                command.Parameters.Add(new SqlParameter("@CMND", CMND));
                command.Parameters.Add(new SqlParameter("@MA_LOAI_KHACH", MA_LOAI_KHACH));
                command.Parameters.Add(new SqlParameter("@NAME", TEN_KHACH));
                command.Parameters.Add(new SqlParameter("@DIACHI", DIA_CHI));
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool RoomDetail_DeleteCustomer(string RoomId, string CMND)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command = new SqlCommand("RoomDetail_DeleteCustomer", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ROOM_ID", RoomId));
                command.Parameters.Add(new SqlParameter("@CMND", CMND));

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
