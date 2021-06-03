using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAppUser
    {
        public int AppCode { get; set; }
        public short UserCode { get; set; }

        public virtual ZApp AppCodeNavigation { get; set; }
        public virtual RUser UserCodeNavigation { get; set; }
    }
}
