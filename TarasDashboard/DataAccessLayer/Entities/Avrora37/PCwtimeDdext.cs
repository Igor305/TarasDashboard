using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PCwtimeDdext
    {
        public long AchId { get; set; }
        public short ShedId { get; set; }
        public short DayPosId { get; set; }
        public decimal? WorkHours { get; set; }
        public byte WtsignId { get; set; }
        public decimal EveningHours { get; set; }
        public decimal NightHours { get; set; }
        public byte DayShiftCount { get; set; }
        public decimal DayPayFactor { get; set; }
        public decimal OverTime { get; set; }
        public decimal OverPayFactor { get; set; }
        public decimal DaySaleSumCc { get; set; }
        public decimal EvenSaleSumCc { get; set; }
        public decimal NightSaleSumCc { get; set; }
        public decimal OverSaleSumCc { get; set; }
        public decimal OneHourSumCc { get; set; }
    }
}
