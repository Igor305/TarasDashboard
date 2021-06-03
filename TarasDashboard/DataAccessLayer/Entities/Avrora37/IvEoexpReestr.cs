﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvEoexpReestr
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int CompId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal Discount { get; set; }
        public short PayDelay { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public short CurrId { get; set; }
        public DateTime? ExpDate { get; set; }
        public bool ExpSn { get; set; }
        public DateTime? NotDate { get; set; }
        public bool NotSn { get; set; }
        public decimal? TranAc { get; set; }
        public decimal? MoreAc { get; set; }
        public short SupplyDayCount { get; set; }
        public DateTime? OrdBdate { get; set; }
        public DateTime? OrdEdate { get; set; }
        public short OrdDayCount { get; set; }
        public string IntDocId { get; set; }
        public decimal TsumAc { get; set; }
        public decimal TnewSumAc { get; set; }
        public decimal TspendSumCc { get; set; }
        public decimal TrouteSumCc { get; set; }
        public int StateCode { get; set; }
        public int CompGrId2 { get; set; }
    }
}
