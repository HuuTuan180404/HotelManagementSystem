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
    internal class ClassRooms_Type
    {
        private int RTID;
        private string RTType;
        private int RTBedCount;
        private int RTMaxGuests;
        private string RTDescription;

        private static function function = new function();
        public static readonly string TABLE_NAME = "[HotelManagementSystem].[dbo].[Rooms_Type]";
        public static readonly string TABLE_Rooms_Type = @"
                                        SELECT [RTID],
                                               [RTType],
                                               [RTBedCount],
                                               [RTMaxGuests],
                                               [RTDescription]
                                        FROM " + TABLE_NAME;

        public ClassRooms_Type() { }

        public ClassRooms_Type(int rTID)
        {
            RTID = rTID;
        }

        public ClassRooms_Type(string rTType)
        {
            this.RTType = rTType;
        }

        public ClassRooms_Type(int rTID, string rTType, int rTBedCount, int rTMaxGuests, string rTDescription)
        {
            RTID = rTID;
            RTType = rTType ?? throw new ArgumentNullException(nameof(rTType));
            RTBedCount = rTBedCount;
            RTMaxGuests = rTMaxGuests;
            RTDescription = rTDescription ?? throw new ArgumentNullException(nameof(rTDescription));
        }

        public void setRooms_TypeByRTType()
        {
            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    string query = ClassRooms_Type.TABLE_Rooms_Type + " WHERE RTType=@RTType";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RTType", this.RTType);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.RTID = Convert.ToInt32(reader["RTID"].ToString());
                        this.RTBedCount = Convert.ToInt32(reader["RTBedCount"].ToString());
                        this.RTMaxGuests = Convert.ToInt32(reader["RTMaxGuests"].ToString());
                        this.RTDescription = reader["RTDescription"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        public int GetRTID() { return RTID; }
        public void SetRTID(int value) { RTID = value; }

        public string GetRTType() { return RTType; }
        public void SetRTType(string value) { RTType = value; }

        public int GetRTBedCount() { return RTBedCount; }
        public void SetRTBedCount(int value) { RTBedCount = value; }

        public int GetRTMaxGuests() { return RTMaxGuests; }
        public void SetRTMaxGuests(int value) { RTMaxGuests = value; }

        public string GetRTDescription() { return RTDescription; }
        public void SetRTDescription(string value) { RTDescription = value; }

        public override string ToString()
        {
            return $"RTID: {RTID}, RTType: {RTType}, RTBedCount: {RTBedCount}, RTMaxGuests: {RTMaxGuests}, RTDescription: {RTDescription}";
        }

    }
}
