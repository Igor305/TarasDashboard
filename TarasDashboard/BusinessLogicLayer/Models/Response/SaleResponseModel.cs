using System.Collections.Generic;

namespace BusinessLogicLayer.Models.Response
{
    public class SaleResponseModel
    {
        public SaleOracleModel saleOracleModel { get; set; }
        public List<SaleStatisticModel> saleStatisticModels { get; set; }
        public List<SaleRegionsModel> saleRegionsModels { get; set; }
        public SaleRegionsModel lastLines { get; set; }
        public List<ExecutionPlanDate_HistoryModel> executionPlanDate_HistoryModels { get; set; }
        public List<DiagramModel> diagramModels { get; set; }
        public string Date {get; set;} 
        public string Time { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }

        public SaleResponseModel()
        {
            saleStatisticModels = new List<SaleStatisticModel>();
            saleRegionsModels = new List<SaleRegionsModel>();
            executionPlanDate_HistoryModels = new List<ExecutionPlanDate_HistoryModel>();
            diagramModels = new List<DiagramModel>();
        }
    }
}
