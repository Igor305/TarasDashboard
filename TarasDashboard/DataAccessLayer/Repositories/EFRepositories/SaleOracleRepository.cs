using DataAccessLayer.AppContext;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class SaleOracleRepository : ISaleOracleRepository
    {
        private readonly Avrora37Context _avrora37Context;
        public SaleOracleRepository(Avrora37Context avrora37Context)
        {
            _avrora37Context = avrora37Context;
        }

        public async Task<List<IpSaleOracle>> getSaleOracleProcedure()
        {

           List<IpSaleOracle> ipSaleOracles = await _avrora37Context.IpSaleOracles.FromSqlRaw("EXECUTE dbo.ip_SaleOracle").ToListAsync();

           return ipSaleOracles;
        }
    }
}
