using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IImpTempl
    {
        public short TemplId { get; set; }
        public string TmpTableName { get; set; }
        public bool IsImport { get; set; }
        public string Notes { get; set; }
        public string Spname { get; set; }
        public string TemplName { get; set; }
    }
}
