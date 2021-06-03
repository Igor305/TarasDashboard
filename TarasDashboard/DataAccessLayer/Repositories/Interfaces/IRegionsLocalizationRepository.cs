using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IRegionsLocalizationRepository
    {
       public Task<List<RegionsLocalization>> getRegions();
    }
}
