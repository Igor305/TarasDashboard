using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSestD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal PriceAc { get; set; }
        public decimal NewPriceAc { get; set; }
        public decimal Extra { get; set; }
        public short CurrId { get; set; }
        public short NewCurrId { get; set; }
        public int Plid { get; set; }
        public int EmpId { get; set; }
        public string BarCode { get; set; }
        public decimal Qty { get; set; }
    }
}
