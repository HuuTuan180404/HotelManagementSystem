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
    internal class config_database
    {
        public SqlConnection getConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source=HUUTUAN;database=HotelManagementSystem;integrated security = True";
            return sqlConnection;
        }

        public DataSet getDataSet(SqlCommand sqlCommand)
        {
            try
            {
                using (SqlConnection sqlConnection = getConnection())
                {
                    using (sqlCommand.Connection = sqlConnection)
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                        DataSet dataSet = new DataSet();
                        sqlDataAdapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
