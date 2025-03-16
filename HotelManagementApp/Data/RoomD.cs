using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RoomD
    {
        public static readonly string TABLE_Rooms = "[HotelManagementSystem].[dbo].[Rooms]";

        private static readonly string ROOMS_DETAIL = @"
                                                        SELECT RId,
		                                                       R.RType,
		                                                       RTBedCount, 
		                                                       RTMaxGuests,
		                                                       RStatus,
		                                                       RPricePerNight,
		                                                       RDescription
	                                                    FROM [HotelManagementSystem].[dbo].[Rooms] R
		                                                     JOIN [HotelManagementSystem].[dbo].RoomType RT ON R.RType=RT.RType";

        public List<RoomDTO> getAllRooms()
        {
            List<RoomDTO> rooms = new List<RoomDTO>();
            using (SqlConnection conn = ConfigData.getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rooms", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(new RoomDTO(reader["RId"].ToString(),
                                          reader["RType"].ToString(),
                                          reader["RStatus"].ToString(),
                                          Convert.ToDecimal(reader["RPricePerNight"]),
                                          reader["RDescription"].ToString()));
                }
            }
            return rooms;
        }

        public DataSet getDataSetDetailAllRooms_FilterByStatus(string status)
        {
            try
            {
                using (SqlConnection conn = ConfigData.getConnection())
                {
                    string query = ROOMS_DETAIL + " WHERE RStatus = @RStatus";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RStatus", status);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        sqlDataAdapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi ở Data Layer: {ex.Message}");
            }
        }

        public DataSet getDataSetDetailAllRooms()
        {
            string query = ROOMS_DETAIL + " ORDER BY RId ASC";
            try
            {
                using (SqlConnection conn = ConfigData.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        sqlDataAdapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi ở Data Layer: {ex.Message}");
            }
        }

        public bool addRoom(RoomDTO room)
        {
            try
            {
                using (SqlConnection conn = ConfigData.getConnection())
                {
                    string query =  "";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        //cmd.Parameters.AddWithValue("@RStatus", status);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        sqlDataAdapter.Fill(dataSet);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi ở Data Layer: {ex.Message}");
                return false;
            }
           
        }

    }
}
