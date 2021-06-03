using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocForm
    {
        public int DocCode { get; set; }
        public string FileName { get; set; }
        public string FormName { get; set; }
        public string FormDesc { get; set; }
        public bool? IsDefault { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
    }
}
