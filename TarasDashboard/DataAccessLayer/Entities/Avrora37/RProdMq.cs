using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdMq
    {
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal? Weight { get; set; }
        public string Notes { get; set; }
        public string BarCode { get; set; }
        public string ProdBarCode { get; set; }
        public int Plid { get; set; }
        public decimal? OldQty { get; set; }
        public decimal? Height1 { get; set; }
        public decimal? Width1 { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Weight1 { get; set; }
        public decimal? Space { get; set; }
        public decimal TareWeight { get; set; }
    }
}
