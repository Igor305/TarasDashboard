using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZToolApp
    {
        public int ToolCode { get; set; }
        public int AppCode { get; set; }

        public virtual ZApp AppCodeNavigation { get; set; }
        public virtual ZTool ToolCodeNavigation { get; set; }
    }
}
