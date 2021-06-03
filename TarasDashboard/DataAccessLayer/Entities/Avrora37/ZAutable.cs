using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAutable
    {
        public int Auid { get; set; }
        public int PtableCode { get; set; }
        public string PfieldNames { get; set; }
        public string PfieldDescs { get; set; }
        public int CtableCode { get; set; }
        public string CfieldNames { get; set; }
        public string CfieldDescs { get; set; }
        public string Efilter { get; set; }
        public string Lfilter { get; set; }

        public virtual ZAutoUpdate Au { get; set; }
    }
}
