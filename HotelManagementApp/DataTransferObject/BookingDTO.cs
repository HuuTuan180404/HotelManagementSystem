using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class BookingDTO
    {
        public string BId { get; set; }
        public string RId { get; set; }
        public string CId { get; set; }
        public DateTime BTimeCheckIn { get; set; }
        public DateTime BTimeCheckOut { get; set; }
        public string BStatus { get; set; }
        public DateTime BCreateAt { get; set; }

        public string Display()
        {
            return $"{BId} - {CId} - {BTimeCheckIn} - {BTimeCheckOut}";
        }
    }
}
