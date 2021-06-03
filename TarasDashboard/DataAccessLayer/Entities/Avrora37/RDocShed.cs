using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDocShed
    {
        public long ChId { get; set; }
        public int DocShedCode { get; set; }
        public string DocShedName { get; set; }
        public int ToolCode { get; set; }
        public string Notes { get; set; }
    }
}
