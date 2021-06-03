using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdMpsE
    {
        public int Plid { get; set; }
        public string Plname { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public short CurrId { get; set; }
        public string CurrName { get; set; }
        public decimal PriceAc { get; set; }
        public decimal? PriceCc { get; set; }
        public decimal? PriceMc { get; set; }
        public int PcatId { get; set; }
        public int PgrId { get; set; }
        public int PgrId1 { get; set; }
        public int PgrId2 { get; set; }
        public int PgrId3 { get; set; }
        public short PgrAid { get; set; }
    }
}
