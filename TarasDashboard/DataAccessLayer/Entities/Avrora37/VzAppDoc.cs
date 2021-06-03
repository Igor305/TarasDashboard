using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VzAppDoc
    {
        public int AppCode { get; set; }
        public string AppName { get; set; }
        public int DocCatCode { get; set; }
        public int DocGrpCode { get; set; }
        public int DocCode { get; set; }
        public string DocName { get; set; }
        public string DocInfo { get; set; }
        public string FormClass { get; set; }
        public string CodeField { get; set; }
        public string NameField { get; set; }
        public int SyncCode { get; set; }
        public byte SyncType { get; set; }
        public string SyncFields { get; set; }
        public bool FilterBeforeOpen { get; set; }
        public bool HaveTax { get; set; }
        public bool HaveTrans { get; set; }
        public byte CopyType { get; set; }
        public bool HaveState { get; set; }
        public bool UpdateExtLog { get; set; }
        public short BalanceType { get; set; }
        public string LinkEexp { get; set; }
        public string LinkLexp { get; set; }
        public short BalanceFesign { get; set; }
        public int TaxDocType { get; set; }
    }
}
