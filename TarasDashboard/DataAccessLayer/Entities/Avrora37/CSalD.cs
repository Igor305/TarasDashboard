using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class CSalD
    {
        public long ChId { get; set; }
        public int EmpId { get; set; }
        public short CurrId { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public decimal? SickAc { get; set; }
        public decimal? HolidayAc { get; set; }
        public decimal? SurChargeAc { get; set; }
        public decimal MchargeCc { get; set; }
        public decimal MchargeCc1 { get; set; }
        public decimal MchargeCc2 { get; set; }
        public decimal? AdvanceAc { get; set; }
        public decimal? CreditIn { get; set; }
        public decimal? CreditOut { get; set; }
        public decimal MoreCc { get; set; }
        public decimal MoreCc1 { get; set; }
        public decimal MoreCc2 { get; set; }
        public string Notes { get; set; }
        public decimal SumAc { get; set; }
        public decimal OutAc { get; set; }
        public int PostId { get; set; }
        public int FactDay { get; set; }
        public decimal NormHour { get; set; }
        public decimal FactTime { get; set; }
        public byte SickDays { get; set; }
        public short LeavDays { get; set; }
        public bool IsBonus { get; set; }
        public decimal LeavRate { get; set; }
        public decimal SickRate { get; set; }
        public decimal ShortageCc { get; set; }
        public decimal ShFactTime { get; set; }
        public decimal MobileSumCc { get; set; }
        public decimal LwsumCc { get; set; }
        public decimal UniSocSumCc { get; set; }
        public decimal IncomeTaxSumCc { get; set; }
        public decimal MilitarySumCc { get; set; }
        public decimal AssShortSumCc { get; set; }
        public decimal ExcFactTime { get; set; }
        public decimal? AllFactTime { get; set; }
        public decimal? PrizeForTheLoss { get; set; }
    }
}
