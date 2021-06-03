using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAufield
    {
        public int Auid { get; set; }
        public int SrcPosId { get; set; }
        public string AufieldName { get; set; }
        public string AufieldDesc { get; set; }
        public string Eexp { get; set; }
        public string Lexp { get; set; }
        public int Aggregate { get; set; }

        public virtual ZAutoUpdate Au { get; set; }
    }
}
