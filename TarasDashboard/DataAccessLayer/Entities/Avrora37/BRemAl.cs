using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BRemAl
    {
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string Um { get; set; }
        public int PcatId { get; set; }
        public int PgrId { get; set; }
        public decimal? PriceMc { get; set; }
        public decimal? PriceCc { get; set; }
        public decimal? Trem { get; set; }
        public decimal? TremSumMc { get; set; }
        public decimal? TremSumCc { get; set; }
        public decimal? Tacc { get; set; }
        public decimal? Tqty { get; set; }
        public decimal? SumMc { get; set; }
        public decimal? SumCc { get; set; }
        public int Plid { get; set; }
        public int PgrId1 { get; set; }
        public int PgrId2 { get; set; }
        public int PgrId3 { get; set; }
        public short PgrAid { get; set; }
        public short PbgrId { get; set; }
    }
}
