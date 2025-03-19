using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DataTransferObject;

namespace Business
{
    public class RoomB
    {
        private RoomD RoomD = new RoomD();
        private RoomTypeD RoomTypeD = new RoomTypeD();
        private RoomStatusD RoomStatusD = new RoomStatusD();

        public DataSet getDataSetDetailAllRooms()
        {
            return RoomD.getDataSetDetailAllRooms();
        }

        public DataSet getDataSetDetailAllRooms_FilterByStatus(string status)
        {
            return RoomD.getDataSetDetailAllRooms_FilterByStatus(status);
        }

        public List<RoomDTO> getAllRooms()
        {
            return RoomD.getAllRooms();
        }

        public RoomDTO getInfoRoom(string roomId)
        {
            List<RoomDTO> listRooms = RoomD.getAllRooms();
            return listRooms.FirstOrDefault(room => room.RId == roomId);
        }

        public List<RoomStatusDTO> getListRoomStatus()
        {
            return RoomStatusD.getListRoomStatus();
        }

        public List<RoomTypeDTO> getListRoomType()
        {
            return RoomTypeD.getListRoomType();
        }

        public void addRoom(RoomDTO room)
        {

        }


    }
}
