using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IPlanSaleStockOnDateDRepository
    {
        public Task<List<ItPlanSaleStockOnDateD>> getPlanSaleStocksOnDateD(long firstPlan, long lastPlan);
    }
}
