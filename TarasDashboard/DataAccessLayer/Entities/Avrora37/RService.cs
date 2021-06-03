using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RService
    {
        public long ChId { get; set; }
        public int SrvcId { get; set; }
        public int ProdId { get; set; }
        public int TimeNorm { get; set; }
        public int StockId { get; set; }
        public bool NeedResource { get; set; }
        public bool NeedExecutor { get; set; }
        public string Notes { get; set; }
    }
}
