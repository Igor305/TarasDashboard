using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BBankPayAc
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public string AccountAc { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int CompId { get; set; }
        public string CompAccountAc { get; set; }
        public string CompBank { get; set; }
        public string CompBankSwift { get; set; }
        public string CorrBank { get; set; }
        public string CorrBankSwift { get; set; }
        public short CurrId { get; set; }
        public decimal SumAc { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public string Subject { get; set; }
        public byte PayType { get; set; }
        public bool OurBankPays { get; set; }
        public bool OtherBankPays { get; set; }
        public string CompBankBlz { get; set; }
        public string CompBankFw { get; set; }
        public string CorrBankBlz { get; set; }
        public string CorrBankFw { get; set; }
        public short? BankOperId { get; set; }
        public short? CounId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
    }
}
