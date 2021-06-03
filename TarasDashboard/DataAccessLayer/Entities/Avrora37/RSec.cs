using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RSec
    {
        public long ChId { get; set; }
        public int SecId { get; set; }
        public string SecName { get; set; }
        public string Notes { get; set; }
        public byte CrsecId { get; set; }
    }
}
