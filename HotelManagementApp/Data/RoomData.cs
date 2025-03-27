using System;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using DataTransferObject;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Data
{
    public class RoomData
    {
        // lấy chi tiết tất cả các phòng
        // (lấy cả các trường của các bảng có liên kết)
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

        // lấy chi tiết tất cả các phòng - lọc theo trạng thái
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetRoomsByStatus(string status)
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

        // lấy chi tiết tất cả các phòng - lọc theo từ khóa tìm kiếm
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetRoomsByString(string s)
        {
            var list = GetAllRooms().Where(x => x.Display().IndexOf(s) >= 0).ToList();
            return list;
        }

        // lấy các record của bảng RType
        public List<RoomDTO> GetAllRoomsTypes()
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

        // lấy các record của bảng RStatus
        public List<RoomDTO> GetAllRoomsStates()
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

        // lấy thông tin của phòng thông qua mã phòng
        // (lấy cả các trường của các bảng có liên kết)
        public RoomDTO GetRoom(string RId)
        {
            using (var DB = new HotelManagementSystemContext())
            {
                var room = DB.Rooms.Include("RType_").Include("RStatus_")
                    .Where(r => r.RId == RId)
                    .Select(r => new RoomDTO
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
                    })
                    .FirstOrDefault();
                return room;
            }
        }

        // lấy 1 record loại phòng thông qua khóa chính
        public RoomDTO GetType(string typeId)
        {
            using (var DB = new HotelManagementSystemContext())
            {
                var type = DB.RType
                    .Where(r => r.RType_ == typeId)
                    .Select(r => new RoomDTO
                    {
                        RType = r.RType_,
                        RTBedCount = r.BedCount,
                        RTMaxGuests = r.MaxGuests,
                        RTypeDescription = r.Description,
                    })
                    .FirstOrDefault();
                return type;
            }
        }

        // lấy 1 record thông qua khóa chính
        public RoomDTO GetStatus(string statusId)
        {
            using (var DB = new HotelManagementSystemContext())
            {
                var status = DB.RStatus
                    .Where(r => r.RStatus_ == statusId)
                    .Select(r => new RoomDTO
                    {
                        RStatus = r.RStatus_,
                        RStatusDescription = r.Description
                    })
                    .FirstOrDefault();
                return status;
            }
        }

        public void demo()
        {

        }

    }
}

