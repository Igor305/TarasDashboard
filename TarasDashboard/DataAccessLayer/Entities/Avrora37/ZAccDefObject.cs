using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAccDefObject
    {
        public int AccDefCode { get; set; }
        public int ObjCode { get; set; }
        public byte? AccRun { get; set; }

        public virtual ZAccDef AccDefCodeNavigation { get; set; }
        public virtual ZObject ObjCodeNavigation { get; set; }
    }
}
