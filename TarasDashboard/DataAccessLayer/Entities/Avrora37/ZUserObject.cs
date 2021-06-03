using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZUserObject
    {
        public short UserCode { get; set; }
        public int ObjCode { get; set; }
        public byte AccRun { get; set; }

        public virtual ZObject ObjCodeNavigation { get; set; }
        public virtual RUser UserCodeNavigation { get; set; }
    }
}
