using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItLogProdLow
    {
        public int ProdId { get; set; }
        public int StockId { get; set; }
        public DateTime LowDate { get; set; }
    }
}
