using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface ISaleLast30Days_ByRegionRepository
    {
        public Task<List<IpSaleLast30Days_ByRegion>> getSaleLast30Days_ByRegion();
    }
}
