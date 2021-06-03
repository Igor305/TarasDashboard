using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDbi
    {
        public long ChId { get; set; }
        public int DbiId { get; set; }
        public string DbiName { get; set; }
        public string Notes { get; set; }
        public bool IsDefault { get; set; }
        public long RangeValue { get; set; }
        public long ChIdStart { get; set; }
        public long ChIdEnd { get; set; }
        public long DocIdStart { get; set; }
        public long DocIdEnd { get; set; }
        public long IntDocIdStart { get; set; }
        public long IntDocIdEnd { get; set; }
        public int RefIdStart { get; set; }
        public int RefIdEnd { get; set; }
        public int PpidStart { get; set; }
        public int PpidEnd { get; set; }
        public int OurId { get; set; }
        public int Pccode { get; set; }
    }
}
