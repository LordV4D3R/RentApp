using BusinessObjects.Models;
using Repositories.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Rooms
{
    public class RoomService : IRoomService
    {
        private IRoomRepository roomRepository = null;
        public RoomService()
        {
            roomRepository = new RoomRepository();
        }
        public List<Room> GetAllRooms()
        {
            return roomRepository.GetAllRooms();
        }

        public Room GetRoomById(int id)
        {
            return roomRepository.GetRoomByID(id);
        }
    }
}
