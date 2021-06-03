using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VTable
    {
        public int RepId { get; set; }
        public short SourceId { get; set; }
        public int TableIdx { get; set; }
        public int TableCode { get; set; }
        public byte JoinLevel { get; set; }
        public int JoinType { get; set; }
        public int ParentIdx { get; set; }
        public string RelName { get; set; }

        public virtual ZRelation RelNameNavigation { get; set; }
    }
}
