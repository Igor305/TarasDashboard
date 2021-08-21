using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Entities
{
    [Keyless]
    public class IpSaleOracle
    {
        public decimal Real { get; set; }
        public decimal Oracle { get; set; }
        //public int PercentOnlineStock { get; set; }
        public decimal AvgCheck { get; set; }
        public decimal RecFor7Day { get; set; }
    }
}
