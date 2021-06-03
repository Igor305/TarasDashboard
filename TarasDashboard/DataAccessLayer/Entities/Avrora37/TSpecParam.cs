using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSpecParam
    {
        public long ChId { get; set; }
        public string LayUm { get; set; }
        public decimal LayQty { get; set; }
        public DateTime ProdDate { get; set; }
        public int StockId { get; set; }
    }
}
