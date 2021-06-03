using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VParam
    {
        public int RepId { get; set; }
        public string ParamName { get; set; }
        public string Lexp { get; set; }
        public string Eexp { get; set; }
        public byte DataType { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
