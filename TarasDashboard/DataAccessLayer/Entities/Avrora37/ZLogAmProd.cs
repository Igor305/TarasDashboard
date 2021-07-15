using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogAmProd
    {
        public int LogId { get; set; }
        public DateTime LogDate { get; set; }
        public int ProdId { get; set; }
        public int Amid { get; set; }
        public string UserName { get; set; }
        public bool? IsCreate { get; set; }
    }
}
