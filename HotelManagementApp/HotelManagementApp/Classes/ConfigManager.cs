using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelManagementApp.Classes
{
    internal class ConfigManager
    {
        private static readonly string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
        private static JObject configData;

        static ConfigManager()
        {
            if (File.Exists(configPath))
            {
                string json = File.ReadAllText(configPath);
                configData = JObject.Parse(json);
            }
            else
            {
                throw new Exception("File cấu hình không tồn tại!");
            }
        }

        public static int getTotalFloors()
        {
            return (int)configData["TotalFloors"];
        }

    }
}
