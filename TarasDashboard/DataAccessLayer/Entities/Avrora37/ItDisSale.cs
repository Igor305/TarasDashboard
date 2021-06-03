using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItDisSale
    {
        public long Chid { get; set; }
        public DateTime? Docdate { get; set; }
        public int Stockid { get; set; }
        public string Notes { get; set; }
        public byte? Number { get; set; }
    }
}
