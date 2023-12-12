using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class ServiceDetail
    {
        public int ServiceId { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public bool RentingStatus { get; set; }
        public bool ElectricStatus { get; set; }
        public bool WaterStatus { get; set; }

        public virtual Service Service { get; set; } = null!;
    }
}
