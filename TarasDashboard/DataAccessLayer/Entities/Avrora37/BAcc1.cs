using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BAcc1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public decimal TsumCcNt { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public decimal TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public decimal? TsumMcNt { get; set; }
    }
}
