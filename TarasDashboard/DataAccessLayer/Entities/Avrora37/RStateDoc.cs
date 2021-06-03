using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RStateDoc
    {
        public int DocCode { get; set; }
        public int StateCode { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
    }
}
