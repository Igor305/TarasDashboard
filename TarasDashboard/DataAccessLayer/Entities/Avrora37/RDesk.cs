using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDesk
    {
        public long ChId { get; set; }
        public int DeskCode { get; set; }
        public string DeskName { get; set; }
        public int DeskLeft { get; set; }
        public int DeskTop { get; set; }
        public int DeskWidth { get; set; }
        public int DeskHeight { get; set; }
        public bool DeskRound { get; set; }
        public int DeskGcode { get; set; }
        public string Notes { get; set; }
    }
}
