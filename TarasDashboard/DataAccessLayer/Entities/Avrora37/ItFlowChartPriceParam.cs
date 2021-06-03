using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItFlowChartPriceParam
    {
        public long ChId { get; set; }
        public int StockId { get; set; }
        public byte PriceType { get; set; }
        public DateTime DocDate { get; set; }
        public bool FixedPrice { get; set; }
    }
}
