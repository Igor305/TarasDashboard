using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyF
    {
        public long AchId { get; set; }
        public int FieldPosId { get; set; }
        public string FieldName { get; set; }
        public string FieldSuffix { get; set; }
        public string FieldDesc { get; set; }
        public bool UserField { get; set; }
        public string FieldFilterUser { get; set; }
        public bool AskFilter { get; set; }
        public int FieldSortPosId { get; set; }
        public byte SortType { get; set; }
    }
}
