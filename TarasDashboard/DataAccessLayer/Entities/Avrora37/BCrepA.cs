using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BCrepA
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public DateTime? DocDate { get; set; }
        public int EmpId { get; set; }
        public int CompId { get; set; }
        public decimal KursMc { get; set; }
        public string Notes { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
        public short CurrId { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public int GposId { get; set; }
    }
}
