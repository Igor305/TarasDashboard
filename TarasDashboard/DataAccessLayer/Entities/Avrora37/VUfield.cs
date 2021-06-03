using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VUfield
    {
        public int RepId { get; set; }
        public string FieldName { get; set; }
        public short UserId { get; set; }
        public int Location { get; set; }
        public int SrcPosId { get; set; }
        public bool Visible { get; set; }
        public bool VisibleNote { get; set; }
        public int Width { get; set; }
        public byte Alignment { get; set; }
        public byte Layout { get; set; }
        public bool WordWrap { get; set; }
        public bool Negatives { get; set; }
        public byte Operation { get; set; }
        public byte Sorting { get; set; }
        public bool SubTotals { get; set; }
        public bool Separator { get; set; }
        public byte DecimalCount { get; set; }
        public byte FixedCount { get; set; }
        public string Caption { get; set; }
        public byte FieldLevel { get; set; }
        public byte FieldKind { get; set; }
        public byte DataType { get; set; }
        public bool FilterOnly { get; set; }
        public bool HideInFilter { get; set; }
        public short Grouping { get; set; }
        public short GroupFactor { get; set; }
        public string GroupField { get; set; }
        public string Lexpr { get; set; }
        public string Eexpr { get; set; }
        public string Ofilter { get; set; }
        public string Pfilter { get; set; }
        public int FieldPosId { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
