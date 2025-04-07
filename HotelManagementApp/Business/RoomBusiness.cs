using Data;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RoomBusiness
    {
        RoomData RoomData = new RoomData();

        // lấy chi tiết tất cả các phòng
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetAllRooms()
        {
            return RoomData.GetAllRooms();
        }

        // lấy chi tiết tất cả các phòng, lọc theo trạng thái
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetAllRooms(string status)
        {
            return RoomData.GetRoomsByStatus(status);
        }

        // lấy chi tiết tất cả các phòng, tìm kiếm theo từ khóa
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetRoomsFilterByString(string s)
        {
            return RoomData.GetRoomsByString(s);
        }

        // lấy chi tiết tất cả các phòng, lọc theo loại phòng
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetAllRoomTypes()
        {
            return RoomData.GetAllRoomsTypes();
        }

        public List<RoomDTO> GetAllRoomStates()
        {
            return RoomData.GetAllRoomsStates();
        }

        public RoomDTO GetRoom(string RId)
        {
            return RoomData.GetRoom(RId);
        }

        public RoomDTO GetType(string type)
        {
            return RoomData.GetType(type);
        }

        public RoomDTO GetStatus(string status)
        {
            return RoomData.GetStatus(status);
        }

        public bool DeleteRoom(string RId)
        {
            RoomDTO roomDTO = new RoomDTO();
            roomDTO.RId = RId;
            return RoomData.DeleteRoom(roomDTO);
        }

        public bool UpdateRoom(RoomDTO roomDTO)
        {
            return RoomData.UpdateRoom(roomDTO);
        }

        public void demo()
        {
            RoomData.demo();
        }
    }
}
