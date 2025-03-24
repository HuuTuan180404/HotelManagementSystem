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

        public List<RoomDTO> GetAllRoomTypes()
        {

            return null;
        }

        public void GetÌnfoRoom(string RId)
        {

        }

    }
}
