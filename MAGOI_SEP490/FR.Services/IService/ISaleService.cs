using FR.Services.GraphQL.Types;

namespace FR.Services.IService
{
    public interface ISaleService
    {
        Task<SaleRecord> GetSaleRecord(DateTime startDate, DateTime endDate);
        Task<SaleReport> GetSaleReports(DateTime startDate, DateTime endDate);
    }
}
