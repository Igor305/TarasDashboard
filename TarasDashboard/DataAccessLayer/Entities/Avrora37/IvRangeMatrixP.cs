using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvRangeMatrixP
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public bool IsRangeMin { get; set; }
        public int PgrId { get; set; }
        public int PgrId1 { get; set; }
        public int PgrId6 { get; set; }
    }
}
