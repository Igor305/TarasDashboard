using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCrjournal
    {
        public long ChId { get; set; }
        public short? Crid { get; set; }
        public string SerialId { get; set; }
        public string FiscalId { get; set; }
        public byte[] Data { get; set; }
        public int? DocTypeId { get; set; }
        public int? DocSubtypeId { get; set; }
        public long XmldocId { get; set; }
        public int? DocCode { get; set; }
        public long? DocChId { get; set; }
        public DateTime? DocTime { get; set; }
        public bool IsFinished { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual TCrjournalDocSubtype DocSubtype { get; set; }
        public virtual TCrjournalDocType DocType { get; set; }
    }
}
