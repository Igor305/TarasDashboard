using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TempStocksRudenko
    {
        public int? Stockid { get; set; }
        public int Num { get; set; }
        public decimal? RemDo { get; set; }
        public decimal? RemPosle { get; set; }
    }
}
