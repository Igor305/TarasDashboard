using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TOrderMonitorsTemp
    {
        public long LogIdex { get; set; }
        public int DocCode { get; set; }
        public long DocChId { get; set; }
        public int SaleSrcPosId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? QueueTime { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal? Qty { get; set; }
        public int Wpid { get; set; }
        public int StateCode { get; set; }
        public bool Suspended { get; set; }
        public int? ServingId { get; set; }
        public DateTime? ServingTime { get; set; }
        public string Notes { get; set; }

        public virtual RProd Prod { get; set; }
        public virtual RWp Wp { get; set; }
    }
}
