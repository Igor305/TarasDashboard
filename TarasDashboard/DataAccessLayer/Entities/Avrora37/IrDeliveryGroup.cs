using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrDeliveryGroup
    {
        public long ChId { get; set; }
        public int DelGid { get; set; }
        public string DelGname { get; set; }
        public string DelGdesc { get; set; }
        public decimal DelTime { get; set; }
        public decimal SafTime { get; set; }
        public decimal Krate { get; set; }
        public short Period { get; set; }
        public DateTime Bdate { get; set; }
        public bool Mon { get; set; }
        public bool Tue { get; set; }
        public bool Wed { get; set; }
        public bool Thu { get; set; }
        public bool Fri { get; set; }
        public bool Sat { get; set; }
        public bool Sun { get; set; }
        public int CompId { get; set; }
        public short Pan { get; set; }
        public short SupplyDayCount { get; set; }
    }
}
