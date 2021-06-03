using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdBserv
    {
        public int ProdId { get; set; }
        public int BservId { get; set; }
        public string BservName { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int MaxPayPartsQty { get; set; }
    }
}
