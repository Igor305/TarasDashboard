using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TDisRoute
    {
        public long ChId { get; set; }
        public int RouteId { get; set; }
        public string RouteAddress { get; set; }
        public decimal RouteSumCc { get; set; }
        public string RouteNotes { get; set; }

        public virtual TDi Ch { get; set; }
    }
}
