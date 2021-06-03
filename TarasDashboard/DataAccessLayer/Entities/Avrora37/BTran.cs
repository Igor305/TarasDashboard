using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BTran
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime? DocDate { get; set; }
        public int AssId { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public decimal KursMc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public long? InDocId { get; set; }
        public string Notes { get; set; }
        public int StateCode { get; set; }
    }
}
