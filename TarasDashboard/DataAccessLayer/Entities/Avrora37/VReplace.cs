using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VReplace
    {
        public int RepId { get; set; }
        public string SourceGrName { get; set; }
        public short SourceId { get; set; }
        public string FieldName { get; set; }
        public bool UseTables { get; set; }
        public string Eexp { get; set; }
        public string Lexp { get; set; }

        public virtual VField VField { get; set; }
    }
}
