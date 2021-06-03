using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopyP
    {
        public int CopyId { get; set; }
        public int ParamPosId { get; set; }
        public string ParamDesc { get; set; }
        public string ParamEexp { get; set; }
        public string ParamRexp { get; set; }
        public bool AskParam { get; set; }
        public byte DataType { get; set; }
    }
}
