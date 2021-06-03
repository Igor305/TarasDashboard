using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSprec
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public DateTime SubDocDate { get; set; }
        public int SubStockId { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value3 { get; set; }
        public short CurrId { get; set; }
        public decimal TcostSumCc { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TnewSumCcNt { get; set; }
        public decimal TnewTaxSum { get; set; }
        public decimal TnewSumCcWt { get; set; }
        public decimal TsubSumCcNt { get; set; }
        public decimal TsubTaxSum { get; set; }
        public decimal TsubSumCcWt { get; set; }
        public decimal TsubNewSumCcNt { get; set; }
        public decimal TsubNewTaxSum { get; set; }
        public decimal TsubNewSumCcWt { get; set; }
        public decimal TsetSumCc { get; set; }
        public int StateCode { get; set; }
    }
}
