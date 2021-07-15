using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ExecutionPlanDateHistory
    {
        public DateTime Dates { get; set; }
        public decimal? ChainPlanDay { get; set; }
        public decimal? ChainFactDay { get; set; }
        public int? StocksQty { get; set; }
        public decimal? ExecutionPlanDayUah { get; set; }
        public decimal? ExecutionPlanDayPercent { get; set; }
        public decimal? ChainPlanToDate { get; set; }
        public decimal? ChainFactToDate { get; set; }
        public decimal? ExecutionPlanToDateUah { get; set; }
        public decimal? ExecutionPlanToDatePercent { get; set; }
    }
}
