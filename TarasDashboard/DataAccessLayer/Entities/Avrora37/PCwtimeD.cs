using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PCwtimeD
    {
        public long ChId { get; set; }
        public int EmpId { get; set; }
        public short SubId { get; set; }
        public long AchId { get; set; }
        public decimal Bsalary { get; set; }
        public decimal BleaveDaysCount { get; set; }
        public decimal PleaveDaysCount { get; set; }
        public decimal SickDaysCount { get; set; }
        public decimal TruanDaysCount { get; set; }
        public decimal NonAppDaysCount { get; set; }
        public decimal HolDaysCount { get; set; }
        public decimal TworkHours { get; set; }
        public decimal TworkDays { get; set; }
        public decimal ChargeCc { get; set; }
        public short DepId { get; set; }
    }
}
