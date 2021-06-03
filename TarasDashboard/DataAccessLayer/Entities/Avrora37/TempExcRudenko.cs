using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TempExcRudenko
    {
        public long Chid { get; set; }
        public long Docid { get; set; }
        public DateTime DocDate { get; set; }
        public int Stockid { get; set; }
        public int NewStockId { get; set; }
        public int DestStockId { get; set; }
        public string SrcDocId { get; set; }
    }
}
