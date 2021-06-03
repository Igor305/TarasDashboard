using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BGtranD
    {
        public int GtranId { get; set; }
        public long AchId { get; set; }
        public short CurrId { get; set; }
        public decimal SumAc { get; set; }
        public int DGaccId { get; set; }
        public int CGaccId { get; set; }
        public int DCompId { get; set; }
        public int CCompId { get; set; }
        public int DEmpId { get; set; }
        public int CEmpId { get; set; }
        public short DCodeId1 { get; set; }
        public short CCodeId1 { get; set; }
        public short DCodeId2 { get; set; }
        public short CCodeId2 { get; set; }
        public short DCodeId3 { get; set; }
        public short CCodeId3 { get; set; }
        public short DCodeId4 { get; set; }
        public short CCodeId4 { get; set; }
        public short DCodeId5 { get; set; }
        public short CCodeId5 { get; set; }
        public int DStockId { get; set; }
        public int CStockId { get; set; }
        public int DProdId { get; set; }
        public int CProdId { get; set; }
        public int DAssId { get; set; }
        public int CAssId { get; set; }
        public int DGvolId { get; set; }
        public int CGvolId { get; set; }
        public decimal DQty { get; set; }
        public decimal CQty { get; set; }
        public string DVol1 { get; set; }
        public string DVol2 { get; set; }
        public string DVol3 { get; set; }
        public string CVol1 { get; set; }
        public string CVol2 { get; set; }
        public string CVol3 { get; set; }
        public int DGrndLinkId { get; set; }
        public int CGrndLinkId { get; set; }
    }
}
