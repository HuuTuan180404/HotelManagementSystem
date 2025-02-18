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
        public DataSet GetDataSet(string queue)
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

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK);

        }
    }
}
