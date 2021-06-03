using DataAccessLayer.AppContext;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class SaleLast30Days_ByRegionRepository : ISaleLast30Days_ByRegionRepository
    {
        private readonly Avrora37Context _avrora37Context;

        public SaleLast30Days_ByRegionRepository(Avrora37Context avrora37Context)
        {
            _avrora37Context = avrora37Context;
        }

        public async Task<List<IpSaleLast30Days_ByRegion>> getSaleLast30Days_ByRegion()
        {
            List <IpSaleLast30Days_ByRegion> ipSaleLast30Days_ByRegions = await _avrora37Context.IpSaleLast30Days_ByRegions.FromSqlRaw("EXECUTE dbo.ip_SaleLast30Days_ByRegion").ToListAsync();

            return ipSaleLast30Days_ByRegions;
        }
    }
}
