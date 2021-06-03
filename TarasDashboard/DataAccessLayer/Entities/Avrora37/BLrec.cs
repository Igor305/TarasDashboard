using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BLrec
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public byte WorkDays { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
        public short CurrId { get; set; }
        public decimal TadvanceCc { get; set; }
        public decimal TalimonyCc { get; set; }
        public decimal TchargeCc { get; set; }
        public decimal TcrateCc { get; set; }
        public decimal TempTaxCc { get; set; }
        public decimal TincomeTaxCc { get; set; }
        public decimal TinsureCc { get; set; }
        public decimal TinsureTaxCc { get; set; }
        public decimal TleaveCc { get; set; }
        public decimal TloanCc { get; set; }
        public decimal TmchargeCc { get; set; }
        public decimal TmchargeCc1 { get; set; }
        public decimal TmchargeCc2 { get; set; }
        public decimal TmhelpCc { get; set; }
        public decimal TmoreCc { get; set; }
        public decimal TmoreCc1 { get; set; }
        public decimal TmoreCc2 { get; set; }
        public decimal TnleaveCc { get; set; }
        public decimal TpensionTaxCc { get; set; }
        public decimal TpregCc { get; set; }
        public decimal TsickCc { get; set; }
        public decimal TunionCc { get; set; }
    }
}
