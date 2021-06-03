using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCrmm
    {
        public string MpayDesc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public bool IsRec { get; set; }
        public int WproleId { get; set; }
    }
}
