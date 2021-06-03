using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IcSalRate
    {
        public long ChId { get; set; }
        public string Varname { get; set; }
        public string Varvalue { get; set; }
        public string Vardesc { get; set; }
    }
}
