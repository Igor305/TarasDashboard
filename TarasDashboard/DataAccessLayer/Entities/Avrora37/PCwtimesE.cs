using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PCwtimesE
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public int CwtimeType { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public short SubId { get; set; }
        public short DepId { get; set; }
        public long AchId { get; set; }
        public int EmpId { get; set; }
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
