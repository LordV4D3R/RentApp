using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Room
    {
        public Room()
        {
            Customers = new HashSet<Customer>();
            Services = new HashSet<Service>();
        }

        public int RoomId { get; set; }
        public string RoomName { get; set; } = null!;
        public bool RoomStatus { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
