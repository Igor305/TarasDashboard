using System.Collections.Generic;

namespace BusinessLogicLayer.Models.Response
{
    public class SaleResponseModel
    {
        public SaleOracleModel saleOracleModel { get; set; }
        public List<SaleStatisticModel> saleStatisticModels { get; set; }
        public List<SaleRegionsModel> saleRegionsModels { get; set; }

        public SaleResponseModel()
        {
            saleStatisticModels = new List<SaleStatisticModel>();
            saleRegionsModels = new List<SaleRegionsModel>();
        }
    }
}
