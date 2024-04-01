using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<SaleReport> GetSaleReports(IFoodOrderService foodOrderService, DateTime startDate, DateTime endDate) 
                                 => foodOrderService.GetSaleReports(startDate, endDate);
    }
}
