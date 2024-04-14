using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore.Query;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<SaleRecord> GetSaleRecord(DateTime startDate, DateTime endDate, ISaleService saleService)
            => await saleService.GetSaleRecord(startDate, endDate);
        public async Task<SaleReport> GetSaleReports(ISaleService saleService, DateTime startDate, DateTime endDate)
                                 => await saleService.GetSaleReports(startDate, endDate);
    }
}
