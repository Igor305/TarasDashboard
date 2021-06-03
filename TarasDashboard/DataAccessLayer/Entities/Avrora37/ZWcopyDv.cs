using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyDv
    {
        public long AchId { get; set; }
        public int FieldPosId { get; set; }
        public int VariantPosId { get; set; }
        public string ExcDesc { get; set; }
        public string ExcNotes { get; set; }
        public string ExcEexp { get; set; }
        public string ExcRexp { get; set; }
        public bool UseDefault { get; set; }
        public int UvarPosId { get; set; }
        public byte UvarType { get; set; }
        public int UintPosId { get; set; }
        public long SrcAchId { get; set; }
        public int SrcFieldPosId { get; set; }
    }
}
