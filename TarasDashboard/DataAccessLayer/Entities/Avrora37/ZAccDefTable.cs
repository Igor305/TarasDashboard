using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAccDefTable
    {
        public int AccDefCode { get; set; }
        public int TableCode { get; set; }
        public byte AccRead { get; set; }
        public byte AccInsert { get; set; }
        public byte AccUpdate { get; set; }
        public byte AccDelete { get; set; }

        public virtual ZAccDef AccDefCodeNavigation { get; set; }
        public virtual ZTable TableCodeNavigation { get; set; }
    }
}
