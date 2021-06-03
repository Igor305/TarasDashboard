using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BInv1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public short? PayDelay { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public string City { get; set; }
        public int StockId { get; set; }
        public decimal TsumCc { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TrealSum { get; set; }
        public decimal TlevySum { get; set; }
        public decimal? TsumMc { get; set; }
        public decimal? TsumMcNt { get; set; }
    }
}
