using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RUser
    {
        public RUser()
        {
            RStateRuleUsers = new HashSet<RStateRuleUser>();
            VUgraphs = new HashSet<VUgraph>();
            VUnotifies = new HashSet<VUnotify>();
            VUscripts = new HashSet<VUscript>();
            VUviews = new HashSet<VUview>();
            ZAppUsers = new HashSet<ZAppUser>();
            ZDataSets = new HashSet<ZDataSet>();
            ZDocUsers = new HashSet<ZDocUser>();
            ZLogStates = new HashSet<ZLogState>();
            ZLogStockAttributes = new HashSet<ZLogStockAttribute>();
            ZRoleUsers = new HashSet<ZRoleUser>();
            ZToolUserEvents = new HashSet<ZToolUserEvent>();
            ZUserDocs = new HashSet<ZUserDoc>();
            ZUserObjects = new HashSet<ZUserObject>();
            ZUserTables = new HashSet<ZUserTable>();
            ZUserVars = new HashSet<ZUserVar>();
        }

        public long ChId { get; set; }
        public short UserId { get; set; }
        public string UserName { get; set; }
        public int EmpId { get; set; }
        public bool Admin { get; set; }
        public bool Active { get; set; }
        public bool? Emps { get; set; }
        public bool SPpacc { get; set; }
        public bool SCost { get; set; }
        public bool SCcpl { get; set; }
        public bool SCcprice { get; set; }
        public bool SCcdiscount { get; set; }
        public bool CanCopyRems { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public bool UseOpenAge { get; set; }
        public bool CanInitAltsPl { get; set; }
        public bool? ShowPlcange { get; set; }
        public bool CanChangeStatus { get; set; }
        public bool CanChangeDiscount { get; set; }
        public bool CanPrintDoc { get; set; }
        public bool CanBuffDoc { get; set; }
        public bool CanChangeDocId { get; set; }
        public bool CanChangeKursMc { get; set; }
        public bool AllowRestEditDesk { get; set; }
        public bool AllowRestReserve { get; set; }
        public bool AllowRestMove { get; set; }
        public bool CanExportPrint { get; set; }
        public bool PSalaryAcc { get; set; }
        public bool? AllowRestChequeUnite { get; set; }
        public bool? AllowRestChequeDel { get; set; }
        public byte OpenAgeBtype { get; set; }
        public short OpenAgeBqty { get; set; }
        public byte OpenAgeEtype { get; set; }
        public short OpenAgeEqty { get; set; }
        public bool? AllowRestViewDesk { get; set; }

        public virtual ICollection<RStateRuleUser> RStateRuleUsers { get; set; }
        public virtual ICollection<VUgraph> VUgraphs { get; set; }
        public virtual ICollection<VUnotify> VUnotifies { get; set; }
        public virtual ICollection<VUscript> VUscripts { get; set; }
        public virtual ICollection<VUview> VUviews { get; set; }
        public virtual ICollection<ZAppUser> ZAppUsers { get; set; }
        public virtual ICollection<ZDataSet> ZDataSets { get; set; }
        public virtual ICollection<ZDocUser> ZDocUsers { get; set; }
        public virtual ICollection<ZLogState> ZLogStates { get; set; }
        public virtual ICollection<ZLogStockAttribute> ZLogStockAttributes { get; set; }
        public virtual ICollection<ZRoleUser> ZRoleUsers { get; set; }
        public virtual ICollection<ZToolUserEvent> ZToolUserEvents { get; set; }
        public virtual ICollection<ZUserDoc> ZUserDocs { get; set; }
        public virtual ICollection<ZUserObject> ZUserObjects { get; set; }
        public virtual ICollection<ZUserTable> ZUserTables { get; set; }
        public virtual ICollection<ZUserVar> ZUserVars { get; set; }
    }
}
