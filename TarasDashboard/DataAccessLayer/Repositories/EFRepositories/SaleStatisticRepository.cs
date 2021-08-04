using DataAccessLayer.AppContext;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class SaleStatisticRepository : ISaleStatisticRepository
    {
        private readonly Avrora37Context _avrora37Context;

        public SaleStatisticRepository(Avrora37Context avrora37Context)
        {
            _avrora37Context = avrora37Context;
        }

        public async Task<List<SaleStatistic>> getSaleStatistic()
        {
            List<SaleStatistic> ipSaleStatistics = await _avrora37Context.SaleStatistics.OrderByDescending(x=>x.DateOfData).ToListAsync();

            return ipSaleStatistics;
        }
    }
}
