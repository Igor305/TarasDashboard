using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdMse
    {
        public int ProdId { get; set; }
        public int SprodId { get; set; }
        public string Lexp { get; set; }
        public string Eexp { get; set; }
        public string LexpSub { get; set; }
        public string EexpSub { get; set; }
        public bool UseSubItems { get; set; }
        public bool UseSubDoc { get; set; }
    }
}
