using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BZInH
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public short CurrId { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public decimal SumAc { get; set; }
        public int GtranId { get; set; }
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
        public long DocId { get; set; }
        public int StateCode { get; set; }
        public DateTime DocDate { get; set; }
    }
}
