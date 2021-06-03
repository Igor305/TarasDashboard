using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RAsset
    {
        public long ChId { get; set; }
        public int AssId { get; set; }
        public string AssName { get; set; }
        public string Notes { get; set; }
        public string IntId { get; set; }
        public string FacId { get; set; }
        public DateTime? AssDate { get; set; }
        public int OurId { get; set; }
    }
}
