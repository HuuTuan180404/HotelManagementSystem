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

        public List<RoomDTO> GetAllRooms()
        {
            return RoomData.GetAllRooms();
        }

        public List<RoomDTO> GetAllRooms(string status)
        {
            return RoomData.GetAllRooms(status);
        }

        public List<RoomDTO> GetAllRoomTypes()
        {
            return RoomData.GetAllRoomTypes();
        }

        public List<RoomDTO> GetAllRoomStates()
        {
            return RoomData.GetAllRoomStates();
        }

        public void GetÌnfoRoom(string RId)
        {

        }

        public void demo()
        {
            RoomData.demo();
        }

    }
}
