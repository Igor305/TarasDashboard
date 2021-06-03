using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BSrep1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public int CompId { get; set; }
        public DateTime DocDate { get; set; }
        public byte RepType { get; set; }
        public int AssId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string CompName { get; set; }
        public decimal? TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public decimal? TsumCcNt { get; set; }
        public decimal? TsumMcNt { get; set; }
        public decimal? TtaxSumCc { get; set; }
        public decimal? TtaxSumMc { get; set; }
    }
}
