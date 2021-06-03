using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZVarPage
    {
        public ZVarPage()
        {
            ZVars = new HashSet<ZVar>();
        }

        public int VarPageCode { get; set; }
        public string VarPageName { get; set; }
        public int VarPagePosId { get; set; }
        public bool VarPageVisible { get; set; }

        public virtual ICollection<ZVar> ZVars { get; set; }
    }
}
