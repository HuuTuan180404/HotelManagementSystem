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
    internal class ClassRooms_Status
    {
        private int RSID;
        private string RSStatus;
        private string RSDescription;

        private static function function = new function();

        public static readonly string TABLE_NAME = "[HotelManagementSystem].[dbo].[Rooms_Status]";

        public static readonly string TABLE_Rooms_Status = @"
                            SELECT [RSID],
                                   [RSStatus] ,
                                   [RSDescription]
                            FROM " + TABLE_NAME;

        public ClassRooms_Status() { }

        public ClassRooms_Status(int rSID)
        {
            this.RSID = rSID;
        }

        public ClassRooms_Status(string rSStatus)
        {
            this.RSStatus = rSStatus;
        }

        public ClassRooms_Status(int rSID, string rSStatus, string rSDescription)
        {
            RSID = rSID;
            RSStatus = rSStatus;
            RSDescription = rSDescription;
        }

        public void setRooms_StatusByRSStatus()
        {
            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    string query = ClassRooms_Status.TABLE_Rooms_Status + " WHERE RSStatus=@RSStatus";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RSStatus", this.RSStatus);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.RSID = Convert.ToInt32(reader["RSID"].ToString());
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

        public void setByID()
        {
            using (SqlConnection conn = function.getConnection())
            {
                try
                {
                    string query = ClassRooms_Status.TABLE_Rooms_Status + " WHERE RSID=@RSID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RSID", this.RSID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.RSStatus = reader["RSStatus"].ToString();
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



        public int GetRSID() { return RSID; }
        public void SetRSID(int value) { RSID = value; }

        public string GetRSStatus() { return RSStatus; }
        public void SetRSStatus(string value) { RSStatus = value; }

        public string GetRSDescription() { return RSDescription; }
        public void SetRSDescription(string value) { RSDescription = value; }

        public override string ToString()
        {
            return $"RSID: {RSID}, RSStatus: {RSStatus}, RSDescription: {RSDescription}";
        }

    }
}
