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
        public static readonly int NUM = 3;
        public string RId { get; set; }
        public string RType { get; set; }
        public string RStatus { get; set; }

        public int RTBedCount { get; set; }
        public int RTMaxGuests { get; set; }
        public string RTypeDescription { get; set; }

        public string RStatusDescription { get; set; }
        public decimal RPricePerNight { get; set; }
        public string RDescription { get; set; }

        public RoomDTO() { }

        public RoomDTO(RoomDTO other)
        {
            RId = other.RId;
            RType = other.RType;
            RStatus = other.RStatus;
            RTBedCount = other.RTBedCount;
            RTMaxGuests = other.RTMaxGuests;
            RTypeDescription = other.RTypeDescription;
            RStatusDescription = other.RStatusDescription;
            RPricePerNight = other.RPricePerNight;
            RDescription = other.RDescription;
        }

        public bool compareRoom(RoomDTO other)
        {
            if (this.RType != other.RType) return false;
            if (this.RStatus != other.RStatus) return false;
            if (this.RPricePerNight != other.RPricePerNight)
                return false;
            if (this.RDescription != other.RDescription) return false;
            return true;
        }

        public bool compareType(RoomDTO other)
        {
            if (this.RType != other.RType) return false;
            if (this.RTBedCount != other.RTBedCount) return false;
            if (this.RTMaxGuests != other.RTMaxGuests) return false;
            if (this.RTypeDescription != other.RTypeDescription)
                return false;
            return true;
        }

        public bool compareStatus(RoomDTO other)
        {
            if (this.RStatus == other.RStatus) return false;
            if (this.RStatusDescription == other.RStatusDescription)
                return false;
            return true;
        }

        public int getNumberOfFloor()
        {
            try
            {
                string[] s = this.RId.Substring(3).Split('-');
                return Convert.ToInt32(s[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public RoomDTO Clone()
        {
            return new RoomDTO(this);
        }
    }
}
