using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItDisEmp
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int EmpId { get; set; }
        public int Spell { get; set; }
        public DateTime Btime { get; set; }
        public DateTime Etime { get; set; }
        public int? DifTime { get; set; }
        public int? SrcPosIdProd { get; set; }
        public int? EmpFillingId { get; set; }
    }
}
