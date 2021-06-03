using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItEoremD
    {
        public DateTime? DocDate { get; set; }
        public int? StockId { get; set; }
        public int? ProdId { get; set; }
        public decimal? Qty { get; set; }
    }
}
