using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ChRangeValue
    {
        public string Dbname { get; set; }
        public int? Stockid { get; set; }
        public long? LastCh { get; set; }
        public long? StartCh { get; set; }
        public long? FinishCh { get; set; }
        public long? CountRange { get; set; }
        public long? Diff { get; set; }
        public long? FillPercent { get; set; }
        public string Conclus { get; set; }
    }
}
