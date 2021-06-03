using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class RegionsLocalizationRepository : IRegionsLocalizationRepository
    {
        private readonly ShopsContext _shopContext;

        public RegionsLocalizationRepository(ShopsContext shopContext)
        {
            _shopContext = shopContext;
        }

        public async Task<List<RegionsLocalization>> getRegions() 
        {
            List<RegionsLocalization> regionsLocalizations = await _shopContext.RegionsLocalizations.Where(x => x.LanguageId == 2).ToListAsync();

            return regionsLocalizations;
        }
    }
}