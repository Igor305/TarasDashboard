using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyFf
    {
        public long AchId { get; set; }
        public int FieldPosId { get; set; }
        public int FilterPosId { get; set; }
        public string FieldFilterInt { get; set; }
        public string FilterDesc { get; set; }
        public string FilterNotes { get; set; }
        public bool UseDefault { get; set; }
        public int UvarPosId { get; set; }
        public byte UvarType { get; set; }
        public int UintPosId { get; set; }
    }
}
