using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZFile
    {
        public Guid FileId { get; set; }
        public string FileName { get; set; }
        public int ExtFileId { get; set; }
        public DateTime FileDate { get; set; }
        public byte[] FileData { get; set; }
        public int DocCode { get; set; }
    }
}
