using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRestShift
    {
        public TRestShift()
        {
            TRestShiftDs = new HashSet<TRestShiftD>();
        }

        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DocTime { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public DateTime ShiftOpenTime { get; set; }
        public DateTime? ShiftCloseTime { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public int OperId { get; set; }
        public int StateCode { get; set; }

        public virtual ICollection<TRestShiftD> TRestShiftDs { get; set; }
    }
}
