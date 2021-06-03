using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TVenI
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string BarCode { get; set; }
        public int ProdId { get; set; }
        public decimal Qty { get; set; }
        public string Um { get; set; }
        public short UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public bool IsQty { get; set; }
        public int InputTypeId { get; set; }
    }
}
