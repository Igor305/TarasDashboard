using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RExtFile
    {
        public long ChId { get; set; }
        public int ExtFileId { get; set; }
        public string ExtFileName { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }
}
