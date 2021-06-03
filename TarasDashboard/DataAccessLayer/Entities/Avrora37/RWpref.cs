using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RWpref
    {
        public long ChId { get; set; }
        public string Wpref { get; set; }
        public string Notes { get; set; }
        public short ProdIdoffset { get; set; }
        public int BarQtyCount { get; set; }
        public int BarDecCount { get; set; }
    }
}
