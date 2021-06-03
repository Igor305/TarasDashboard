using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VJoin
    {
        public int RepId { get; set; }
        public short SourceId { get; set; }
        public int TableCode { get; set; }
        public string JoinFields { get; set; }
        public int ParentCode { get; set; }

        public virtual VSource VSource { get; set; }
    }
}
