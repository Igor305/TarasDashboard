using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyFv
    {
        public long AchId { get; set; }
        public int FieldPosId { get; set; }
        public int VariantPosId { get; set; }
        public string EfieldExp { get; set; }
        public string RfieldExp { get; set; }
        public string VarDesc { get; set; }
        public string VarNotes { get; set; }
        public bool UseDefault { get; set; }
        public byte FieldAgrType { get; set; }
        public string FieldFilterInt { get; set; }
        public string FieldFilterUser { get; set; }
        public bool AskFilter { get; set; }
        public int UvarPosId { get; set; }
        public byte UvarType { get; set; }
        public int UintPosId { get; set; }
    }
}
