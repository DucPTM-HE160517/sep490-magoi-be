using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<SaleRecord> GetSaleRecord(DateTime startDate, DateTime endDate,
            IOrderService orderService,
            IFoodOrderService foodOrderService,
            IBillService billService)
        {
            List<Order> orders = orderService.GetOrdersByTimeRange(startDate, endDate).ToList();
            List<Bill> bills = billService.GetBillsByTimeRange(startDate, endDate).ToList();

            SaleRecord record = new SaleRecord();

            record.Revenue = billService.GetTotalAmountOfBills(bills);
            record.ServingOrders = await orderService.GetServingOrdersByTimeRange(startDate, endDate).ToListAsync();
            record.ServedOrders = await orderService.GetServedOrdersByTimeRange(startDate, endDate).ToListAsync();
            record.BillsPerHour = billService.GetBillsPerHour(bills);
            record.FoodRank = foodOrderService.GetTop5FoodOfOrders(orders);

            return record;
        }
        public SaleReport GetSaleReports(IFoodOrderService foodOrderService, DateTime startDate, DateTime endDate)
                                 => foodOrderService.GetSaleReport(startDate, endDate);
    }
}
