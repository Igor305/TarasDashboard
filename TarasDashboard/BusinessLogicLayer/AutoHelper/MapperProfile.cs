using AutoMapper;
using BusinessLogicLayer.Models;
using DataAccessLayer;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.AutoHelper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Shop, ShopModel>();
            CreateMap<RegionsLocalization, RegionsLocalizationModel>();
            CreateMap<IpSaleOracle, SaleOracleModel>();
            CreateMap<SaleStatistic, SaleStatisticModel>();
            CreateMap<IpSaleLast30Days_ByRegion, SaleLast30Days_ByRegionModel>();
            CreateMap<ExecutionPlanDateHistory, ExecutionPlanDate_HistoryModel>();
        }
    }
}
