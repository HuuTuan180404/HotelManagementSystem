using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class RoomTypeDTO
    {
        public string RType { get; set; }
        public int RTBedCount { get; set; }
        public int RTMaxGuests { get; set; }
        public string RTDescription { get; set; }

        public RoomTypeDTO() { }

        public RoomTypeDTO(string str) { this.RType = str; }

        public RoomTypeDTO(string rType, int rTBedCount, int rTMaxGuests, string rTDescription) : this(rType)
        {
            RTBedCount = rTBedCount;
            RTMaxGuests = rTMaxGuests;
            RTDescription = rTDescription;
        }


    }
}
