using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Entities
{
    [Keyless]
    public class IpSaleLast30Days_ByRegion
    {
        public string RegionName { get; set; }
        public decimal SaleSum { get; set; }
    }
}
