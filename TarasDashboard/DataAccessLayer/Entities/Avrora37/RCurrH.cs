using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCurrH
    {
        public short CurrId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
    }
}
