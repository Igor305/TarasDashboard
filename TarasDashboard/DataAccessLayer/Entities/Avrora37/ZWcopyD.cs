using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyD
    {
        public int CopyId { get; set; }
        public int TablePosId { get; set; }
        public int TableCode { get; set; }
        public int ParentPosId { get; set; }
        public long AchId { get; set; }

        public virtual ZTable TableCodeNavigation { get; set; }
    }
}
