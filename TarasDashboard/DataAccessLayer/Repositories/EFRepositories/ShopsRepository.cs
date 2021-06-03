using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class ShopsRepository : IShopsRepository
    {
        private readonly ShopsContext _shopsContext;

        public ShopsRepository(ShopsContext shopsContext)
        {
            _shopsContext = shopsContext;
        }

        public async Task<List<Shop>> getCountTT()
        {
            List<Shop> shops = await _shopsContext.Shops.Where(x => x.StatusId == 25).ToListAsync();

            return shops;
        }
    }
}
