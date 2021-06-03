using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItCashRegistersD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public decimal QtyBill1000 { get; set; }
        public decimal SumBill1000 { get; set; }
        public decimal QtyBill500 { get; set; }
        public decimal SumBill500 { get; set; }
        public decimal QtyBill200 { get; set; }
        public decimal SumBill200 { get; set; }
        public decimal QtyBill100 { get; set; }
        public decimal SumBill100 { get; set; }
        public decimal QtyBill50 { get; set; }
        public decimal SumBill50 { get; set; }
        public decimal QtyBill20 { get; set; }
        public decimal SumBill20 { get; set; }
        public decimal QtyBill10 { get; set; }
        public decimal SumBill10 { get; set; }
        public decimal QtyBill5 { get; set; }
        public decimal SumBill5 { get; set; }
        public decimal QtyBill2 { get; set; }
        public decimal SumBill2 { get; set; }
        public decimal QtyBill1 { get; set; }
        public decimal SumBill1 { get; set; }
        public string NotesCodeId21850 { get; set; }
        public string NotesCodeId21905 { get; set; }
        public string NotesCodeId22031 { get; set; }
        public string NotesCodeId22061 { get; set; }
        public string NotesCodeId22069 { get; set; }
        public string NotesCodeId22070 { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
