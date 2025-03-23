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
                var rooms = DB.Rooms.Include("RoomType").Include("RoomStatu").Select(r => new RoomDTO
                {
                    RId = r.RId,
                    RType = r.RoomType.RType,
                    RTBedCount = r.RoomType.RTBedCount,
                    RTMaxGuests = r.RoomType.RTMaxGuests,
                    RTypeDescription = r.RoomType.RTDescription,
                    RStatus = r.RStatus,
                    RStatusDescription = r.RoomStatu.RSDescription,
                    RPricePerNight = r.RPricePerNight,
                    RDescription = r.RDescription
                });

                if (rooms != null)
                {
                    list = rooms.ToList();
                }
            }
            return list;
        }

    }
}

