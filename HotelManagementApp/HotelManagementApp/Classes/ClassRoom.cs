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
                                   CONCAT('Roo',[RFloor],'0',[RNo]) AS RoomNo,
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

        public ClassRoom(int rID, int rFloor, int rNo, decimal rPricePerNight, int rSID, int rTID, string rDescription) : this(rID, rFloor)
        {
            RNo = rNo;
            RPricePerNight = rPricePerNight;
            RSID = rSID;
            RTID = rTID;
            RDescription = rDescription;
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

        public bool insertIntoRoom()
        {
            string query = $"INSERT INTO {TABLE_NAME} (RFloor,RNo,RPricePerNight,RSID,RTID,RDescription) " +
                         "VALUES (@RFloor,@RNo,@RPricePerNight,@RSID,@RTID,@RDescription)";

            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Parameters.AddWithValue("@RFloor", this.RFloor);
            sqlCommand.Parameters.AddWithValue("@RNo", this.RNo);
            sqlCommand.Parameters.AddWithValue("@RPricePerNight", this.RPricePerNight);
            sqlCommand.Parameters.AddWithValue("@RSID", this.RSID);
            sqlCommand.Parameters.AddWithValue("@RTID", this.RTID);
            sqlCommand.Parameters.AddWithValue("@RDescription", this.RDescription);

            return editRecord(sqlCommand, "Insert into table Rooms");
        }

        public bool updateRoom()
        {
            string query = $"UPDATE {TABLE_NAME} " +
                           @"SET RFloor = @RFloor,
                                RNo = @RNo,
                                RPricePerNight = @RPricePerNight,
                                RDescription = @RDescription,
                                RSID = @RSID,
                                RTID = @RTID
                            WHERE RID = @RID";

            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Parameters.AddWithValue("@RFloor", this.RFloor);
            sqlCommand.Parameters.AddWithValue("@RNo", this.RNo);
            sqlCommand.Parameters.AddWithValue("@RPricePerNight", this.RPricePerNight);
            sqlCommand.Parameters.AddWithValue("@RSID", this.RSID);
            sqlCommand.Parameters.AddWithValue("@RTID", this.RTID);
            sqlCommand.Parameters.AddWithValue("@RDescription", this.RDescription);
            sqlCommand.Parameters.AddWithValue("@RID", this.RID);

            return editRecord(sqlCommand, "Update table Rooms");
        }

        public bool deleteByID()
        {
            string query = $"DELETE FROM {TABLE_NAME} WHERE RID=@RID";

            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Parameters.AddWithValue("@RID", this.RID);

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

        public string getRooNo()
        {
            return $"Roo{this.RFloor}0{this.RNo}";
        }

        public int GetRID() { return RID; }
        public void SetRID(int value) { RID = value; }

        public int GetRFloor() { return RFloor; }
        public void SetRFloor(int value) { RFloor = value; }

        public decimal GetRPricePerNight() { return RPricePerNight; }
        public void SetRPricePerNight(decimal a) { RPricePerNight = a; }

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
