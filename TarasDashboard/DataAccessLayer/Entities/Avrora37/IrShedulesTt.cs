using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrShedulesTt
    {
        public long ChId { get; set; }
        public int StockId { get; set; }
        public int RegionId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public bool? Mon { get; set; }
        public bool? Tue { get; set; }
        public bool? Wed { get; set; }
        public bool? Thu { get; set; }
        public bool? Fri { get; set; }
        public bool? Sat { get; set; }
        public bool? Sun { get; set; }
        public byte Parity { get; set; }
        public byte? QtyFillmentOrder { get; set; }
        public int? Sequence { get; set; }
        public string Notes { get; set; }
    }
}
