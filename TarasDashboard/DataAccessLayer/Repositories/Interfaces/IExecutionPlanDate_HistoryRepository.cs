using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IExecutionPlanDate_HistoryRepository
    {
        public Task<List<ExecutionPlanDateHistory>> getAllForThisMonth();
    }
}
