using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdMp
    {
        public int ProdId { get; set; }
        public int Plid { get; set; }
        public decimal PriceMc { get; set; }
        public string Notes { get; set; }
        public short CurrId { get; set; }
        public short DepId { get; set; }
    }
}
