using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItAllrateBasesCat
    {
        public int ChId { get; set; }
        public int DocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int Statecode { get; set; }
    }
}
