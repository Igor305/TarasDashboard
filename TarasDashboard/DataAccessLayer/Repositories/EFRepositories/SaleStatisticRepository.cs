using DataAccessLayer.AppContext;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        public async Task<List<IpSaleStatistic>> getSaleStatistic()
        {
            List<IpSaleStatistic> ipSaleStatistics = await _avrora37Context.IpSaleStatistics.FromSqlRaw("EXECUTE dbo.ip_SaleStatistic").ToListAsync();

            return ipSaleStatistics;
        }
    }
}
