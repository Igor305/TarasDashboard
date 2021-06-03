using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRlogDd
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int DetSrcPosId { get; set; }
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public long ParentDocId { get; set; }
        public DateTime? ParentDocDate { get; set; }
        public string ChildDocId { get; set; }
        public DateTime? ChildDocDate { get; set; }
        public decimal SentQty { get; set; }
        public decimal AcceptQty { get; set; }
        public decimal DiffQty { get; set; }
        public bool WrongDeliv { get; set; }
        public bool IsWrongDis { get; set; }
        public bool IsWrongShop { get; set; }
        public bool IsShortage { get; set; }
        public string Notes { get; set; }
    }
}
