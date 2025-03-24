using System;
using System.Linq;
using System.Text;
using DataTransferObject;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace Data
{
    public class RoomData
    {
        public List<RoomDTO> GetAllRooms()
        {
            List<RoomDTO> list = new List<RoomDTO>();
            using (var DB = new HotelManagementSystemContext())
            {
                var rooms = DB.Rooms.Include("RType_").Include("RStatus_").Select(r => new RoomDTO
                {
                    RId = r.RId,
                    RType = r.RType.RType_,
                    RTBedCount = r.RType.BedCount,
                    RTMaxGuests = r.RType.MaxGuests,
                    RTypeDescription = r.RType.Description,
                    RStatus = r.RStatus.RStatus_,
                    RStatusDescription = r.RStatus.Description,
                    RPricePerNight = r.PricePerNight,
                    RDescription = r.Description
                });

                if (rooms != null)
                {
                    //list = rooms.ToList();
                }
            }
            return list;
        }

    }
}

