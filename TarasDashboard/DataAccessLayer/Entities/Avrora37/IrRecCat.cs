using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrRecCat
    {
        public long ChId { get; set; }
        public int RecCatId { get; set; }
        public string RecCatName { get; set; }
        public string Notes { get; set; }
        public decimal CostOfArrival { get; set; }
        public decimal ColCatCof { get; set; }
        public decimal RowRatio { get; set; }
        public byte PtypeCodeId { get; set; }
        public int NormPerHour { get; set; }
    }
}
