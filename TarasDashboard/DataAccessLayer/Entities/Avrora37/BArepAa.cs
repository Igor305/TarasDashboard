using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BArepAa
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal? SumCc { get; set; }
        public decimal? SumMc { get; set; }
        public decimal? SumAc { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int CompId { get; set; }
    }
}
