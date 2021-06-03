using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RBservParam
    {
        public int BservId { get; set; }
        public int SrcPosId { get; set; }
        public int MaxPayPartsQty { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public string PprodFilter { get; set; }
        public string PcatFilter { get; set; }
        public string PgrFilter { get; set; }
        public string Pgr1Filter { get; set; }
        public string Pgr2Filter { get; set; }
        public string Pgr3Filter { get; set; }
        public string Notes { get; set; }
    }
}
