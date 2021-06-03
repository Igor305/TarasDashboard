using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvAllrateBasePgrId
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int StateCode { get; set; }
    }
}
