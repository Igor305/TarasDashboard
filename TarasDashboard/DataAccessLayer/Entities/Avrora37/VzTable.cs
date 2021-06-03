using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VzTable
    {
        public int DocCatCode { get; set; }
        public int DocGrpCode { get; set; }
        public string DocName { get; set; }
        public string FormClass { get; set; }
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
        public string CodeField { get; set; }
        public string NameField { get; set; }
        public int SyncCode { get; set; }
        public byte SyncType { get; set; }
        public string SyncFields { get; set; }
    }
}
