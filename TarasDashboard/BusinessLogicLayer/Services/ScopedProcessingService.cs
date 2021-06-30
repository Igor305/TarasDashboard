using BusinessLogicLayer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ScopedProcessingService : IScopedProcessingService
    {
        private readonly IBoardService _boardService;
        private int executionCount = 0;
        private readonly ILogger _logger;

        public ScopedProcessingService(ILogger<ScopedProcessingService> logger, IBoardService boardService)
        {
            _logger = logger;
            _boardService = boardService;
        }

        public async Task DoWork(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _boardService.getSaleInCache();
                executionCount++;

                _logger.LogInformation(
                    "Scoped Processing Service is working. Count: {Count}", executionCount);

                await Task.Delay(3600000, stoppingToken);
            }
        }
    }
}
