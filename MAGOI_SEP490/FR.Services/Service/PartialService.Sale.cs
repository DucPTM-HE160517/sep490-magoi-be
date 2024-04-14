using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.Infrastructure.Enums;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.Services.Service
{
    public partial class Service : ISaleService
    {
        public async Task<SaleRecord> GetSaleRecord(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = await GetOrdersByTimeRange(startDate, endDate).ToListAsync();
            List<Bill> bills = await GetBillsByTimeRange(startDate, endDate).ToListAsync();

            SaleRecord record = new();

            record.Revenue = GetTotalAmountOfBills(bills);
            record.ServingOrders = (await GetOrdersByTimeRangeAndStatus(startDate, endDate, (int)OrderStatusId.Pending).ToListAsync())
                                .Concat(await GetOrdersByTimeRangeAndStatus(startDate, endDate, (int)OrderStatusId.Cooking).ToListAsync())
                                .Concat(await GetOrdersByTimeRangeAndStatus(startDate, endDate, (int)OrderStatusId.Serving).ToListAsync()).ToList();
            record.ServedOrders = await GetOrdersByTimeRangeAndStatus(startDate, endDate, (int)OrderStatusId.Finished).ToListAsync();
            record.BillsPerHour = GetBillsPerHour(bills);
            record.FoodRank = await GetTop5FoodOfOrders(orders);

            return record;
        }

        public async Task<SaleReport> GetSaleReports(DateTime startDate, DateTime endDate)

        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            //get order list by bill
            List<Order> orders = new List<Order>();
            List<Bill> bills = _uow.BillDAO.GetBillsByTimeRange(startDate, endDate).ToList();
            foreach (Bill bill in bills)
            {
                orders.AddRange(_uow.OrderDAO.GetOrdersByBillId(bill.Id));
            }

            //Get SaleReportElememt List
            List<SaleRevenue> saleRevenues = new List<SaleRevenue>();
            foreach (Order order in orders)
            {
                foreach (FoodOrder foodOrder in _uow.FoodOrderDAO.GetFoodOrdersByOrderId(order.Id))
                {
                    if (saleRevenues.Count == 0)
                    {
                        SaleRevenue SaleRevenue = new SaleRevenue()
                        {
                            Quantity = foodOrder.Quantity,
                            Income = foodOrder.Quantity * foodOrder.UnitPrice,
                            Food = await _uow.FoodDAO.GetFoodByFoodId(foodOrder.FoodId)
                        };
                        saleRevenues.Add(SaleRevenue);
                    }
                    else
                    {
                        int indexMatchedReport = FindSaleRevenueIndexByFoodId(foodOrder.FoodId, saleRevenues);
                        if (indexMatchedReport == -1)
                        {
                            SaleRevenue SaleRevenue = new SaleRevenue()
                            {
                                Quantity = foodOrder.Quantity,
                                Income = foodOrder.Quantity * foodOrder.UnitPrice,
                                Food = await _uow.FoodDAO.GetFoodByFoodId(foodOrder.FoodId)
                            };
                            saleRevenues.Add(SaleRevenue);
                        }
                        else
                        {
                            saleRevenues[indexMatchedReport].Quantity += foodOrder.Quantity;
                            saleRevenues[indexMatchedReport].Income += foodOrder.UnitPrice * foodOrder.Quantity;
                        }
                    }
                }
            }
            //Get SaleReport List
            float sumIncome = 0;
            foreach (SaleRevenue SaleRevenue in saleRevenues)
            {
                sumIncome += SaleRevenue.Income;
            }

            SaleReport saleReport = new SaleReport()
            {
                TotalIncome = sumIncome,
                SaleRevenue = saleRevenues
            };

            return saleReport;
        }
        public int FindSaleRevenueIndexByFoodId(int foodId, List<SaleRevenue> SaleRevenues)
        {
            int index = -1;
            for (int i = 0; i < SaleRevenues.Count; i++)
            {
                if (SaleRevenues[i].Food.Id == foodId)
                {
                    return i;
                }
            }
            return index;
        }
    }
}
