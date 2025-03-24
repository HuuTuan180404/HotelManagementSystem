using System.Data.SqlClient;
using Data;

namespace DataAccess
{
    public static class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            return ConfigData.getConnection();
        }
    }
} 