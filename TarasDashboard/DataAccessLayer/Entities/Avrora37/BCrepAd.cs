using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BCrepAd
    {
        public long ChId { get; set; }
        public int AssId { get; set; }
        public short AcodeId1 { get; set; }
        public short AcodeId2 { get; set; }
        public short AcodeId3 { get; set; }
        public short AcodeId4 { get; set; }
        public short AcodeId5 { get; set; }
        public string Um { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public string DocDesc { get; set; }
        public DateTime? BuyDate { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal GstsumWt { get; set; }
        public decimal GsttaxSum { get; set; }
        public int GstaccId { get; set; }
    }
}
