using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogDimension
    {
        public int LogId { get; set; }
        public DateTime LogDate { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal? Height1Old { get; set; }
        public decimal? Width1Old { get; set; }
        public decimal? DepthOld { get; set; }
        public decimal? Weight1Old { get; set; }
        public decimal? Height1New { get; set; }
        public decimal? Width1New { get; set; }
        public decimal? DepthNew { get; set; }
        public decimal? Weight1New { get; set; }
        public string UserName { get; set; }
    }
}
