using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class PlanSaleStockOnDateRepository : IPlanSaleStockOnDateRepository
    {
        private readonly Avrora37Context _avrora37Context;

        public PlanSaleStockOnDateRepository (Avrora37Context avrora37Context)
        {
            _avrora37Context = avrora37Context;
        }

        public async Task<List<ItPlanSaleStockOnDate>> getPlanSaleStocksToMonth(DateTime today, DateTime lastDay) 
        {

            List<ItPlanSaleStockOnDate> itPlanSaleStockOnDates = await _avrora37Context.ItPlanSaleStockOnDates.Where(x => x.DocDate.Date >= today.Date && x.DocDate.Date <= lastDay.Date).ToListAsync();

            return itPlanSaleStockOnDates;
        }
    }
}
