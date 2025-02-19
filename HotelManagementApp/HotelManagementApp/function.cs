using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void setData(string query, string message)
        {
            SqlConnection sqlConnection = getConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        public void insertRoom(int floor, int numberOfRoom, string roomType, int numOfBeds, int numOfCustomers, int price, string note)
        {
            string query = "INSERT INTO Room (RooNo, RooType, RooBed, RooCustomer, RooPrice, RooNote) " +
                           "VALUES (@RooNo, @RooType, @RooBed, @RooCustomer, @RooPrice, @RooNote)";

            try
            {
                using (SqlConnection sqlConnection = getConnection())  // Giả sử bạn có hàm getConnection()
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        string roomNo = "Roo" + floor + "0" + numberOfRoom;

                        sqlCommand.Parameters.AddWithValue("@RooNo", roomNo);
                        sqlCommand.Parameters.AddWithValue("@RooType", roomType.Trim());
                        sqlCommand.Parameters.AddWithValue("@RooBed", numOfBeds);
                        sqlCommand.Parameters.AddWithValue("@RooCustomer", numOfCustomers);
                        sqlCommand.Parameters.AddWithValue("@RooPrice", price);
                        sqlCommand.Parameters.AddWithValue("@RooNote", note.Trim());

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
