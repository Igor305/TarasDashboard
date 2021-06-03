using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSaleTemp
    {
        public long ChId { get; set; }
        public short Crid { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DocTime { get; set; }
        public int DocState { get; set; }
        public decimal RateMc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public string CreditId { get; set; }
        public decimal Discount { get; set; }
        public string Notes { get; set; }
        public int DeskCode { get; set; }
        public int OperId { get; set; }
        public int? Visitors { get; set; }
        public decimal? CashSumCc { get; set; }
        public decimal? ChangeSumCc { get; set; }
        public long? SaleDocId { get; set; }
        public int EmpId { get; set; }
        public bool IsPrinted { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int Wpid { get; set; }
        public string ClientInfo { get; set; }
        public string ExtraInfo { get; set; }
    }
}
