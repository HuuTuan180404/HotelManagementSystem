using DataTransferObject;
using HotelManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RoomTypeD
    {
        public static readonly string TABLE_RoomType = "[HotelManagementSystem].[dbo].[RoomType]";

        public List<RoomTypeDTO> getListRoomType()
        {
            List<RoomTypeDTO> list = new List<RoomTypeDTO>();

            using (SqlConnection conn = ConfigData.getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {TABLE_RoomType}", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RoomTypeDTO(reader["RType"].ToString(),
                                             Convert.ToInt32(reader["RTBedCount"]),
                                             Convert.ToInt32(reader["RTMaxGuests"]),
                                             reader["RTDescription"].ToString()));
                }
            }
            return list;
        }
    }
}
