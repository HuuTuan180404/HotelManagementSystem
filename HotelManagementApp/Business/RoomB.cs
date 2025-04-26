using Data;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RoomB
    {
        RoomD RoomD;

        public RoomB()
        {
            RoomD = new RoomD();
        }

        // lấy chi tiết tất cả các phòng
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetAllRooms()
        {
            return RoomD.GetAllRooms();
        }

        // lấy chi tiết tất cả các phòng, lọc theo trạng thái
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetAllRooms(string status)
        {
            return RoomD.GetRoomsByStatus(status);
        }

        // lấy chi tiết tất cả các phòng, tìm kiếm theo từ khóa
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetRoomsFilterByString(string s)
        {
            return RoomD.GetRoomsByString(s);
        }

        public List<RoomDTO> GetRoomsFilterByType(string type)
        {
            List<RoomDTO> result = RoomD.GetAllRooms()
                .Where(room => room.RType == type).ToList();
            return result;
        }

        public List<RoomDTO> GetRoomsFilterByFloor(int floor)
        {
            List<RoomDTO> result = RoomD.GetAllRooms()
                .Where(room => room.getNumberOfFloor() == floor).ToList();
            return result;
        }

        // lấy chi tiết tất cả các phòng, lọc theo loại phòng
        // (lấy cả các trường của các bảng có liên kết)
        public List<RoomDTO> GetAllRoomTypes()
        {
            return RoomD.GetAllRoomsTypes();
        }

        public List<RoomDTO> GetAllRoomStates()
        {
            return RoomD.GetAllRoomsStates();
        }

        public RoomDTO GetRoom(string RId)
        {
            return RoomD.GetRoom(RId);
        }

        public RoomDTO GetType(string type)
        {
            return RoomD.GetType(type);
        }

        public RoomDTO GetStatus(string status)
        {
            return RoomD.GetStatus(status);
        }

        public bool AddRoom(RoomDTO roomDTO)
        {
            try
            {
                return RoomD.AddRoom(roomDTO);
            }
            catch (SqlException ex) { throw ex; }
        }

        public bool UpdateRoom(RoomDTO roomDTO)
        {
            return RoomD.UpdateRoom(roomDTO);
        }

        public bool DeleteRoom(string RId)
        {
            try
            {
                RoomDTO roomDTO = new RoomDTO();
                roomDTO.RId = RId;
                return RoomD.DeleteRoom(roomDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ChangeStatus(string roomId, string status)
        {
            try
            {
                return RoomD.ChangeStatus(roomId, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RoomIsAvailable(string roomId)
        {
            try
            {
                return RoomD.RoomIsAvailable(roomId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void demo()
        {
            RoomD.demo();
        }
    }
}
