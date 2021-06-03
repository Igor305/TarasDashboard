using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VNotify
    {
        public int RepId { get; set; }
        public string NotifyName { get; set; }
        public string NotifyText { get; set; }
        public int NotifyType { get; set; }
        public string Address { get; set; }
        public bool AttachReport { get; set; }
        public bool SendToDevs { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
