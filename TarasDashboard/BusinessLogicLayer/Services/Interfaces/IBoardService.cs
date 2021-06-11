using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IBoardService
    {
        public SaleResponseModel getStaticSale();
        public Task getSaleInCache();
        public byte[] getExcel(List<SaleRegionsModel> saleRegionsModels);
    }
}
