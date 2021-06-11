using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TarasDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IBoardService _boardService;

        public StatisticsController(IBoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet]

        public SaleResponseModel getSale()
        {
           SaleResponseModel saleResponseModel =  _boardService.getStaticSale();

           return saleResponseModel;
        }

        [HttpPost("getExcel")]

        public byte[] getExcel([FromBody] List<SaleRegionsModel> saleRegionsModels)
        {
            byte[] excel = _boardService.getExcel(saleRegionsModels);

            return excel;
        }
    }
}
