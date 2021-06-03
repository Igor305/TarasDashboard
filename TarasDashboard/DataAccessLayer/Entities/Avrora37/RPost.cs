using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPost
    {
        public long ChId { get; set; }
        public int PostId { get; set; }
        public string PostName { get; set; }
        public short PostCid { get; set; }
        public byte SalaryType { get; set; }
        public byte PostTypeId { get; set; }
        public string Notes { get; set; }
        public int CostGaccId { get; set; }
        public int? Rank { get; set; }
        public string PostClassifierCode { get; set; }
    }
}
