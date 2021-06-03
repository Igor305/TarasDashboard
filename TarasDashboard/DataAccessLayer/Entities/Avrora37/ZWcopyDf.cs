using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyDf
    {
        public long AchId { get; set; }
        public int FieldPosId { get; set; }
        public string FieldName { get; set; }
        public string FieldDesc { get; set; }
        public bool UserField { get; set; }
        public bool ForFilterMode { get; set; }
    }
}
