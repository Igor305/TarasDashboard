using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRlogD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public decimal RecQty { get; set; }
        public decimal RecSum { get; set; }
        public decimal CeppQty { get; set; }
        public decimal CeppSumCc { get; set; }
        public decimal SeppQty { get; set; }
        public decimal SeppSumCc { get; set; }
        public decimal DisdQty { get; set; }
        public decimal DisdSumCc { get; set; }
        public decimal SentQty { get; set; }
        public decimal AcceptQty { get; set; }
        public decimal DiffQty { get; set; }
        public decimal WrongDelivQty { get; set; }
        public decimal DiffSum { get; set; }
        public decimal PlpriceCc { get; set; }
        public decimal WrongDelivSumCc { get; set; }
        public decimal DeppQty { get; set; }
        public decimal DeppSumCc { get; set; }
        public bool IsWrongHung { get; set; }
        public string Notes { get; set; }
        public decimal WrongShopSumCc { get; set; }
        public decimal WrongDisSumCc { get; set; }
        public decimal ShortSumCc { get; set; }
    }
}
