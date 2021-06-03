using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyT
    {
        public int CopyId { get; set; }
        public int TablePosId { get; set; }
        public long AchId { get; set; }
        public int TableCode { get; set; }
        public string TableSuffix { get; set; }
        public int ParentPosId { get; set; }
        public int JoinType { get; set; }
        public string RelName { get; set; }

        public virtual ZRelation RelNameNavigation { get; set; }
        public virtual ZTable TableCodeNavigation { get; set; }
    }
}
