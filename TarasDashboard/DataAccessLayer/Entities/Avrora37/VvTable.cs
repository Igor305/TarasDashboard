using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VvTable
    {
        public int RepId { get; set; }
        public short SourceId { get; set; }
        public int ParentIdx { get; set; }
        public int TableIdx { get; set; }
        public int ParentTableCode { get; set; }
        public int TableCode { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public byte JoinLevel { get; set; }
        public int JoinType { get; set; }
        public string RelName { get; set; }
        public int ParentCode { get; set; }
        public string ParentNames { get; set; }
        public string ParentDescs { get; set; }
        public int ChildCode { get; set; }
        public string ChildNames { get; set; }
        public string ChildDescs { get; set; }
    }
}
