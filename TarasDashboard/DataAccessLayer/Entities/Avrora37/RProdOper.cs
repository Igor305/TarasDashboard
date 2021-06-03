using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdOper
    {
        public int ProdId { get; set; }
        public int SrcPosId { get; set; }
        public string OperDesc { get; set; }
        public decimal Percent1 { get; set; }
        public decimal Percent2 { get; set; }
        public bool IsDefault { get; set; }
    }
}
