using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZFrudfrd
    {
        public short Udfid { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public string Lexp { get; set; }
        public string Eexp { get; set; }
    }
}
