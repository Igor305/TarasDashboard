using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvDcardSalesIndexed
    {
        public string DcardId { get; set; }
        public DateTime LogDate { get; set; }
        public long ChId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal TsumCcWt { get; set; }
        public int StockId { get; set; }
        public int BonusType { get; set; }
    }
}
