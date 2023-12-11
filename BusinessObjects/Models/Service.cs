using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Service
    {
        public int RoomId { get; set; }
        public int ServiceId { get; set; }
        public decimal RentingBillPrice { get; set; }
        public decimal ElectricityBillPrice { get; set; }
        public decimal WaterBillPrice { get; set; }
        public decimal OtherBillPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Room Room { get; set; } = null!;
        public virtual ServiceDetail? ServiceDetail { get; set; }
    }
}
