using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TEorecD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceAc { get; set; }
        public decimal SumAc { get; set; }
        public string BarCode { get; set; }
        public int SecId { get; set; }
    }
}
