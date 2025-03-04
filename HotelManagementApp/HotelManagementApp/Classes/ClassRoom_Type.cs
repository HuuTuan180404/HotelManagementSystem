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
    public class ClassRoom_Type
    {
        public string RType { get; set; }
        public int RTBedCount { get; set; }
        public int RTMaxGuests { get; set; }
        public string RTDescription { get; set; }

        private static function function = new function();
        public static readonly string TABLE_NAME = "[HotelManagementSystem].[dbo].[Room_Type]";

        public ClassRoom_Type() { }

        public ClassRoom_Type(string rTType)
        {
            this.RType = rTType;
            setByRType();
        }

        public ClassRoom_Type(string type, int rTBedCount, int rTMaxGuests, string rTDescription) : this(type)
        {
            RTBedCount = rTBedCount;
            RTMaxGuests = rTMaxGuests;
            RTDescription = rTDescription;
        }

        public void setByRType()
        {
            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    string query = $"SELECT * FROM {TABLE_NAME} WHERE RType=@RType";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RType", this.RType);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
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
    }
}
