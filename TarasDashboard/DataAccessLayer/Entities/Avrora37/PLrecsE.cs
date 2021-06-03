using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLrecsE
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public short DetSubId { get; set; }
        public short DetDepId { get; set; }
        public long AchId { get; set; }
        public decimal MainSumCc { get; set; }
        public decimal ExtraSumCc { get; set; }
        public decimal MoreSumCc { get; set; }
        public decimal NeglibleSumCc { get; set; }
        public decimal DeductionSumCc { get; set; }
        public decimal BtotPensCc { get; set; }
        public decimal BtotUnEmployCc { get; set; }
        public decimal BtotSocInsureCc { get; set; }
        public decimal BtotAccidentCc { get; set; }
        public decimal BincomeTaxCc { get; set; }
        public decimal BpensCc { get; set; }
        public decimal BunEmployCc { get; set; }
        public decimal BsocInsureCc { get; set; }
        public decimal Bindexing { get; set; }
        public int BprivIncomeTax { get; set; }
        public decimal TotPensCc { get; set; }
        public decimal TotUnEmployCc { get; set; }
        public decimal TotSocInsureCc { get; set; }
        public decimal TotAccidentCc { get; set; }
        public decimal IncomeTaxCc { get; set; }
        public decimal PensCc { get; set; }
        public decimal UnEmployCc { get; set; }
        public decimal SocInsureCc { get; set; }
        public decimal ChargeSumCc { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
