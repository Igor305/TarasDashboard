using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItExplanD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public decimal DiffQty { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public short CodeId2 { get; set; }
        public bool Processed { get; set; }
        public decimal? SurplusRet { get; set; }
        public decimal? SurplusPay { get; set; }
        public decimal? SurplusNotPay { get; set; }
        public decimal? Total { get; set; }
        public decimal? PriceCcNt { get; set; }
        public decimal? PriceCcWt { get; set; }
        public decimal? SumCcNt { get; set; }
        public decimal? SumCcWt { get; set; }
        public int DestStockId { get; set; }
    }
}
