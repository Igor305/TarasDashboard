using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VzTool
    {
        public int RepToolCode { get; set; }
        public string RepToolName { get; set; }
        public string FormClass { get; set; }
        public int ToolCode { get; set; }
        public string ToolName { get; set; }
        public int DocCode { get; set; }
        public string DocName { get; set; }
    }
}
