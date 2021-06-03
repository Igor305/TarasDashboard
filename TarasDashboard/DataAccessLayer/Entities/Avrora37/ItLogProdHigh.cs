using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItLogProdHigh
    {
        public int ProdId { get; set; }
        public int StockId { get; set; }
        public DateTime HighDate { get; set; }
    }
}
