using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace DataTransferObject
{
    public class RoomDTO
    {
        public string RId { get; set; }
        public string RType { get; set; }
        public string RStatus { get; set; }

        public int RTBedCount { get; set; }
        public int RTMaxGuests { get; set; }
        public string RTypeDescription { get; set; }
        
        public string RStatusDescription { get; set; }
        public decimal RPricePerNight { get; set; }
        public string RDescription { get; set; }

        public int getNumberOfFloor()
        {
            string[] s = this.RId.Substring(3).Split('-');
            return Convert.ToInt32(s[0]);
        }

        public static List<string> Properties()
        {
            Type type = typeof(RoomDTO);
            PropertyInfo[] properties = type.GetProperties();
            return properties.Select(p => p.Name).ToList();
        }

        public string Display()
        {
            return $"{RId}-{RType}-{RTBedCount}-{RTMaxGuests}-{RTypeDescription}-{RStatus}-" +
                $"{RStatusDescription}-{RPricePerNight}-{RDescription}";
        }
    }
}
