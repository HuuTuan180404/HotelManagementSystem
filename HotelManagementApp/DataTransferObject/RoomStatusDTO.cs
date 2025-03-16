using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp.Classes
{
    public class RoomStatusDTO
    {
        public string RStatus { get; set; }
        public string RSDescription { get; set; }

        public RoomStatusDTO() { }

        public RoomStatusDTO(string status)
        {
            this.RStatus = status;
        }

        public RoomStatusDTO(string status, string description) : this(status)
        {
            RSDescription = description;
        }

    }
}
