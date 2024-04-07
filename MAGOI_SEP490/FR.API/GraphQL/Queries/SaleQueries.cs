using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public SaleRecord GetSaleRecord(DateTime startDate, DateTime endDate,
            IOrderService orderService,
            IFoodOrderService foodOrderService,
            IBillService billService)
        {
            List<Order> orders = orderService.GetOrdersByTimeRange(startDate, endDate).ToListAsync().Result;
            List<Bill> bills = billService.GetBillsByTimeRange(startDate, endDate).ToListAsync().Result;

            SaleRecord record = new SaleRecord();

            record.Revenue = billService.GetTotalAmountOfBills(bills);
            record.ServingOrders = orderService.GetServingOrdersByTimeRange(startDate, endDate).ToListAsync().Result;
            record.ServedOrders = orderService.GetServedOrdersByTimeRange(startDate, endDate).ToListAsync().Result;
            record.BillsPerHour = billService.GetBillsPerHour(bills);
            record.FoodRank = foodOrderService.GetTop5FoodOfOrders(orders).Result;

            return record;
        }
        public SaleReport GetSaleReports(IFoodOrderService foodOrderService, DateTime startDate, DateTime endDate)
                                 => foodOrderService.GetSaleReport(startDate, endDate);
    }
}
