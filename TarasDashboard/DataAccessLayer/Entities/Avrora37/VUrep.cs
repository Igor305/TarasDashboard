using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VUrep
    {
        public int RepId { get; set; }
        public short UserId { get; set; }
        public DateTime? Bdate { get; set; }
        public DateTime? Edate { get; set; }
        public int? DataWidth { get; set; }
        public int? RowHeight { get; set; }
        public byte Processors { get; set; }
        public short FromLeft { get; set; }
        public short FromTop { get; set; }
        public int Width { get; set; }
        public short Height { get; set; }
        public byte WindowState { get; set; }
        public bool GrandCols { get; set; }
        public bool GrandRows { get; set; }
        public bool AlwaysPrepare { get; set; }
        public int? Optimization { get; set; }
        public bool TempTable { get; set; }
        public bool FilterOnOpen { get; set; }
        public bool? FilterOnPrepare { get; set; }
        public string DateField { get; set; }
        public bool RepNotesOpen { get; set; }
        public string AzPrepareTime { get; set; }
        public string TotalTime { get; set; }
        public string LastOpen { get; set; }
        public int OpenCount { get; set; }
        public bool SendError { get; set; }
        public int VerId { get; set; }
        public DateTime? VerDateTime { get; set; }
        public string VerName { get; set; }
        public bool FixCols { get; set; }
        public bool? FixRows { get; set; }
        public string ObjectDef { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
