using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdMa
    {
        public int ProdId { get; set; }
        public int AprodId { get; set; }
        public string ValidSets { get; set; }
        public int Priority { get; set; }
        public string Notes { get; set; }
    }
}
