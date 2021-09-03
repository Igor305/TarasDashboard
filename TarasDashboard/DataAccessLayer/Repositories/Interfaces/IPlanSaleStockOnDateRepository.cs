using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IPlanSaleStockOnDateRepository
    {
        public Task<List<ItPlanSaleStockOnDate>> getPlanSaleStocksToMonth(DateTime today, DateTime lastday);
    }
}