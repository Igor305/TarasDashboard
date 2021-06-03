using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BCrepA1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime? DocDate { get; set; }
        public decimal? TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int CompId { get; set; }
    }
}
