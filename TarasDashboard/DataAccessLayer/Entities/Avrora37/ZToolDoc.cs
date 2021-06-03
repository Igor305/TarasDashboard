using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZToolDoc
    {
        public int ToolCode { get; set; }
        public int DocCode { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual ZTool ToolCodeNavigation { get; set; }
    }
}
