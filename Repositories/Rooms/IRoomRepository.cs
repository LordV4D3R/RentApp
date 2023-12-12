using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Rooms
{
    public interface IRoomRepository
    {
        Room GetRoomByID(int id);
        List<Room> GetAllRooms();
    }
}
