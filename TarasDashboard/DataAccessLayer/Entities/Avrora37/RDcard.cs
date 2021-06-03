using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDcard
    {
        public RDcard()
        {
            ItImpDcardIds = new HashSet<ItImpDcardId>();
            TCrrets = new HashSet<TCrret>();
            TLogDiscExpPs = new HashSet<TLogDiscExpP>();
            TLogDiscExps = new HashSet<TLogDiscExp>();
            TLogDiscRecs = new HashSet<TLogDiscRec>();
            TSales = new HashSet<TSale>();
            TempLogDiscRecs = new HashSet<TempLogDiscRec>();
            ZDocDcs = new HashSet<ZDocDc>();
            ZLogDiscExpPs = new HashSet<ZLogDiscExpP>();
            ZLogDiscExps = new HashSet<ZLogDiscExp>();
            ZLogDiscRecs = new HashSet<ZLogDiscRec>();
        }

        public long ChId { get; set; }
        public int CompId { get; set; }
        public string DcardId { get; set; }
        public decimal Discount { get; set; }
        public decimal? SumCc { get; set; }
        public bool InUse { get; set; }
        public decimal Value1 { get; set; }
        public decimal Value2 { get; set; }
        public decimal Value3 { get; set; }
        public bool IsCrdCard { get; set; }
        public DateTime? Edate { get; set; }
        public int DctypeCode { get; set; }
        public decimal SumBonus { get; set; }
        public int Status { get; set; }
        public bool ChangeToBonus { get; set; }
        public DateTime? FillingDate { get; set; }
        public bool IsSalary { get; set; }
        public DateTime? Bdate { get; set; }
        public bool IsPayCard { get; set; }
        public bool AskPwddcardEnter { get; set; }
        public bool AutoSaveOddMoneyToProcessing { get; set; }
        public bool? CardTied { get; set; }
        public bool? ChatBot { get; set; }

        public virtual RPersonDc RPersonDc { get; set; }
        public virtual ICollection<ItImpDcardId> ItImpDcardIds { get; set; }
        public virtual ICollection<TCrret> TCrrets { get; set; }
        public virtual ICollection<TLogDiscExpP> TLogDiscExpPs { get; set; }
        public virtual ICollection<TLogDiscExp> TLogDiscExps { get; set; }
        public virtual ICollection<TLogDiscRec> TLogDiscRecs { get; set; }
        public virtual ICollection<TSale> TSales { get; set; }
        public virtual ICollection<TempLogDiscRec> TempLogDiscRecs { get; set; }
        public virtual ICollection<ZDocDc> ZDocDcs { get; set; }
        public virtual ICollection<ZLogDiscExpP> ZLogDiscExpPs { get; set; }
        public virtual ICollection<ZLogDiscExp> ZLogDiscExps { get; set; }
        public virtual ICollection<ZLogDiscRec> ZLogDiscRecs { get; set; }
    }
}
