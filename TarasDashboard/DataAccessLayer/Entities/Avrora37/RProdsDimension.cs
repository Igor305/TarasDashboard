using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdsDimension
    {
        public int Prodid { get; set; }
        public decimal? Height1 { get; set; }
        public decimal? Width1 { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Weight1 { get; set; }
        public decimal? Space { get; set; }
    }
}
