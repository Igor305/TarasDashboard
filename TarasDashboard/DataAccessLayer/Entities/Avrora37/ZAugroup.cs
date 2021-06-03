using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAugroup
    {
        public ZAugroup()
        {
            ZAutoUpdates = new HashSet<ZAutoUpdate>();
        }

        public int AugroupCode { get; set; }
        public string AugroupName { get; set; }
        public string Spname { get; set; }
        public string FilterSpname { get; set; }
        public bool DateFilter { get; set; }
        public byte Sptype { get; set; }
        public int TableCode { get; set; }
        public int FilterTableCode { get; set; }
        public string GroupFields { get; set; }
        public bool TableDbo { get; set; }
        public bool FilterTableDbo { get; set; }
        public int SrcTableCode { get; set; }

        public virtual ICollection<ZAutoUpdate> ZAutoUpdates { get; set; }
    }
}
