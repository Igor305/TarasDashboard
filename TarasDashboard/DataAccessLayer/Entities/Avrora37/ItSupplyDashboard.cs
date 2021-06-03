using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItSupplyDashboard
    {
        public int ChId { get; set; }
        public int Years { get; set; }
        public int Months { get; set; }
        public decimal? InCome { get; set; }
        public decimal? ProdSaleQty { get; set; }
        public decimal? RecQty { get; set; }
        public decimal? UnitQty { get; set; }
        public decimal? ProdExcQtyOnTt { get; set; }
        public decimal? ProdExcSpaceOnTt { get; set; }
        public decimal? RemQtyOnDc { get; set; }
        public decimal? RemQtyOnTt { get; set; }
        public decimal? DisErrQty { get; set; }
    }
}
