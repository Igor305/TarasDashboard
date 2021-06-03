using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZTable
    {
        public ZTable()
        {
            ZAccDefTables = new HashSet<ZAccDefTable>();
            ZDataSets = new HashSet<ZDataSet>();
            ZFields = new HashSet<ZField>();
            ZReplicaTables = new HashSet<ZReplicaTable>();
            ZRoleTables = new HashSet<ZRoleTable>();
            ZUserTables = new HashSet<ZUserTable>();
            ZWcopyDs = new HashSet<ZWcopyD>();
            ZWcopyTs = new HashSet<ZWcopyT>();
        }

        public int DocCode { get; set; }
        public int TableCode { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public string TableInfo { get; set; }
        public string DateField { get; set; }
        public string Pkfields { get; set; }
        public string SortFields { get; set; }
        public string IntFilter { get; set; }
        public string OpenFilter { get; set; }
        public bool IsView { get; set; }
        public bool IsDefault { get; set; }
        public bool HaveOur { get; set; }
        public bool ForSync { get; set; }
        public bool UpdateLog { get; set; }
        public bool? SyncAufields { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual ICollection<ZAccDefTable> ZAccDefTables { get; set; }
        public virtual ICollection<ZDataSet> ZDataSets { get; set; }
        public virtual ICollection<ZField> ZFields { get; set; }
        public virtual ICollection<ZReplicaTable> ZReplicaTables { get; set; }
        public virtual ICollection<ZRoleTable> ZRoleTables { get; set; }
        public virtual ICollection<ZUserTable> ZUserTables { get; set; }
        public virtual ICollection<ZWcopyD> ZWcopyDs { get; set; }
        public virtual ICollection<ZWcopyT> ZWcopyTs { get; set; }
    }
}
