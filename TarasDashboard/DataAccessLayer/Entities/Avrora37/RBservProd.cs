using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RBservProd
    {
        public int BservId { get; set; }
        public int SrcPosId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int MaxPayPartsQty { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
    }
}
