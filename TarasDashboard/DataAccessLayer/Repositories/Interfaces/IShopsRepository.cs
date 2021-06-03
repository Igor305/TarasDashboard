using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IShopsRepository
    {
        public Task<List<Shop>> getCountTT();
    }
}