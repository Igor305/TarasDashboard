using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdAc
    {
        public int ProdId { get; set; }
        public int Plid { get; set; }
        public byte ChPlid { get; set; }
        public string ExpE { get; set; }
        public string ExpR { get; set; }
        public string Notes { get; set; }
    }
}
