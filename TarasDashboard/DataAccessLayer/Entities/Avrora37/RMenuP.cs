using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RMenuP
    {
        public int MenuId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int? Color { get; set; }
        public int OrderId { get; set; }
    }
}
