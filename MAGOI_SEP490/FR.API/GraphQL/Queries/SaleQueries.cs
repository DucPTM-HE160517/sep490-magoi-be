using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
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
            List<Order> orders = orderService.GetOrdersByTimeRange(startDate, endDate);
            List<Bill> bills = billService.GetBillsByTimeRange(startDate, endDate);

            SaleRecord record = new SaleRecord();
            record.StartDate = startDate;
            record.EndDate = endDate;

            record.ServingOrders = orderService.GetServingOrdersByTimeRange(startDate, endDate);
            record.ServedOrders = orderService.GetServedOrdersByTimeRange(startDate, endDate);
            record.BillsPerHour = billService.GetBillsPerHour(bills);
            record.FoodRank = foodOrderService.GetTop5FoodOfOrders(orders);

            return record;
        }
    }
}
