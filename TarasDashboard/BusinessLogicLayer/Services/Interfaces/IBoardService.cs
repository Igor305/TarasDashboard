using BusinessLogicLayer.Models.Response;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IBoardService
    {
        public SaleResponseModel getStaticSale();
        public Task getSaleInCache();
    }
}
