using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BRepAdp
    {
        public long ChId { get; set; }
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public string DocDesc { get; set; }
        public DateTime? BuyDate { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
