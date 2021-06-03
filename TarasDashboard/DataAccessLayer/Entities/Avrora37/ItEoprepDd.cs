using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItEoprepDd
    {
        public long AchId { get; set; }
        public int DetSrcPosId { get; set; }
        public int DetOurId { get; set; }
        public int DetStockId { get; set; }
        public int DetProdId { get; set; }
        public string DetUm { get; set; }
        public decimal DetPriceAc { get; set; }
        public decimal DetQty { get; set; }
        public decimal DetExpQty { get; set; }
        public decimal DetSumAc { get; set; }
        public decimal DetNewQty { get; set; }
        public decimal DetNewSumAc { get; set; }
        public decimal DetRemQty { get; set; }
        public int DetSecId { get; set; }
        public int DetNremDays { get; set; }
        public decimal DetForeCastQty { get; set; }
        public DateTime? DetPosExpDate { get; set; }
        public decimal SaleQty { get; set; }
        public decimal RecQty { get; set; }
        public decimal ExcQty { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public decimal? Eoqty { get; set; }
        public decimal BremQty { get; set; }
        public decimal EremQty { get; set; }
        public decimal NewPriceAc { get; set; }
        public decimal TransQty { get; set; }
        public decimal MarginSumCc { get; set; }
        public decimal? NewPriceCc { get; set; }
        public decimal InStockQty { get; set; }
        public decimal Ioqty { get; set; }
        public int NremDays { get; set; }
    }
}
