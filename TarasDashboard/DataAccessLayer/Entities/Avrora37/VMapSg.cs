using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VMapSg
    {
        public int RepId { get; set; }
        public string SourceGrName { get; set; }
        public short SourceId { get; set; }
        public bool ReverseSign { get; set; }
        public bool UseSourceGrName { get; set; }
        public byte RangeType { get; set; }
        public string Sqlstr { get; set; }
        public string Lfilter { get; set; }
        public string Efilter { get; set; }
        public string Lhaving { get; set; }
        public string Ehaving { get; set; }
        public string ObjectDef { get; set; }
        public long RangeValue { get; set; }
    }
}
