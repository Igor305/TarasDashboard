using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCandidateFile
    {
        public int SrcPosId { get; set; }
        public int CandidateId { get; set; }
        public int EmpDocId { get; set; }
        public DateTime FileDate { get; set; }
        public string FilePath { get; set; }
        public Guid FileId { get; set; }
    }
}
