using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance = null;
        public RoomDAO() { }
        public static RoomDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new RoomDAO();
                }
                return instance;

            }
        }
        public Room GetRoomByID(int id)
        {
            var dbContext = new RentAppContext();
            return dbContext.Rooms.SingleOrDefault(m => m.RoomId.Equals(id));
        }
        public List<Room> GetRooms()
        {
            try
            {
                var dbContext = new RentAppContext();
                return dbContext.Rooms.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
