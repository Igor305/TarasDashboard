using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocUser
    {
        public int DocCode { get; set; }
        public short UserCode { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual RUser UserCodeNavigation { get; set; }
    }
}
