using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZToolUserEvent
    {
        public int ToolCode { get; set; }
        public short UserCode { get; set; }
        public int EventId { get; set; }

        public virtual ZTool ToolCodeNavigation { get; set; }
        public virtual RUser UserCodeNavigation { get; set; }
    }
}
