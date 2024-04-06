using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
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
            List<Order> orders = orderService.GetOrdersByTimeRange(date);
            List<Bill> bills = billService.GetBillsByTimeRange(date);

            SaleRecord record = new SaleRecord();
            record.Date = date;

            record.Revenue = billService.GetTotalAmountOfBills(bills);
            record.ServingOrders = await orderService.GetServingOrdersByTimeRange(startDate, endDate);
            record.ServedOrders = await orderService.GetServedOrdersByTimeRange(startDate, endDate);
            record.ServingOrders = orderService.GetServingOrdersByTimeRange(date);
            record.ServedOrders = orderService.GetServedOrdersByTimeRange(date);
            record.BillsPerHour = billService.GetBillsPerHour(bills);
            record.FoodRank = foodOrderService.GetTop5FoodOfOrders(orders);

            return record;
        }
    }
}
