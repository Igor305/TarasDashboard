using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrProdKm
    {
        public long ChId { get; set; }
        public int PcatKmid { get; set; }
        public string PcatKmname { get; set; }
        public string Notes { get; set; }
    }
}
