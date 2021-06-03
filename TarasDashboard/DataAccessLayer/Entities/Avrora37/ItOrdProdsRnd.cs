using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItOrdProdsRnd
    {
        public long ChId { get; set; }
        public int ProdId { get; set; }
        public decimal RemQty { get; set; }
        public decimal? SaleQty { get; set; }
        public int? Nperiod { get; set; }
    }
}
