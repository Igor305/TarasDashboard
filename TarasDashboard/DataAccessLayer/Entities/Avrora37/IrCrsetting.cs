using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrCrsetting
    {
        public int StockId { get; set; }
        public short CrId { get; set; }
        public bool AllowCorrectMonIntRec { get; set; }
    }
}
