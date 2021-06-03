using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IImpTemplD
    {
        public short TableId { get; set; }
        public short TemplId { get; set; }
        public string FieldName { get; set; }
        public string SrcColName { get; set; }
        public short SrcRowId { get; set; }
    }
}
