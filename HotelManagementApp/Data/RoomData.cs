using System;
using System.Linq;
using System.Text;
using DataTransferObject;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;

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
                    list = rooms.ToList();
                }
            }
            return list;
        }

        public List<RoomDTO> GetAllRooms(string status)
        {
            List<RoomDTO> list = new List<RoomDTO>();
            using (var DB = new HotelManagementSystemContext())
            {
                var rooms = DB.Rooms.Include("RType_").Include("RStatus_").Where(r => r.RStatus.RStatus_ == (status)).Select(r => new RoomDTO
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
                    list = rooms.ToList();
                }
            }
            return list;
        }

        public List<RoomDTO> GetAllRoomTypes()
        {
            List<RoomDTO> list = new List<RoomDTO>();
            using (var DB = new HotelManagementSystemContext())
            {
                var types = DB.RType.Select(type => new RoomDTO
                {
                    RType = type.RType_,
                    RTBedCount = type.BedCount,
                    RTMaxGuests = type.MaxGuests,
                    RTypeDescription = type.Description,
                });

                if (types != null)
                {
                    list = types.ToList();
                }
            }
            return list;
        }

        public List<RoomDTO> GetAllRoomStates()
        {
            List<RoomDTO> list = new List<RoomDTO>();
            using (var DB = new HotelManagementSystemContext())
            {
                var rooms = DB.RStatus.Select(status => new RoomDTO
                {
                    RStatus = status.RStatus_,
                    RStatusDescription = status.Description
                });

                if (rooms != null)
                {
                    list = rooms.ToList();
                }
            }
            return list;
        }

        public List<RoomDTO> FilterByString(string s)
        {
            var list = GetAllRooms().Where(x => x.Display().IndexOf(s) >= 0).ToList();
            return list;
        }

        public void demo()
        {
            Type type = typeof(Rooms);
            PropertyInfo[] properties = type.GetProperties();
            Debug.WriteLine($"Số thuộc tính của {type.Name} là: {properties.Length}");
            foreach (var prop in properties)
            {
                Debug.WriteLine($"- {prop.Name}");
            }
        }

    }
}

