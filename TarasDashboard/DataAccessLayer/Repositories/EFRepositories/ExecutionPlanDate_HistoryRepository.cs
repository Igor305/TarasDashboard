using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<ExecutionPlanDateHistory>> getAllForThisMonth()
        {
            DateTime dateTime = DateTime.Now;

            if (dateTime.Day == 1)
            {
                dateTime = dateTime.AddDays(-1);
            }

            List<ExecutionPlanDateHistory> executionPlanDateHistories = await _avrora37Context.ExecutionPlanDateHistories.Where(x=>x.Dates.Month == dateTime.Month && x.Dates.Year == dateTime.Year).OrderByDescending(x=>x.Dates).ToListAsync();

            return executionPlanDateHistories;
        }
    }
}
