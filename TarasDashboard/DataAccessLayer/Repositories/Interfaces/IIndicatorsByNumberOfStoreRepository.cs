using DataAccessLayer.Entities.Avrora;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public  interface IIndicatorsByNumberOfStoreRepository
    {
        public Task<IndicatorsByNumberOfStore> get();
    }
}
