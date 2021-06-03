using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RStockCrprod
    {
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public short CrprodId { get; set; }
        public int CrprodGroup { get; set; }
    }
}
