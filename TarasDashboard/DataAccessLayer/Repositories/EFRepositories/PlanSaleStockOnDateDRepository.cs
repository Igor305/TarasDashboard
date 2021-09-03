using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class PlanSaleStockOnDateDRepository : IPlanSaleStockOnDateDRepository
    {
        private readonly Avrora37Context _avrora37Context;

        public PlanSaleStockOnDateDRepository(Avrora37Context avrora37Context)
        {
            _avrora37Context = avrora37Context;
        }

        public async Task<List<ItPlanSaleStockOnDateD>> getPlanSaleStocksOnDateD(long firstChId, long lastChId)
        {
            List<ItPlanSaleStockOnDateD> itPlanSaleStockOnDateDs = await _avrora37Context.ItPlanSaleStockOnDateDs.Where(x=>x.ChId >= firstChId && x.ChId <= lastChId).ToListAsync();

            return itPlanSaleStockOnDateDs;
        }
    }
}
