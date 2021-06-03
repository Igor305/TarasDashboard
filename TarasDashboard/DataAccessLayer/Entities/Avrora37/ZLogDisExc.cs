using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogDisExc
    {
        public int LogId { get; set; }
        public int? DisChId { get; set; }
        public int? DisDocId { get; set; }
        public int? ExcChId { get; set; }
        public int? ExcDocId { get; set; }
        public int? ExcStockId { get; set; }
        public DateTime? ExcDocdate { get; set; }
    }
}
