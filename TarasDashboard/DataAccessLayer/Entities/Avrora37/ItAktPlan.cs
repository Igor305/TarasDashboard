using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItAktPlan
    {
        public ItAktPlan()
        {
            ItAktPlanSpends = new HashSet<ItAktPlanSpend>();
        }

        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int DiscCode { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public int CompId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public string SrcDocId { get; set; }
        public DateTime? SrcDocDate { get; set; }
        public short CurrId { get; set; }
        public int StateCode { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int Plid { get; set; }

        public virtual ICollection<ItAktPlanSpend> ItAktPlanSpends { get; set; }
    }
}
