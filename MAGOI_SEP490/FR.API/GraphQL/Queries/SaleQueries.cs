using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<SaleRecord> GetSaleRecord(DateTime date,
            IOrderService orderService,
            IFoodOrderService foodOrderService,
            IBillService billService)
        {
            List<Order> orders = orderService.GetOrdersByTimeRange(date).ToList();
            List<Bill> bills = billService.GetBillsByTimeRange(date).ToList();

            SaleRecord record = new SaleRecord();
            record.Date = date;

            record.Revenue = billService.GetTotalAmountOfBills(bills);
            record.ServingOrders = await orderService.GetServingOrdersByTimeRange(date).ToListAsync();
            record.ServedOrders = await orderService.GetServedOrdersByTimeRange(date).ToListAsync();
            record.BillsPerHour = billService.GetBillsPerHour(bills);
            record.FoodRank = foodOrderService.GetTop5FoodOfOrders(orders);

            return record;
        }
    }
}
