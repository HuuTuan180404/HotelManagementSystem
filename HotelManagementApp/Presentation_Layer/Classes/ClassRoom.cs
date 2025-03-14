using System;
using System.Collections;
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
        public int RFloor { get; set; }
        public int RNo { get; set; }
        public decimal RPricePerNight { get; set; }
        public string RStatus { get; set; }
        public string RType { get; set; }
        public string RDescription { get; set; }

        public ClassRoom_Type roomType { get; set; }

        private static config_database function = new config_database();

        public static readonly string TABLE_NAME = "[HotelManagementSystem].[dbo].[Rooms]";

        public static readonly string TABLE_ROOMS_DETAIL = @"
            SELECT CONCAT('Roo',[RFloor],'-',[RNo]) AS RoomID,
                   RType,
                   RTBedCount, 
                   RTMaxGuests,
                   RStatus,
                   RPricePerNight,
                   RDescription
	        FROM [HotelManagementSystem].[dbo].[Rooms] R";


        public ClassRoom() { }

        public ClassRoom(string roomID)
        {
            roomID = roomID.Substring(3);
            string[] s = roomID.Split('-');
            this.RFloor = int.Parse(s[0]);
            this.RNo = int.Parse(s[1]);
            setByRoomID();
        }

        public ClassRoom(int RFloor, int RNo)
        {
            this.RFloor = RFloor;
            this.RNo = RNo;
            setByRoomID();
        }

        public ClassRoom(int floor, int no, decimal price, string status, string type, string description) : this(floor, no)
        {
            RPricePerNight = price;
            RStatus = status;
            RType = type;
            RDescription = description;
        }

        private void setByRoomID()
        {
            string query = $"SELECT * FROM {ClassRoom.TABLE_NAME} WHERE RFloor=@RFloor AND RNo=@RNo";
            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RFloor", this.RFloor);
                    cmd.Parameters.AddWithValue("@RNo", this.RNo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.RPricePerNight = Convert.ToDecimal(reader["RPricePerNight"]);
                        this.RStatus = reader["RStatus"].ToString();
                        this.RType = reader["RType"].ToString();
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

        public ClassRoom_Type getRoomType()
        {
            return new ClassRoom_Type(RType);
        }

        public string getRoomID()
        {
            return $"Roo{this.RFloor}-{this.RNo}";
        }

        public bool delete()
        {
            string query = $"DELETE FROM {TABLE_NAME} WHERE RFloor=@RFloor AND RNo=@RNo";

            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Parameters.AddWithValue("@RFloor", this.RFloor);
            sqlCommand.Parameters.AddWithValue("@RNo", this.RNo);

            return editRecord(sqlCommand, "Detele a record from table " + TABLE_NAME);
        }

        private bool editRecord(SqlCommand sqlCommand, string message)
        {
            try
            {
                using (SqlConnection sqlConnection = function.getConnection())
                {
                    using (sqlCommand.Connection = sqlConnection)
                    {
                        sqlConnection.Open();
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        if (rowsAffected > 0) return true;
                        else MessageBox.Show("Failed!", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool isExists()
        {
            string query = $"SELECT COUNT(*) FROM {TABLE_NAME} WHERE RFloor=@RFloor AND RNo=@RNo";
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

        public bool insertInto()
        {
            string query = $"INSERT INTO {TABLE_NAME} (RFloor,RNo,RPricePerNight,RStatus,RType,RDescription) " +
                         "VALUES (@RFloor,@RNo,@RPricePerNight,@RStatus,@RType,@RDescription)";

            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Parameters.AddWithValue("@RFloor", this.RFloor);
            sqlCommand.Parameters.AddWithValue("@RNo", this.RNo);
            sqlCommand.Parameters.AddWithValue("@RPricePerNight", this.RPricePerNight);
            sqlCommand.Parameters.AddWithValue("@RStatus", this.RStatus);
            sqlCommand.Parameters.AddWithValue("@RType", this.RType);
            sqlCommand.Parameters.AddWithValue("@RDescription", this.RDescription);

            return editRecord(sqlCommand, "Insert into table Rooms");
        }

        public bool updateRoom()
        {
            string query = $"UPDATE {TABLE_NAME} " +
                           @"SET RPricePerNight = @RPricePerNight,
                                RDescription = @RDescription,
                                RStatus = @RStatus,
                                RType = @RType
                            WHERE RFloor=@RFloor AND RNo=@RNo";

            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Parameters.AddWithValue("@RFloor", this.RFloor);
            sqlCommand.Parameters.AddWithValue("@RNo", this.RNo);
            sqlCommand.Parameters.AddWithValue("@RPricePerNight", this.RPricePerNight);
            sqlCommand.Parameters.AddWithValue("@RStatus", this.RStatus);
            sqlCommand.Parameters.AddWithValue("@RType", this.RType);
            sqlCommand.Parameters.AddWithValue("@RDescription", this.RDescription);

            return editRecord(sqlCommand, "Update table Rooms");
        }

        public override string ToString()
        {
            return $"Phòng {RNo} - Tầng {RFloor} " +
                   $"Loại: {RType} " +
                   $"Giá mỗi đêm: {RPricePerNight:C} " +
                   $"Trạng thái: {RStatus} " +
                   $"Mô tả: {RDescription}\n";
        }

        public static List<ClassRoom> getAllRooms()
        {
            List<ClassRoom> rooms = new List<ClassRoom>();

            using (SqlConnection conn = function.getConnection())
            {
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {TABLE_NAME}", conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ClassRoom room = new ClassRoom
                        {
                            RFloor = Convert.ToInt32(reader["RFloor"]),
                            RNo = Convert.ToInt32(reader["RNo"]),
                            RPricePerNight = Convert.ToDecimal(reader["RPricePerNight"]),
                            RStatus = reader["RStatus"].ToString(),
                            RType = reader["RType"].ToString(),
                            RDescription = reader["RDescription"].ToString()
                        };
                        rooms.Add(room);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
            return rooms;
        }

        public static List<ClassRoom> filterForAddBookingForm(List<ClassRoom> list, int floor, string type)
        {
            List<ClassRoom> result = new List<ClassRoom>();
            string s = type == "All" ? "All" : type.Substring(0, type.IndexOf(' '));
            if (floor != -1 && s != "All")
            {
                foreach (ClassRoom room in list)
                    if (room.RFloor == floor && room.RType == s) result.Add(room);
            }
            else if (floor != -1)
            {
                foreach (ClassRoom room in list)
                    if (room.RFloor == floor) result.Add(room);
            }
            else if (s != "All")
            {
                foreach (ClassRoom room in list)
                    if (room.RType == s) result.Add(room);
            }

            return result;
        }

    }
}
