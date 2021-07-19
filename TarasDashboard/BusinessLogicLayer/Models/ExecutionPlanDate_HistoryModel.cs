using System;

namespace BusinessLogicLayer.Models
{
    public class ExecutionPlanDate_HistoryModel
    {
        public DateTime Dates { get; set; }
        public string DateString { get; set; }
        public decimal? ChainPlanDay { get; set; }
        public string ChainPlanDayString { get; set; }
        public decimal? ChainFactDay { get; set; }
        public string ChainFactDayString { get; set; }
        public int? StocksQty { get; set; }
        public decimal? ExecutionPlanDayUah { get; set; }
        public string ExecutionPlanDayUahString { get; set; }
        public decimal? ExecutionPlanDayPercent { get; set; }
        public decimal? ChainPlanToDate { get; set; }
        public decimal? ChainFactToDate { get; set; }
        public decimal? ExecutionPlanToDateUah { get; set; }
        public decimal? ExecutionPlanToDatePercent { get; set; }
        public DiagramModel diagramModel { get; set; }

        public ExecutionPlanDate_HistoryModel()
        {
            diagramModel = new DiagramModel();
        }
    }
}
