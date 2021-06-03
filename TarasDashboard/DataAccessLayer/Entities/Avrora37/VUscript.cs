using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VUscript
    {
        public int RepId { get; set; }
        public short UserId { get; set; }
        public string ScBeforeRun { get; set; }
        public string ScBeforeSource { get; set; }
        public string ScAfterSource { get; set; }
        public string ScAfterPrepare { get; set; }
        public string ScBeforeLoad { get; set; }

        public virtual VRep Rep { get; set; }
        public virtual RUser User { get; set; }
    }
}
