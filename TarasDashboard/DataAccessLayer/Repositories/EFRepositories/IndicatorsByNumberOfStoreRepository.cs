using DataAccessLayer.AppContext;
using DataAccessLayer.Entities.Avrora;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class IndicatorsByNumberOfStoreRepository : IIndicatorsByNumberOfStoreRepository
    {
        private readonly AvroraContext _avroraContext;

        public IndicatorsByNumberOfStoreRepository(AvroraContext avroraContext)
        {
            _avroraContext = avroraContext;
        }

        public async Task<IndicatorsByNumberOfStore> get()
        {
            IndicatorsByNumberOfStore indicatorsByNumberOfStore = await _avroraContext.IndicatorsByNumberOfStores.FirstOrDefaultAsync();

            return indicatorsByNumberOfStore;
        }
    }
}
