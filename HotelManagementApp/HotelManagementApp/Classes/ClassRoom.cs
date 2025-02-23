using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp.Classes
{
    public class ClassRoom
    {
        private int RID;
        private int RFloor;
        private int RNo;
        private decimal RPricePerNight;
        private int RSID;
        private int RTID;
        private string RDescription;

        private static function function = new function();

        public static readonly string TABLE_NAME = "[HotelManagementSystem].[dbo].[Rooms]";
        public static readonly string TABLE_Rooms = @"
                            SELECT RID, 
                                   RFloor, 
                                   RNo, 
                                   RTType,
                                   RTBedCount, 
                                   RTMaxGuests,
                                   RSStatus,
                                   RPricePerNight,
                                   RDescription
                            FROM [HotelManagementSystem].[dbo].[Rooms] R
                                 JOIN [HotelManagementSystem].[dbo].Rooms_Type RT ON R.RTID = RT.RTID
                                 JOIN [HotelManagementSystem].[dbo].Rooms_Status RS ON R.RSID = RS.RSID";

        public ClassRoom() { }

        public ClassRoom(int rID)
        {
            this.RID = rID;
        }

        public ClassRoom(int RFloor, int RNo)
        {
            this.RFloor = RFloor;
            this.RNo = RNo;
        }

        public void setRoomsByRID()
        {
            string query = "SELECT * FROM " + ClassRoom.TABLE_NAME + " WHERE RID=@RID";
            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RID", this.RID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.RFloor = Convert.ToInt32(reader["RFloor"]);
                        this.RNo = Convert.ToInt32(reader["RNo"]);
                        this.RPricePerNight = Convert.ToDecimal(reader["RPricePerNight"]);
                        this.RTID = Convert.ToInt32(reader["RTID"]);
                        this.RSID = Convert.ToInt32(reader["RSID"]);
                        this.RDescription = reader["RDescription"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        public bool isExistsRoom()
        {
            string query = $"SELECT COUNT(*) FROM {TABLE_NAME}" + " WHERE RFloor=@RFloor AND RNo=@RNo";
            using (SqlConnection conn = function.getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RFloor", this.RFloor);
                    cmd.Parameters.AddWithValue("@RNo", this.RNo);
                    conn.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void insertIntoRooms()
        {
            string query = $"INSERT INTO {TABLE_NAME} (RFloor,RNo,RPricePerNight,RSID,RTID,RDescription) " +
                         $"VALUES ({this.RFloor},{this.RNo},{this.RPricePerNight},{this.RSID}," +
                                               $"{this.RTID},{this.RDescription})";

        }

        public int GetRID() { return RID; }
        public void SetRID(int value) { RID = value; }

        public int GetRFloor() { return RFloor; }
        public void SetRFloor(int value) { RFloor = value; }

        public int GetRNo() { return RNo; }
        public void SetRNo(int value) { RNo = value; }

        public int GetRSID() { return RSID; }
        public void SetRSID(int value) { RSID = value; }

        public int GetRTID() { return RTID; }
        public void SetRTID(int value) { RTID = value; }

        public string GetRDescription() { return RDescription; }
        public void SetRDescription(string value) { RDescription = value; }
    }
}
