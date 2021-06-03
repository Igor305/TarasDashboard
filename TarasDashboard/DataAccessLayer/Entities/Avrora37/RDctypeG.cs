using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDctypeG
    {
        public long ChId { get; set; }
        public int DctypeGcode { get; set; }
        public string DctypeGname { get; set; }
        public string Notes { get; set; }
        public bool MainDialog { get; set; }
        public bool CloseDialogAfterEnter { get; set; }
        public int ProcessingId { get; set; }
    }
}
