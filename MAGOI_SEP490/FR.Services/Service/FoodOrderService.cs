using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.DataAccess;
using FR.Infrastructure.Enums;
using FR.Services.GraphQL.Types;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.Services.Service
{
    public class FoodOrderService : IFoodOrderService
    {
        private readonly FoodOrderDAO _dao;
        public FoodOrderService(FoodOrderDAO dao)
        {
            _dao = dao;
        }

        public List<FoodOrder> AddFoodOrders(Guid orderId, List<FoodOrderInput> foodListInput)
        {
            List<FoodOrder> foodOrders = new List<FoodOrder>();
            for (int i = 0; i < foodListInput.Count; i++)
            {
                FoodOrder food = new FoodOrder
                {
                    OrderId = orderId,
                    FoodId = foodListInput[i].foodId,
                    Quantity = foodListInput[i].quantity,
                    FoodNote = foodListInput[i].foodNote,
                    UnitPrice = _dao.GetFoodPrice(foodListInput[i].foodId),
                    OrderAt = DateTime.Now.ToUniversalTime(),
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooking
                };
                foodOrders.Add(food);
            }
            _dao.AddFoodOrders(foodOrders);
            return foodOrders;
        }

        public IQueryable<FoodOrder> GetFoodOrdersByOrderId(Guid orderId)
        {
            return _dao.GetFoodOrdersByOrderId(orderId);
        }

        public async Task UpdateFoodOrdersStatus(Guid orderId, int foodOrderStatusId)
        {
            try
            {
                List<FoodOrder> foods = await _dao.GetFoodOrdersByOrderId(orderId).ToListAsync();
                foreach (FoodOrder food in foods)
                {
                    food.FoodOrderStatusId = foodOrderStatusId;
                    _dao.UpdateFoodOrder(food);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public FoodOrder UpdateFoodOrderStatus(Guid orderId, int foodId, int foodOrderStatusId)
        {
            try
            {
                FoodOrder food = _dao.GetFoodOrderByOrderIdAndFoodId(orderId, foodId);
                food.FoodOrderStatusId = foodOrderStatusId;
                _dao.UpdateFoodOrder(food);
                return food;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Food[]> GetTop5FoodOfOrders(List<Order> orders)
        {
            Dictionary<int, int> foodCounts = new Dictionary<int, int>();

            foreach (var order in orders)
            {
                List<FoodOrder> foodOrders = await _dao.GetFoodOrdersByOrderId(order.Id).ToListAsync();
                foreach (var foodOrder in foodOrders)
                {
                    if (foodCounts.ContainsKey(foodOrder.FoodId))
                    {
                        foodCounts[foodOrder.FoodId]++;
                    }
                    else
                    {
                        foodCounts[foodOrder.FoodId] = 1;
                    }
                }
            }
            //sort
            var sortedFoods = foodCounts.OrderByDescending(x => x.Value);
            //get top 5
            var top5Foods = sortedFoods.Take(5);
            Food[] foods = new Food[top5Foods.Count()];
            Food food;
            for (int i =0;i<foods.Length;i++)
            {
                food = _dao.GetFood(top5Foods.ElementAt(i).Key);
                foods[i] = new Food()
                {
                    Id = top5Foods.ElementAt(i).Key,
                    Name = food.Name,
                    ImageUrl = food.ImageUrl,
                    Quantity = top5Foods.ElementAt(i).Value
                };
            }

            return foods;
        }
        public SaleReport GetSaleReport(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            //Get SaleReportElememt List
            List<SaleRevenue> saleRevenues = new List<SaleRevenue>();
            foreach (FoodOrder foodOrder in _dao.GetFoodOrdersByTimeRange(startDate, endDate))
            {
                if (saleRevenues.Count == 0)
                {
                    SaleRevenue SaleRevenue = new() {
                    Quantity = foodOrder.Quantity,
                    Income = foodOrder.Quantity * foodOrder.UnitPrice,
                    Food = _dao.GetFood(foodOrder.FoodId)                  
                    };
                    saleRevenues.Add(SaleRevenue);
                }
                else
                {
                    int indexMatchedReport = FindSaleRevenueIndexByFoodId(foodOrder.FoodId, saleRevenues);
                    if (indexMatchedReport == -1)
                    {
                        SaleRevenue saleRevenue = new()
                        {
                            Quantity = foodOrder.Quantity,
                            Income = foodOrder.Quantity * foodOrder.UnitPrice,
                            Food = _dao.GetFood(foodOrder.FoodId)
                        };
                        
                        saleRevenues.Add(saleRevenue);
                    }
                    else
                    {
                        saleRevenues[indexMatchedReport].Quantity += foodOrder.Quantity;
                        saleRevenues[indexMatchedReport].Income += foodOrder.UnitPrice * foodOrder.Quantity;
                    }                    
                }
            }

            //Get SaleReport List
            float sumIncome = 0;
            foreach (SaleRevenue SaleRevenue in saleRevenues)
            {
                sumIncome += SaleRevenue.Income;
            }

            SaleReport saleReport = new SaleReport() {
            TotalIncome = sumIncome,
            SaleRevenue = saleRevenues
            };

            return saleReport;
        }
        public int FindSaleRevenueIndexByFoodId(int foodId, List<SaleRevenue> SaleRevenues)
        {
            for (int i = 0; i < SaleRevenues.Count; i++)
            {
                if (SaleRevenues[i].Food.Id == foodId)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
