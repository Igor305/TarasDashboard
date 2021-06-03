using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogRProd
    {
        public long LogId { get; set; }
        public DateTime LogDate { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string Notes { get; set; }
        public string UserName { get; set; }
        public string OldProdName { get; set; }
        public string OldNotes { get; set; }
    }
}
