using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrProdSumHistory
    {
        public int ProdId { get; set; }
        public int StockId { get; set; }
        public DateTime Bdate { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TsumCcIn { get; set; }
        public decimal Tqty { get; set; }
        public int CompId { get; set; }
    }
}
