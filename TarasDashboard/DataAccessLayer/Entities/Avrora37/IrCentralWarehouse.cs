using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrCentralWarehouse
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string ZoneNumber { get; set; }
        public string RowNumber { get; set; }
        public string SpanNumber { get; set; }
        public string SelectionLevel { get; set; }
        public string CellNumber { get; set; }
        public string CellDimensions { get; set; }
        public string TraversalOrder { get; set; }
        public int ProdId { get; set; }
    }
}
