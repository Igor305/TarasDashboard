using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRouteSheetD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string DocDateListExc { get; set; }
        public string DocDateListMs { get; set; }
        public decimal? Space { get; set; }
        public int StockId { get; set; }
    }
}
