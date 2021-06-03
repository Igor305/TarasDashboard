using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRouteSheet
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string RouteSheetName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DocTime { get; set; }
        public DateTime DocDate { get; set; }
        public string CarNumber { get; set; }
        public decimal TspaceM { get; set; }
        public int StateCode { get; set; }
        public int OurId { get; set; }
        public string DriverName { get; set; }
        public string ForwarderName { get; set; }
        public int RouteSheetId { get; set; }
    }
}
