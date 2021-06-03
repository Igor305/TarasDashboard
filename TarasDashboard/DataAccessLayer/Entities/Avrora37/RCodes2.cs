using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCodes2
    {
        public long ChId { get; set; }
        public short CodeId2 { get; set; }
        public string CodeName2 { get; set; }
        public string Notes { get; set; }
        public bool? EnOffice { get; set; }
        public bool? Enshop { get; set; }
        public bool? IsdocExc { get; set; }
        public bool? IsregExc { get; set; }
        public bool? IsdocDis { get; set; }
        public bool? IsdocRec { get; set; }
    }
}
