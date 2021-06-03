using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDoc
    {
        public ZDoc()
        {
            RStateDocs = new HashSet<RStateDoc>();
            TCrjournals = new HashSet<TCrjournal>();
            ZAccDefDocs = new HashSet<ZAccDefDoc>();
            ZAppDocs = new HashSet<ZAppDoc>();
            ZAutoUpdates = new HashSet<ZAutoUpdate>();
            ZDocDcs = new HashSet<ZDocDc>();
            ZDocForms = new HashSet<ZDocForm>();
            ZDocPrints = new HashSet<ZDocPrint>();
            ZDocRoles = new HashSet<ZDocRole>();
            ZDocSheds = new HashSet<ZDocShed>();
            ZDocUsers = new HashSet<ZDocUser>();
            ZLogPrints = new HashSet<ZLogPrint>();
            ZLogStates = new HashSet<ZLogState>();
            ZLogStockAttributes = new HashSet<ZLogStockAttribute>();
            ZRoleDocs = new HashSet<ZRoleDoc>();
            ZTables = new HashSet<ZTable>();
            ZToolDocs = new HashSet<ZToolDoc>();
            ZUserDocs = new HashSet<ZUserDoc>();
        }

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

        public virtual ZDocCat DocCatCodeNavigation { get; set; }
        public virtual ZDocGrp DocGrpCodeNavigation { get; set; }
        public virtual ICollection<RStateDoc> RStateDocs { get; set; }
        public virtual ICollection<TCrjournal> TCrjournals { get; set; }
        public virtual ICollection<ZAccDefDoc> ZAccDefDocs { get; set; }
        public virtual ICollection<ZAppDoc> ZAppDocs { get; set; }
        public virtual ICollection<ZAutoUpdate> ZAutoUpdates { get; set; }
        public virtual ICollection<ZDocDc> ZDocDcs { get; set; }
        public virtual ICollection<ZDocForm> ZDocForms { get; set; }
        public virtual ICollection<ZDocPrint> ZDocPrints { get; set; }
        public virtual ICollection<ZDocRole> ZDocRoles { get; set; }
        public virtual ICollection<ZDocShed> ZDocSheds { get; set; }
        public virtual ICollection<ZDocUser> ZDocUsers { get; set; }
        public virtual ICollection<ZLogPrint> ZLogPrints { get; set; }
        public virtual ICollection<ZLogState> ZLogStates { get; set; }
        public virtual ICollection<ZLogStockAttribute> ZLogStockAttributes { get; set; }
        public virtual ICollection<ZRoleDoc> ZRoleDocs { get; set; }
        public virtual ICollection<ZTable> ZTables { get; set; }
        public virtual ICollection<ZToolDoc> ZToolDocs { get; set; }
        public virtual ICollection<ZUserDoc> ZUserDocs { get; set; }
    }
}
