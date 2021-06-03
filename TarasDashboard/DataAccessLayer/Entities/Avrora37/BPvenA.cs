using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BPvenA
    {
        public long ChId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal Tqty { get; set; }
        public decimal TnewQty { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TnewSumCcNt { get; set; }
        public decimal TnewTaxSum { get; set; }
        public decimal TnewSumCcWt { get; set; }
        public decimal Norma1 { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public int TsrcPosId { get; set; }
    }
}
