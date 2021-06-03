using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VDelIndexOptimize
    {
        public string Dbname { get; set; }
        public string SchemaName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string ObjectTypeDesc { get; set; }
        public string IndexName { get; set; }
        public byte IndexType { get; set; }
        public string IndexTypeDesc { get; set; }
        public bool? IndexIsUnique { get; set; }
        public bool? IndexIsPk { get; set; }
        public bool? IndexIsUniqueConstraint { get; set; }
        public long? IndexAdvantage { get; set; }
        public short DatabaseId { get; set; }
        public int ObjectId { get; set; }
        public int IndexId { get; set; }
        public long UserSeeks { get; set; }
        public long UserScans { get; set; }
        public long UserLookups { get; set; }
        public long UserUpdates { get; set; }
        public long SystemSeeks { get; set; }
        public long SystemScans { get; set; }
        public long SystemLookups { get; set; }
        public long SystemUpdates { get; set; }
        public DateTime? LastUserSeek { get; set; }
        public DateTime? LastUserScan { get; set; }
        public DateTime? LastUserLookup { get; set; }
        public DateTime? LastSystemSeek { get; set; }
        public DateTime? LastSystemScan { get; set; }
        public DateTime? LastSystemLookup { get; set; }
        public string FilterDefinition { get; set; }
        public string Columns { get; set; }
        public string IncludeColumns { get; set; }
    }
}
