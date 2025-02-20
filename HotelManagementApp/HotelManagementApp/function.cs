using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementApp.Classes;
using TheArtOfDevHtmlRenderer.Adapters;
using HotelManagementApp.Forms;
using System.Collections;
using System.Diagnostics;
using System.Drawing;

namespace HotelManagementApp
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source=HUUTUAN;database=HotelManagementSystem;integrated security = True";
            return sqlConnection;
        }
        public DataSet getData(string queue)
        {
            SqlConnection sqlConnection = getConnection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = queue;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }

        public ClassRoom getRoom(string roomID)
        {
            ClassRoom room = null;
            string query = "SELECT * FROM Rooms WHERE RooID = @RooID";

            SqlConnection conn = getConnection();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RooID", Int32.Parse(roomID));

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) // Nếu tìm thấy phòng
            {
                room = new ClassRoom(
                    Convert.ToInt32(reader["RooID"]),
                    reader["RooNo"].ToString(),
                    reader["RooType"].ToString(),
                    Convert.ToInt32(reader["RooBed"]),
                    Convert.ToInt32(reader["RooFloor"]),
                    Convert.ToInt32(reader["RooCustomer"]),
                    Convert.ToInt32(reader["RooPrice"]),
                    reader["RooStatus"].ToString(),
                    reader["RooNote"] != DBNull.Value ? reader["RooNote"].ToString() : ""
                );
            }
            reader.Close();
            return room;
        }

        public void setData(string query, string message)
        {
            SqlConnection sqlConnection = getConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool editRecord(SqlCommand sqlCommand, string message)
        {
            try
            {
                using (SqlConnection sqlConnection = getConnection())
                {
                    using (sqlCommand.Connection = sqlConnection)
                    {
                        // Mở kết nối và thực thi lệnh
                        sqlConnection.Open();
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        // Kiểm tra kết quả
                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public void insertRoom(int floor, int numberOfRoom, string roomType, int numOfBeds,
      int numOfCustomers, int price, string note)
        {
            string query = "INSERT INTO Room (RooNo, RooType, RooBed, RooCustomer, RooPrice, RooNote) " +
                           "VALUES (@RooNo, @RooType, @RooBed, @RooCustomer, @RooPrice, @RooNote)";

            try
            {
                using (SqlConnection sqlConnection = getConnection())
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {


                        // Mở kết nối và thực thi lệnh
                        sqlConnection.Open();
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        // Kiểm tra kết quả
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm phòng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu nào được thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
