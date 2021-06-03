using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TPinP
    {
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public string Ppdesc { get; set; }
        public decimal PriceMcIn { get; set; }
        public decimal PriceMc { get; set; }
        public int Priority { get; set; }
        public DateTime? ProdDate { get; set; }
        public short CurrId { get; set; }
        public int CompId { get; set; }
        public string Article { get; set; }
        public decimal CostAc { get; set; }
        public decimal Ppweight { get; set; }
        public string File1 { get; set; }
        public string File2 { get; set; }
        public string File3 { get; set; }
        public decimal PriceCcIn { get; set; }
        public decimal CostCc { get; set; }
        public short Ppdelay { get; set; }
        public DateTime? ProdPpdate { get; set; }
        public bool IsCommission { get; set; }
        public string CstProdCode { get; set; }
        public string CstDocCode { get; set; }
        public int PgrId3 { get; set; }
        public short CodeId4 { get; set; }
        public int ParentDocCode { get; set; }
        public long ParentChId { get; set; }
        public decimal PriceAcIn { get; set; }
        public decimal CostMc { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal PriceRc { get; set; }
        public int? OriginalOwner { get; set; }
    }
}
