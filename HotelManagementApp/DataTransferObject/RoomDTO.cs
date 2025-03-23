using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class RoomDTO
    {
        public string RId { get; set; }
        public string RType { get; set; }
        public int RTBedCount { get; set; }
        public int RTMaxGuests { get; set; }
        public string RTypeDescription { get; set; }
        public string RStatus { get; set; }
        public string RStatusDescription { get; set; }
        public decimal RPricePerNight { get; set; }
        public string RDescription { get; set; }

        public int getNumberOfFloor()
        {
            string[] s = this.RId.Substring(3).Split('-');
            return Convert.ToInt32(s[0]);
        }
    }
}
