using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TempTsaled
    {
        public int? ChId { get; set; }
        public int? SrcPosId { get; set; }
        public int? ProdId { get; set; }
        public int? Ppid { get; set; }
        public decimal? Qty { get; set; }
    }
}
