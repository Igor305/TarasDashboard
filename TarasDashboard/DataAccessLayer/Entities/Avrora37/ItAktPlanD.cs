using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItAktPlanD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal PurPriceCcWt { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal PriceCcIn { get; set; }
        public decimal Discount { get; set; }
        public decimal MinQty { get; set; }
    }
}
