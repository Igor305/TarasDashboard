using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyUv
    {
        public int CopyId { get; set; }
        public int UvarAskPosId { get; set; }
        public string UvarDesc { get; set; }
        public string UvarNotes { get; set; }
        public int UvarPosId { get; set; }
        public byte UvarType { get; set; }
        public byte IntType { get; set; }
    }
}
