using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZToolRep
    {
        public ZToolRep()
        {
            ZLogTools = new HashSet<ZLogTool>();
            ZTools = new HashSet<ZTool>();
        }

        public int RepToolCode { get; set; }
        public string RepToolName { get; set; }
        public string FormClass { get; set; }
        public bool IsInt { get; set; }
        public string RepToolCatName { get; set; }
        public string ShortCut { get; set; }

        public virtual ICollection<ZLogTool> ZLogTools { get; set; }
        public virtual ICollection<ZTool> ZTools { get; set; }
    }
}
