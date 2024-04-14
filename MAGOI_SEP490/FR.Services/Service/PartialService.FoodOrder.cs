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
using Newtonsoft.Json;

namespace FR.Services.Service
{
    public partial class Service : IFoodOrderService
    {

        public async Task<List<FoodOrder>> AddFoodOrders(Guid orderId, List<FoodOrderInput> foodListInput)
        {
            try
            {
                List<FoodOrder> foodOrders = new();
                for (int i = 0; i < foodListInput.Count; i++)
                {
                    FoodOrder foodorder = new()
                    {
                        OrderId = orderId,
                        FoodId = foodListInput[i].foodId,
                        Quantity = foodListInput[i].quantity,
                        FoodNote = foodListInput[i].foodNote,
                        UnitPrice = (await _uow.FoodDAO.GetFoodByFoodId(foodListInput[i].foodId)).UnitPrice,
                        OrderAt = DateTime.Now.ToUniversalTime(),
                        FoodOrderStatusId = (int)FoodOrderStatusId.Cooking
                    };
                    foodOrders.Add(foodorder);
                }

                await _uow.FoodOrderDAO.AddRangeAsync(foodOrders);
                await _uow.SaveAsync();
                _uow.Dispose();
                return foodOrders;
            }
            catch
            {
                _uow.Dispose();
                throw;
            }
        }

        public IQueryable<FoodOrder> GetFoodOrdersByOrderId(Guid orderId)
        {
            return _uow.FoodOrderDAO.GetFoodOrdersByOrderId(orderId);
        }

        public async Task UpdateFoodOrdersStatus(Guid orderId, int foodOrderStatusId)
        {
            List<FoodOrder> foods = await _uow.FoodOrderDAO.GetFoodOrdersByOrderId(orderId).ToListAsync();
            foreach (FoodOrder food in foods)
            {
                food.FoodOrderStatusId = foodOrderStatusId;
                _uow.FoodOrderDAO.Update(food);
            }
        }

        public async Task<FoodOrder> UpdateFoodOrderStatus(IExpoNotificationService expoSdkClient, 
            Guid orderId, int foodId, int foodOrderStatusId, bool sendNotification)
        {
            try
            {
                //Get order and table
                Order order = await GetOrderById(orderId);
                Table table = await GetTable(order.TableId);

                //update food status in the order
                FoodOrder food = await _uow.FoodOrderDAO.GetFoodOrderByOrderIdAndFoodId(orderId, foodId);
                food.FoodOrderStatusId = foodOrderStatusId;
                _uow.FoodOrderDAO.Update(food);

                //send notification
                if (sendNotification)
                {
                    string foodName = (await GetFoodById(foodId)).Name;
                    //get list of waiter devices
                    List<string> waiterTokens = await GetExpoTokensByRoleId("waiter").ToListAsync();
                    //send notification 
                    string msg = food.FoodOrderStatusId == (int)FoodOrderStatusId.Cooked ?
                        "Có món đã làm xong! Hãy phục vụ cho khách hàng!"
                        : $"Món {foodName} đã được cập nhật sang trạng thái {Enum.GetName(typeof(FoodOrderStatusId), (FoodOrderStatusId)food.FoodOrderStatusId)}!";

                    await expoSdkClient.SendNotification(waiterTokens,
                    $"{table.Name} - Đơn #FR{orderId.ToString().Substring(0, 5).ToUpper()}", msg,
                    data: JsonConvert.SerializeObject(new
                    {
                        type = NotificationType.FoodReady,
                        tableId = table.Id,
                    }));
                }

                await _uow.SaveAsync();
                _uow.Dispose();
                return food;
            }
            catch (Exception e)
            {
                _uow.Dispose();
                throw;
            }
        }
        public async Task<Food[]> GetTop5FoodOfOrders(List<Order> orders)
        {
            Dictionary<int, int> foodCounts = new Dictionary<int, int>();

            foreach (var order in orders)
            {
                List<FoodOrder> foodOrders = await GetFoodOrdersByOrderId(order.Id).ToListAsync();
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
                food = await GetFoodById(top5Foods.ElementAt(i).Key);
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

        public async Task<List<Food>> GetCookingFoodsByCategory(int categoryId)
        {
            List<FoodOrder> cookingFoodList = await _uow.FoodOrderDAO.GetFoodOrdersByStatusId((int) FoodOrderStatusId.Cooking).ToListAsync();
            List <FoodOrder> dup_list = new();
            foreach (FoodOrder foodOrder in cookingFoodList)
            {
                Food f = await GetFoodById(foodOrder.FoodId);
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
                Food f = await GetFoodById(pair.Key);
                f.Quantity = pair.Value;
                result.Add(f);
            }

            return result;
        }

    }
}
