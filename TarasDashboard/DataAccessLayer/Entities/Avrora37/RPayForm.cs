using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPayForm
    {
        public long ChId { get; set; }
        public int PayFormCode { get; set; }
        public string PayFormName { get; set; }
        public string Notes { get; set; }
        public string SumLabel { get; set; }
        public string NotesLabel { get; set; }
        public bool CanEnterNotes { get; set; }
        public string NotesMask { get; set; }
        public bool CanEnterSum { get; set; }
        public int MaxQty { get; set; }
        public bool IsDefault { get; set; }
        public bool ForSale { get; set; }
        public bool ForRet { get; set; }
        public int AutoCalcSum { get; set; }
        public int DctypeGcode { get; set; }
        public int GroupPays { get; set; }
    }
}
