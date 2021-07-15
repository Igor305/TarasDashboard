using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItQualityProd
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string ResultCheck { get; set; }
        public decimal Qty { get; set; }
        public DateTime? FillingDate { get; set; }
        public short? QualityCheckId { get; set; }
        public short? CheckStatusId { get; set; }
        public int? FempId { get; set; }
        public DateTime? MakeProdDate { get; set; }
        public int? ProdExpQty { get; set; }
    }
}
