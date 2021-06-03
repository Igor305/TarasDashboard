using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RWtsign
    {
        public long ChId { get; set; }
        public byte WtsignId { get; set; }
        public string WtsignName { get; set; }
        public string Notes { get; set; }
        public bool IsHandSign { get; set; }
        public bool IsWorkTime { get; set; }
        public decimal PayFactor { get; set; }
        public bool IsBasisLeavTime { get; set; }
        public bool IsPregTime { get; set; }
        public bool IsSickTime { get; set; }
        public bool IsTruancyTime { get; set; }
        public bool IsNoAppTime { get; set; }
        public bool IsHolidayTime { get; set; }
    }
}
