using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TDiss
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public short CurrId { get; set; }
        public DateTime DocDate { get; set; }
        public long DocId { get; set; }
        public int StockId { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public int StateCode { get; set; }
        public DateTime? Dateproc { get; set; }
    }
}
