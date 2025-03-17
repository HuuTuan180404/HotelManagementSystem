using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class ConfigData
    {
        private static readonly string CONNECTION_STRING = "data source=TURTLEWN;database=HotelManagementSystem;integrated security = True";

        public static SqlConnection getConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            return sqlConnection;
        }
    }
}
