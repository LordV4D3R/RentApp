using BusinessObjects.Models;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Rooms
{
    public class RoomRepository : IRoomRepository
    {
        public List<Room> GetAllRooms() => RoomDAO.Instance.GetRooms();

        public Room GetRoomByID(int id) => RoomDAO.Instance.GetRoomByID(id);

    }
}
