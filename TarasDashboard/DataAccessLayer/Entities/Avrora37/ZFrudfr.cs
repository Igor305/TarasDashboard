using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZFrudfr
    {
        public short Udfid { get; set; }
        public string Udfname { get; set; }
        public string Udfdesc { get; set; }
        public bool? IsInt { get; set; }
        public int RevId { get; set; }
    }
}
