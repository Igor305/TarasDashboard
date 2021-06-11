using AutoMapper;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class BoardService : IBoardService
    {
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;

        private readonly IShopsRepository _shopsRepository;
        private readonly IRegionsLocalizationRepository _regionsLocalizationRepository;
        private readonly ISaleOracleRepository _saleOracleRepository;
        private readonly ISaleStatisticRepository _saleStatisticRepository;
        private readonly ISaleLast30Days_ByRegionRepository _saleLast30Days_ByRegionRepository;

        public BoardService(IMapper mapper, IMemoryCache memoryCache, IShopsRepository shopsRepository, IRegionsLocalizationRepository regionsLocalizationRepository, 
                            ISaleOracleRepository saleOracleRepository, ISaleStatisticRepository saleStatisticRepository, ISaleLast30Days_ByRegionRepository saleLast30Days_ByRegionRepository)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;

            _shopsRepository = shopsRepository;
            _regionsLocalizationRepository = regionsLocalizationRepository;
            _saleOracleRepository = saleOracleRepository;
            _saleStatisticRepository = saleStatisticRepository;
            _saleLast30Days_ByRegionRepository = saleLast30Days_ByRegionRepository;
        }

        public SaleResponseModel getStaticSale()
        {
            SaleResponseModel saleResponseModel = _memoryCache.Get<SaleResponseModel>("responseModel");

            return saleResponseModel;
        }

        public async Task getSaleInCache()
        {
            try
            {
                SaleOracleModel saleOracleModel = await getSaleOracle();

                List<SaleStatisticModel> saleStatisticModels = await getSaleStatistic();

                List<SaleRegionsModel> saleRegionsModels = await getSaleRegions();

                SaleRegionsModel lastLines = addLastLine(saleRegionsModels);

                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToShortTimeString();

                SaleResponseModel saleResponseModel = new SaleResponseModel();

                saleResponseModel.saleOracleModel = saleOracleModel;
                saleResponseModel.saleStatisticModels = saleStatisticModels;
                saleResponseModel.saleRegionsModels = saleRegionsModels;
                saleResponseModel.lastLines = lastLines;
                saleResponseModel.Date = date;
                saleResponseModel.Time = time;
                saleResponseModel.Status = true;
                saleResponseModel.Message = "successfully";               

                _memoryCache.Set("responseModel", saleResponseModel, new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(3)
                });
            }

            catch (Exception e)
            {
                SaleResponseModel saleResponseModel = new SaleResponseModel();
                saleResponseModel.Status = false;
                saleResponseModel.Message = e.Message;
            }
        }

        private async Task<SaleOracleModel> getSaleOracle()
        {
            List<IpSaleOracle> ipSaleOracles = await _saleOracleRepository.getSaleOracleProcedure();

            List<SaleOracleModel> saleOracleModels = _mapper.Map<List<IpSaleOracle>, List<SaleOracleModel>>(ipSaleOracles);

            SaleOracleModel saleOracleModel = saleOracleModels[0];

            return saleOracleModel;
        }

        private async Task<List<SaleStatisticModel>> getSaleStatistic()
        {

            List<IpSaleStatistic> ipSaleStatistics = await _saleStatisticRepository.getSaleStatistic();

            List<SaleStatisticModel> saleStatisticModels = _mapper.Map<List<IpSaleStatistic>, List<SaleStatisticModel>>(ipSaleStatistics);

            foreach (SaleStatisticModel saleStatisticModel in saleStatisticModels)
            {
                saleStatisticModel.Turnover = Math.Round(saleStatisticModel.Turnover);

                string month = "";

                switch (saleStatisticModel.DateOfData.Month)
                {
                    case 1: month = "січня"; break;
                    case 2: month = "лютого"; break;
                    case 3: month = "березня"; break;
                    case 4: month = "квітня"; break;
                    case 5: month = "травня"; break;
                    case 6: month = "червня"; break;
                    case 7: month = "липня"; break;
                    case 8: month = "серпня"; break;
                    case 9: month = "вересня"; break;
                    case 10: month = "жовтня"; break;
                    case 11: month = "листопада"; break;
                    case 12: month = "грудня"; break;
                }

                saleStatisticModel.DateOfString = $"{saleStatisticModel.DateOfData.Day} {month}";
            }

            return saleStatisticModels;
        }

        private async Task<List<SaleRegionsModel>> getSaleRegions()
        {
            List<Shop> shops = await _shopsRepository.getCountTT();
            List<RegionsLocalization> regionsLocalizations = await _regionsLocalizationRepository.getRegions();

            List<ShopModel> shopsModels = _mapper.Map<List<Shop>, List<ShopModel>>(shops);
            List<RegionsLocalizationModel> regionsLocalizationModels = _mapper.Map<List<RegionsLocalization>, List<RegionsLocalizationModel>>(regionsLocalizations);

            List<PopulationRegionModel> numberTT = new List<PopulationRegionModel>();

            for (int x = 0; x < regionsLocalizationModels.Count; x++)
            {
                numberTT.Add(new PopulationRegionModel
                {
                    Name = regionsLocalizationModels[x].Name,
                    Population = 0
                });              
            }      

            PopulationRegionModel[] numTT = numberTT.ToArray();

            foreach (ShopModel shopModel in shopsModels)
            {
                for (int x = 1; x <= regionsLocalizationModels.Count; x++)
                {
                    if (shopModel.RegionId == x)
                    {
                        numTT[x-1].Population++;
                    }
                }
            }

            List<IpSaleLast30Days_ByRegion> ipSaleLast30Days_ByRegions = await _saleLast30Days_ByRegionRepository.getSaleLast30Days_ByRegion();

            List<SaleLast30Days_ByRegionModel> saleLast30Days_ByRegionModels = _mapper.Map<List<IpSaleLast30Days_ByRegion>, List<SaleLast30Days_ByRegionModel>>(ipSaleLast30Days_ByRegions);

            List<PopulationRegionModel> populationRegionModels = new List<PopulationRegionModel>();

            populationRegionModels.Add(new PopulationRegionModel{Name = "Вінницька", Population = 1524100 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Волинська", Population = 1026400 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Дніпропетровська", Population = 3132400 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Донецька", Population = 4091800 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Житомирська", Population = 1191500 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Закарпатська", Population = 1248200 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Запорізька", Population = 1660800 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Івано-Франківська", Population = 1357900 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Київ", Population = 2958700 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Київська", Population = 1787400 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Кіровоградська", Population = 916400 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Луганська", Population = 2117200 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Львівська", Population = 2492200 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Миколаївська", Population = 1104700 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Одеська", Population = 2363900 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Полтавська", Population = 1367300 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Рівненська", Population = 1147100 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Сумська", Population = 1049600 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Тернопільська", Population = 1028400 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Харківська", Population = 2626200 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Херсонська", Population = 1013500 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Хмельницька", Population = 1240300 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Черкаська", Population = 1174200 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Чернівецька", Population = 895100 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Чернігівська", Population = 972500 });

            List<PopulationRegionModel> populationForOneTT = new List<PopulationRegionModel>();
            List<PopulationRegionModel> salesForOnePeoples = new List<PopulationRegionModel>();

            for (int x = 0; x < numTT.Length; x++)
            {
                if (populationRegionModels[x].Name == numTT[x].Name)
                {
                    if (numTT[x].Population == 0)
                    {
                        populationForOneTT.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = 0 });
                        salesForOnePeoples.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = 0 });
                    }

                    else
                    {
                        double populationRegion = populationRegionModels[x].Population / numTT[x].Population;
                        populationRegion = Math.Round(populationRegion, 2);
                        populationForOneTT.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = populationRegion });

                        foreach (SaleLast30Days_ByRegionModel saleLast30Days_ByRegionModel in saleLast30Days_ByRegionModels)
                        {
                            if (numTT[x].Name == saleLast30Days_ByRegionModel.RegionName)
                            {
                                double salesForOnePeople = saleLast30Days_ByRegionModel.SaleSum / populationRegionModels[x].Population;
                                salesForOnePeople = Math.Round(salesForOnePeople, 2);
                                salesForOnePeoples.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = salesForOnePeople });
                            }
                        }
                    }
                }                          
            }

            List<SaleRegionsModel> saleRegionsModels = new List<SaleRegionsModel>();

            for (int i = 0; i < numTT.Length; i++)
            {
                if (i < saleLast30Days_ByRegionModels.Count)
                {
                    saleRegionsModels.Add(new SaleRegionsModel
                    {
                        Name = numTT[i].Name,
                        Population = Math.Round(populationRegionModels[i].Population / 1000000, 2),
                        NumberTT = numTT[i].Population,
                        PopulationForOneTT = Math.Round(populationForOneTT[i].Population / 1000, 2),
                        SalesInThe30Days = Math.Round(saleLast30Days_ByRegionModels[i].SaleSum / 1000000, 2),
                        SalesForOnePeople = salesForOnePeoples[i].Population
                    });
                }

                if (i >= saleLast30Days_ByRegionModels.Count)
                {
                    saleRegionsModels.Add(new SaleRegionsModel
                    {
                        Name = numTT[i].Name,
                        Population = Math.Round(populationRegionModels[i].Population / 1000000, 2),
                        NumberTT = numTT[i].Population,
                        PopulationForOneTT = Math.Round(populationForOneTT[i].Population / 1000, 2),
                        SalesInThe30Days = 0,
                        SalesForOnePeople = salesForOnePeoples[i].Population
                    });
                }
            }

            saleRegionsModels = getPercentsSalesForOnePeople(saleRegionsModels);

            return saleRegionsModels;
        }

        private List<SaleRegionsModel> getPercentsSalesForOnePeople(List<SaleRegionsModel> saleRegionsModels)
        {
            double maxSalesForOnePeople = 0;

            foreach (SaleRegionsModel saleRegionsModel in saleRegionsModels)
            {
                if (maxSalesForOnePeople < saleRegionsModel.SalesForOnePeople)
                {
                    maxSalesForOnePeople = saleRegionsModel.SalesForOnePeople;
                }
            }

            foreach (SaleRegionsModel saleRegionsModel in saleRegionsModels)
            {
                saleRegionsModel.PercentSalesForOnePeople = saleRegionsModel.SalesForOnePeople * 100 / maxSalesForOnePeople;
            }

            return saleRegionsModels;
        }

        private SaleRegionsModel addLastLine(List<SaleRegionsModel> saleRegionsModels)
        {
            SaleRegionsModel lastLineModel = new SaleRegionsModel();

            double lastPopulation = 0;
            double lastNumberTT = 0;
            double lastPopulationForOneTT = 0;
            double lastSalesForOnePeople = 0;

            double maxSalesForOnePeople = 0;
            double beforeMaxSalesForOnePeople = 0;

            foreach (SaleRegionsModel saleRegionsModel in saleRegionsModels)
            {
                lastPopulation += saleRegionsModel.Population;
                lastNumberTT += saleRegionsModel.NumberTT;

                if (maxSalesForOnePeople < saleRegionsModel.SalesForOnePeople)
                {
                    maxSalesForOnePeople = saleRegionsModel.SalesForOnePeople;
                }

                if (beforeMaxSalesForOnePeople < saleRegionsModel.SalesForOnePeople && saleRegionsModel.SalesForOnePeople != maxSalesForOnePeople)
                {
                    beforeMaxSalesForOnePeople = saleRegionsModel.SalesForOnePeople;
                }
            }

            lastPopulationForOneTT = Math.Round(lastPopulation * 1000000 / lastNumberTT / 1000, 2);
            lastSalesForOnePeople = Math.Round((beforeMaxSalesForOnePeople / 30)* lastPopulation * 365, 2);

            lastLineModel.Name = "";
            lastLineModel.NumberTT = lastNumberTT;
            lastLineModel.Population = lastPopulation;
            lastLineModel.PopulationForOneTT = lastPopulationForOneTT;
            lastLineModel.SalesInThe30Days = 0;
            lastLineModel.SalesForOnePeople = lastSalesForOnePeople;

            return lastLineModel;
        }

        public byte[] getExcel(List<SaleRegionsModel> saleRegionsModels)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {

                try
                { 
                    ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Sale By Regions");

                    ws.Cells["B1"].Value = "Pop";
                    ws.Cells["C1"].Value = "NoS";
                    ws.Cells["D1"].Value = "PpS";
                    ws.Cells["E1"].Value = "Sa/P30";
                    ws.Cells["B1:E1"].Style.Font.Bold = true;

                    int x = 2;
                    foreach (SaleRegionsModel saleRegionsModel in  saleRegionsModels)
                    {
                        ws.Cells[$"A{x}"].Value = saleRegionsModel.Name;
                        ws.Cells[$"B{x}"].Value = saleRegionsModel.Population;
                        ws.Cells[$"C{x}"].Value = saleRegionsModel.NumberTT;
                        ws.Cells[$"D{x}"].Value = saleRegionsModel.PopulationForOneTT;
                        ws.Cells[$"E{x}"].Value = saleRegionsModel.SalesForOnePeople;

                        x++;
                    }
                }

                catch
                {

                }

            FileInfo excelFile = new FileInfo("Sale By Regions.xlsx");
            excel.SaveAs(excelFile);

            return excel.GetAsByteArray();
             
            }
        }
    }
}
