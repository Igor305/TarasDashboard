using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCrretD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public string BarCode { get; set; }
        public int SecId { get; set; }
        public int? SaleSrcPosId { get; set; }
        public int EmpId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public decimal NewQty { get; set; }
        public int TaxTypeId { get; set; }
        public decimal RealPrice { get; set; }
        public decimal RealSum { get; set; }
        public int CreasonId { get; set; }
    }
}
