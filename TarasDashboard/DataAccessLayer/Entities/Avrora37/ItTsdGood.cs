using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItTsdGood
    {
        public int IdGood { get; set; }
        public string GoodName { get; set; }
        public string GoodCode { get; set; }
        public double? GoodPrice { get; set; }
    }
}
