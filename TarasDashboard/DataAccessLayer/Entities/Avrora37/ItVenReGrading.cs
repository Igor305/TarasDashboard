using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItVenReGrading
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string BarCode { get; set; }
        public int ProdId { get; set; }
        public decimal DiffQty { get; set; }
        public decimal SumCcIn { get; set; }
        public decimal PriceCcNt { get; set; }
        public string ReadingLines { get; set; }
        public decimal SumCcNt { get; set; }
    }
}
