using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocGrp
    {
        public ZDocGrp()
        {
            ZDocs = new HashSet<ZDoc>();
        }

        public int DocGrpCode { get; set; }
        public string DocGrpName { get; set; }
        public string DocGrpInfo { get; set; }

        public virtual ICollection<ZDoc> ZDocs { get; set; }
    }
}
