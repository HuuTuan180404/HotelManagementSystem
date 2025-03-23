using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class ConfigData
    {
        private static readonly string CONNECTION_STRING = "data source=.;database=HotelManagementSystem;integrated security = True";
        //public static string ConnectionString = "metadata=res://*/MyDatabase.csdl|res://*/MyDatabase.ssdl|res://*/MyDatabase.msl;provider=System.Data.SqlClient;provider connection string=&quot;Server=.;initial catalog=HotelManagementSystem;integrated security=True;multipleactiveresultsets=True;encrypt=True;trustservercertificate=True;application name=EntityFramework&quot";

        //public static string SqlConnectionString = "data source=.;initial catalog=HotelManagementSystem;integrated security=True;multipleactiveresultsets=True;encrypt=True;trustservercertificate=True;application name=EntityFramework";

        public static string EntityConnectionString
        {
            get
            {
                var sqlBuilder = new SqlConnectionStringBuilder(CONNECTION_STRING);
                var entityBuilder = new EntityConnectionStringBuilder
                {
                    Provider = "System.Data.SqlClient",
                    ProviderConnectionString = sqlBuilder.ToString(),
                    Metadata = "res://*/MyDatabase.csdl|res://*/MyDatabase.ssdl|res://*/MyDatabase.msl"
                };
                return entityBuilder.ToString();
            }
        }
    }
}
