using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public string DisplayName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public byte Age { get; set; }
        public bool RentingStatus { get; set; }

        public virtual Room Room { get; set; } = null!;
    }
}
