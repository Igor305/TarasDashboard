using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyFuf
    {
        public long AchId { get; set; }
        public int FieldPosId { get; set; }
        public short UserId { get; set; }
        public string FieldFilterUser { get; set; }
    }
}
