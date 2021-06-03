using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TDisDd
    {
        public long AchId { get; set; }
        public int DetSrcPosId { get; set; }
        public int DetOurId { get; set; }
        public int DetStockId { get; set; }
        public decimal DetRemQty { get; set; }
        public decimal DetNewQty { get; set; }
        public decimal DetSupQty { get; set; }
        public decimal DetExpQty { get; set; }
        public decimal DestDisQty { get; set; }
        public int DetSecId { get; set; }
        public string DestDocId { get; set; }
        public decimal TransQty { get; set; }
        public int Plid { get; set; }
        public decimal PriceCc { get; set; }
        public decimal NewPriceCc { get; set; }
        public decimal Ioqty { get; set; }
        public decimal DetOptQty { get; set; }
        public decimal? DistributionQtyD { get; set; }
        public short? TtGroup { get; set; }
        public decimal? DetSaleFall { get; set; }
        public int? Sequence { get; set; }
        public byte? ExistsExc { get; set; }
        public decimal? DetNewQtyDis { get; set; }
    }
}
