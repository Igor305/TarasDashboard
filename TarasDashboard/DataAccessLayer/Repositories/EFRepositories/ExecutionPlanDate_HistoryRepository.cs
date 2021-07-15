using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class ExecutionPlanDate_HistoryRepository : IExecutionPlanDate_HistoryRepository
    {
        private readonly Avrora37Context _avrora37Context;

        public ExecutionPlanDate_HistoryRepository(Avrora37Context avrora37Context)
        {
            _avrora37Context = avrora37Context;
        }

        public async Task<List<ExecutionPlanDateHistory>> getAll()
        {
            List<ExecutionPlanDateHistory> executionPlanDateHistories = await _avrora37Context.ExecutionPlanDateHistories.ToListAsync();

            return executionPlanDateHistories;
        }

    }
}
