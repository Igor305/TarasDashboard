using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocPrint
    {
        public int DocCode { get; set; }
        public string FileName { get; set; }
        public string FileDesc { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
    }
}
