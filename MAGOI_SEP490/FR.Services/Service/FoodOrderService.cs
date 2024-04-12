using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Infrastructure.Enums;
using FR.Services.GraphQL.Types;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.Services.Service
{
    public class FoodOrderService : IFoodOrderService
    {
        private readonly IFoodOrderDAO _dao;
        private readonly IFoodDAO _foodDao;
        private readonly IUnitOfWork _uow;
        public FoodOrderService(IUnitOfWork uow)
        {
            _uow = uow;
            _foodDao = ((UnitOfWork)uow).Food;
            _dao = ((UnitOfWork)uow).FoodOrder;
        }

        public async Task<List<FoodOrder>> AddFoodOrdersAsync(Guid orderId, List<FoodOrderInput> foodListInput)
        {
            List<FoodOrder> foodOrders = new List<FoodOrder>();
            for (int i = 0; i < foodListInput.Count; i++)
            {
                FoodOrder foodorder = new FoodOrder
                {
                    OrderId = orderId,
                    FoodId = foodListInput[i].foodId,
                    Quantity = foodListInput[i].quantity,
                    FoodNote = foodListInput[i].foodNote,
                    UnitPrice = _dao.GetFoodUnitPriceByFoodId(foodListInput[i].foodId),
                    OrderAt = DateTime.Now.ToUniversalTime(),
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooking
                };
                foodOrders.Add(foodorder);
                _dao.AddAsync(foodorder);
            }
            
            return foodOrders;
        }

        public async Task<List<FoodOrder>> GetFoodOrdersByOrderIdAsync(Guid orderId)
        {
            return await _dao.GetFoodOrdersByOrderId(orderId).ToListAsync();
        }

        public async Task UpdateFoodOrdersStatusAsync(Guid orderId, int foodOrderStatusId)
        {
            try
            {
                List<FoodOrder> foods = await _dao.GetFoodOrdersByOrderId(orderId).ToListAsync();
                foreach (FoodOrder food in foods)
                {
                    food.FoodOrderStatusId = foodOrderStatusId;
                    _dao.Update(food);
                    await _uow.SaveAsync();
                    _uow.Dispose();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<FoodOrder> UpdateFoodOrderStatusAsync(Guid orderId, int foodId, int foodOrderStatusId)

        {
            try
            {
                FoodOrder food = await _dao.GetFoodOrderByOrderIdAndFoodId(orderId, foodId);
                food.FoodOrderStatusId = foodOrderStatusId;
                _dao.Update(food);
                await _uow.SaveAsync();
                _uow.Dispose();
                return food;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Food[]> GetTop5FoodOfOrdersAsync(List<Order> orders)
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
                food = await _foodDao.GetFoodByFoodId(top5Foods.ElementAt(i).Key);
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
        public async Task<SaleReport> GetSaleReportAsync(DateTime startDate, DateTime endDate)

        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            //Get SaleReportElememt List
            List<SaleRevenue> saleRevenues = new List<SaleRevenue>();
            foreach (FoodOrder foodOrder in _dao.GetFoodOrdersByTimeRange(startDate, endDate))
            {
                if (saleRevenues.Count == 0)
                {
                    SaleRevenue SaleRevenue = new SaleRevenue() {
                    Quantity = foodOrder.Quantity,
                    Income = foodOrder.Quantity * foodOrder.UnitPrice,
                    Food = await _foodDao.GetFoodByFoodId(foodOrder.FoodId)                  
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
                            Food = await _foodDao.GetFoodByFoodId(foodOrder.FoodId)
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

        public async Task<List<Food>> GetCookingFoodsByCategoryAsync(int categoryId)
        {
            List<FoodOrder> cookingFoodList = await _dao.GetFoodOrdersByStatusId((int) FoodOrderStatusId.Cooking).ToListAsync();
            List <FoodOrder> dup_list = new();
            foreach (FoodOrder foodOrder in cookingFoodList)
            {
                Food f = await _foodDao.GetFoodByFoodId(foodOrder.FoodId);
                if(f.FoodCategoryId == categoryId)
                {
                    dup_list.Add(foodOrder);
                }
            }

            Dictionary<int, int> raw_result = new Dictionary<int, int>();
            foreach (FoodOrder foodOrder in dup_list)
            {
                if (raw_result.ContainsKey(foodOrder.FoodId))
                {
                    raw_result[foodOrder.FoodId] += foodOrder.Quantity;
                }
                else
                {
                    raw_result[foodOrder.FoodId] = foodOrder.Quantity;
                }
            }

            List<Food> result = new List<Food>();
            foreach(KeyValuePair<int, int> pair in raw_result)
            {
                Food f = await _foodDao.GetFoodByFoodId(pair.Key);
                f.Quantity = pair.Value;
                result.Add(f);
            }

            return result;
        }

    }
}
