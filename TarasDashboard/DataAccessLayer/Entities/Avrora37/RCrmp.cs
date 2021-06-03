using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCrmp
    {
        public short Crid { get; set; }
        public int ProdId { get; set; }
        public int CrprodId { get; set; }
        public byte TaxId { get; set; }
        public int SecId { get; set; }
        public bool FixedPrice { get; set; }
        public bool DecimalQty { get; set; }
        public decimal PriceCc { get; set; }
        public string CrprodName { get; set; }
        public string BarCode { get; set; }
    }
}
