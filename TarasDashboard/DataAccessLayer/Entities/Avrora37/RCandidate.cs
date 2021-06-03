using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCandidate
    {
        public long ChId { get; set; }
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string UacandidateName { get; set; }
        public string PostName { get; set; }
        public string LocationName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? InterviewDate { get; set; }
        public int CheckAo { get; set; }
        public int ResultCheckAo { get; set; }
        public string SubName { get; set; }
        public string Notes { get; set; }
        public string TagCname { get; set; }
        public string TagName { get; set; }
        public string SkillName { get; set; }
        public int CandidateStateCode { get; set; }
    }
}
