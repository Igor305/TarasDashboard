using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogTRemDStatitic
    {
        public int LogId { get; set; }
        public DateTime LogDate { get; set; }
        public string TableName { get; set; }
        public string Actions { get; set; }
        public long ChId { get; set; }
        public int? ProdId { get; set; }
        public int? OurId { get; set; }
        public int? StockId { get; set; }
        public int? SecId { get; set; }
        public int? Ppid { get; set; }
        public decimal? OldQty { get; set; }
        public decimal? OldAccQty { get; set; }
        public decimal? NewQty { get; set; }
        public decimal? NewAccQty { get; set; }
        public int? Spid { get; set; }
        public string Host { get; set; }
        public string User { get; set; }
    }
}
