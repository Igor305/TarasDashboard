using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BWbill1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public short CarrId { get; set; }
        public string CarrName { get; set; }
        public short TrailerId1 { get; set; }
        public short TrailerId2 { get; set; }
        public decimal RaceLength { get; set; }
        public int RaceTime { get; set; }
        public int? JobCount { get; set; }
        public decimal? Tqty { get; set; }
        public decimal? TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public decimal? TsumCcNt { get; set; }
        public decimal? TtaxSum { get; set; }
    }
}
