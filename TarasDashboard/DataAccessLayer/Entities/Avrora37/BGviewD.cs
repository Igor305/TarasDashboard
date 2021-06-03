using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BGviewD
    {
        public int ViewId { get; set; }
        public string DimName { get; set; }
        public string DimCaption { get; set; }
        public byte DimState { get; set; }
        public byte DimLastState { get; set; }
        public byte DimIndex { get; set; }
        public byte DimSort { get; set; }
        public byte DimLoc { get; set; }
        public short DimWidth { get; set; }
        public byte DimGroup { get; set; }
        public byte? DimGroupType { get; set; }
        public string ParentCaption { get; set; }
    }
}
