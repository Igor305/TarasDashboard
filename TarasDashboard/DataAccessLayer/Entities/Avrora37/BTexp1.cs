using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BTexp1
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public int CompId { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public string Notes { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal? TsumMcNt { get; set; }
    }
}
