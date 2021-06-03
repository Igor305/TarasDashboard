using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class QaLogsD
    {
        public int Id { get; set; }
        public int? LogId { get; set; }
        public long? ExcDocId { get; set; }
        public int? ProdId { get; set; }
        public int? SrcPosId { get; set; }
        public decimal? OldQty { get; set; }
        public decimal? NewQty { get; set; }
        public int? Type { get; set; }
        public long? LinkedDocId { get; set; }
    }
}
