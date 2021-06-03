using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VScript
    {
        public int RepId { get; set; }
        public string ScBeforeRun { get; set; }
        public string ScBeforeSource { get; set; }
        public string ScAfterSource { get; set; }
        public string ScAfterPrepare { get; set; }
        public string ScBeforeLoad { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
