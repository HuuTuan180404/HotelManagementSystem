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
    internal class ClassRoom_Status
    {
        public string RStatus { get; set; }
        public string RSDescription { get; set; }

        private static function function = new function();

        public static readonly string TABLE_NAME = "[HotelManagementSystem].[dbo].[Room_Status]";

        public ClassRoom_Status() { }

        public ClassRoom_Status(string status)
        {
            this.RStatus = status;
            setByRStatus();
        }

        public ClassRoom_Status(string status, string description) : this(status)
        {
            RSDescription = description;
        }

        public void setByRStatus()
        {
            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    string query = $"SELECT * FROM {TABLE_NAME} WHERE RStatus=@RStatus";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RStatus", this.RStatus);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.RSDescription = reader["RSDescription"].ToString();
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
