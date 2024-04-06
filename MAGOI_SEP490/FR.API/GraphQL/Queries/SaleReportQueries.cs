using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public SaleReport GetSaleReports(IFoodOrderService foodOrderService, DateTime startDate, DateTime endDate) 
                                 => foodOrderService.GetSaleReport(startDate, endDate);
    }
}
