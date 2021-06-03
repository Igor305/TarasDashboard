using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocCat
    {
        public ZDocCat()
        {
            ZDocs = new HashSet<ZDoc>();
        }

        public int DocCatCode { get; set; }
        public string DocCatName { get; set; }
        public string DocCatInfo { get; set; }

        public virtual ICollection<ZDoc> ZDocs { get; set; }
    }
}
