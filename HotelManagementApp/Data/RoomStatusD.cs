using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RoomStatusD
    {
        public static readonly string TABLE_RoomStatus = "[HotelManagementSystem].[dbo].[RoomStatus]";
        public List<RoomStatusDTO> getListRoomStatus()
        {
            List<RoomStatusDTO> list = new List<RoomStatusDTO>();
            try
            {
                using (SqlConnection conn = ConfigData.getConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM {TABLE_RoomStatus}", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new RoomStatusDTO(reader["RStatus"].ToString(), reader["RSDescription"].ToString()));
                    }
                }
            }
            catch (Exception ex) { throw new Exception($"Lỗi ở Data Layer - RoomStatusD: {ex.Message}"); }
            return list;
        }
    }
}
