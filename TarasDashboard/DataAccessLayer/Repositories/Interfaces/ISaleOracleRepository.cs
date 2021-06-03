using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface ISaleOracleRepository
    {
        public Task<List<IpSaleOracle>> getSaleOracleProcedure();
    } 
}
