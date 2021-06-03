using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrFop
    {
        public long ChId { get; set; }
        public string FopTaxCode { get; set; }
        public string FopFio { get; set; }
        public string FinId { get; set; }
        public int? StockId { get; set; }
        public DateTime? RroInstalDate { get; set; }
        public DateTime? RroUninstalDate { get; set; }
    }
}
