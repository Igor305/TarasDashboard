using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItStockMap
    {
        public long ChId { get; set; }
        public int? MapStockId1 { get; set; }
        public int? MapStockId2 { get; set; }
        public bool? IsRoad { get; set; }
    }
}
