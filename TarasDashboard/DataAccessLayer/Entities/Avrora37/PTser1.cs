using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PTser1
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public short SubId { get; set; }
        public short DepId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public string Notes { get; set; }
        public int EmpId { get; set; }
        public int CompId { get; set; }
        public string TripPurpose { get; set; }
        public DateTime TripBdate { get; set; }
        public DateTime TripEdate { get; set; }
        public short TripDays { get; set; }
        public int? PlaceCount { get; set; }
    }
}
