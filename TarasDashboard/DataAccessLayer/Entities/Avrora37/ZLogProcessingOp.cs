using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogProcessingOp
    {
        public long ChId { get; set; }
        public DateTime DocTime { get; set; }
        public short Crid { get; set; }
        public byte Operation { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
    }
}
