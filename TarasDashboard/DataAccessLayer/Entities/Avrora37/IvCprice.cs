using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvCprice
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public string Notes { get; set; }
        public short CurrId { get; set; }
        public string CurrName { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
    }
}
