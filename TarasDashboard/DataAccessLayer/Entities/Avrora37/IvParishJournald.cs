using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvParishJournald
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public short? QtyInBox1 { get; set; }
        public short? QtyPlaces { get; set; }
        public string Cell { get; set; }
        public decimal Qty { get; set; }
        public decimal? Space1 { get; set; }
        public decimal? Weight1 { get; set; }
    }
}
