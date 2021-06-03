using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAppPrint
    {
        public int AppCode { get; set; }
        public string FileName { get; set; }
        public string FileDesc { get; set; }

        public virtual ZApp AppCodeNavigation { get; set; }
    }
}
