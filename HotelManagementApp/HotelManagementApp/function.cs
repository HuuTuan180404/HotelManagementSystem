using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataSet GetDataSet(String queue) { return null; }
    }
}
