using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RScaleGr
    {
        public long ChId { get; set; }
        public int ScaleGrId { get; set; }
        public string ScaleGrName { get; set; }
        public string ScaleGrInfo { get; set; }
        public int ScaleType { get; set; }
        public string Iprange { get; set; }
        public int MaxProdQty { get; set; }
        public int MaxProdId { get; set; }
        public string Shed { get; set; }
    }
}
