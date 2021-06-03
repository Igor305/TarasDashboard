using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PDtran
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public short SubId { get; set; }
        public bool? NotUseSubId { get; set; }
        public bool? NotUseDepId { get; set; }
        public DateTime TranDate { get; set; }
        public byte TranType { get; set; }
        public DateTime? DestDate { get; set; }
        public decimal DatePayFac { get; set; }
        public byte WtsignId { get; set; }
        public string Notes { get; set; }
        public short DepId { get; set; }
        public int StateCode { get; set; }
    }
}
