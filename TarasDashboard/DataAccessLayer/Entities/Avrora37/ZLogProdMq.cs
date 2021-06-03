using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogProdMq
    {
        public long LogId { get; set; }
        public int ProdId { get; set; }
        public DateTime LogDate { get; set; }
        public string OldBarCode { get; set; }
        public string NewBarCode { get; set; }
        public string UserName { get; set; }
    }
}
