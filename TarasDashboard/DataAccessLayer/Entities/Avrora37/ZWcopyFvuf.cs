using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyFvuf
    {
        public long AchId { get; set; }
        public int FieldPosId { get; set; }
        public int VariantPosId { get; set; }
        public short UserId { get; set; }
        public string FieldFilterUser { get; set; }
    }
}
