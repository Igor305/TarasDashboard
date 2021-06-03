using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BWbill
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int EmpId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public short CarrId { get; set; }
        public short TrailerId1 { get; set; }
        public short TrailerId2 { get; set; }
        public decimal StartSpInf { get; set; }
        public decimal EndSpInf { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal GiveFuell { get; set; }
        public decimal InRemFuell { get; set; }
        public decimal RemFuell { get; set; }
        public decimal NexpFuell { get; set; }
        public decimal RaceLength { get; set; }
        public int RaceTime { get; set; }
        public string Notes { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
        public short CurrId { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
    }
}
