using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BSvenD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int AssId { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal NewSumCcNt { get; set; }
        public decimal NewTaxSum { get; set; }
        public decimal NewSumCcWt { get; set; }
        public decimal TwerSumCc { get; set; }
        public decimal TdepSumCc { get; set; }
        public decimal TrepSumCc { get; set; }
        public decimal WerRestSumCc { get; set; }
        public decimal DepRestSumCc { get; set; }
        public decimal AgeRem { get; set; }
        public decimal TmodSumCc { get; set; }
        public decimal Age { get; set; }
        public DateTime? AssDate { get; set; }
    }
}
