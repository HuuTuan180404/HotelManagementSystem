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
        public string RStatus { get; set; }
        public decimal RPricePerNight { get; set; }
        public string RDescription { get; set; }

        public RoomDTO() { }

        public RoomDTO(string rNo)
        {
            RId = rNo;
        }

        public RoomDTO(string rNo, string rType, string rStatus, decimal rPricePerNight, string rDescription) : this(rNo)
        {
            RPricePerNight = rPricePerNight;
            RStatus = rStatus;
            RType = rType;
            RDescription = rDescription;
        }

        public int getFloor()
        {
            string[] s = this.RId.Substring(3).Split('-');
            return Convert.ToInt32(s[0]);
        }



        public RoomTypeDTO getRoomTypeDTO()
        {
            return new RoomTypeDTO(this.RType);
        }

        public RoomStatusDTO getRoomStatusDTO()
        {
            return new RoomStatusDTO(this.RStatus);
        }
    }
}
