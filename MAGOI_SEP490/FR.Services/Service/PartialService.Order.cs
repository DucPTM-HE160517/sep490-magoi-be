using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.Infrastructure.Enums;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Table = FR.BusinessObjects.Models.Table;

namespace FR.Services.Service
{
    public partial class Service : IOrderService
    {
        public async Task<Order> AddOrder(OrderInput orderInput, List<FoodOrderInput> foodListInput)
        {
            try
            {
                //check order: foods amount exceed food quantity
                if (!(await CheckFoodOrdersQuantity(foodListInput)))
                {
                    throw new Exception("food amount exceed");
                }
                //add order
                var order = new Order
                {
                    TableId = orderInput.tableId,
                    CreatedAt = orderInput.createdAt,
                    OrderStatusId = (int)OrderStatusId.Pending,
                };
                await _uow.OrderDAO.AddAsync(order);
                //add food order
                List<FoodOrder> foodOrders = new();
                for (int i = 0; i < foodListInput.Count; i++)
                {
                    FoodOrder foodorder = new()
                    {
                        OrderId = order.Id,
                        FoodId = foodListInput[i].foodId,
                        Quantity = foodListInput[i].quantity,
                        FoodNote = foodListInput[i].foodNote,
                        UnitPrice = (await _uow.FoodDAO.GetFoodByFoodId(foodListInput[i].foodId)).UnitPrice,
                        OrderAt = DateTime.Now.ToUniversalTime(),
                        FoodOrderStatusId = (int)FoodOrderStatusId.Uncooked
                    };
                    foodOrders.Add(foodorder);
                }

                await _uow.FoodOrderDAO.AddRangeAsync(foodOrders);
                //update quantity of the food
                for (int i = 0; i < foodListInput.Count; i++)
                {
                    Food food = await _uow.FoodDAO.GetFoodByFoodId(foodListInput[i].foodId);
                    food.Quantity -= foodListInput[i].quantity;
                    _uow.FoodDAO.Update(food);
                }
                //update table status
                Table table = await GetTable(orderInput.tableId);
                if (table.StatusId == (int)TableStatusId.Available)
                {
                    table.StatusId = (int)TableStatusId.Serving;
                    _uow.TableDAO.Update(table);
                }

                await _uow.SaveAsync();
                _uow.Dispose();
                return order;
            }
            catch
            {
                _uow.Dispose();
                throw;
            }
            
        }

        public async Task<Order> UpdateOrderStatus(IExpoNotificationService expoSdkClient, 
            Guid orderId, int orderStatusId, bool sendNotification)
        {
            try
            {
                //update order status
                Order o = await _uow.OrderDAO.GetOrderById(orderId);
                o.OrderStatusId = orderStatusId;
                _uow.OrderDAO.Update(o);
                //update food status of order
                List<FoodOrder> foods = await _uow.FoodOrderDAO.GetFoodOrdersByOrderId(orderId).ToListAsync();
                int foodOrderStatusId = 0;
                switch (orderStatusId)
                {
                    //order status id -> food order status id
                    case 1: //Pending -> uncook
                        foodOrderStatusId = (int)FoodOrderStatusId.Uncooked;
                        break;
                    case 2: // Cooking -> cooking
                        foodOrderStatusId = (int)FoodOrderStatusId.Cooking;
                        break;
                    case 3: // serving -> cooked
                        foodOrderStatusId = (int)FoodOrderStatusId.Cooked;
                        break;
                    case 4: // finished -> cooked
                        foodOrderStatusId = (int)FoodOrderStatusId.Cooked;
                        break;
                }
                foreach (FoodOrder food in foods)
                {
                    food.FoodOrderStatusId = foodOrderStatusId;
                    _uow.FoodOrderDAO.Update(food);
                }
                //send notification
                if (sendNotification)
                {
                    //get list of waiter devices
                    List<string> waiterTokens = await GetExpoTokensByRoleId("waiter").ToListAsync();
                    //send notification
                    string msg = o.OrderStatusId == (int)OrderStatusId.Serving ?
                        "Đơn hàng đã làm xong! Hãy phục vụ cho khách hàng!"
                        : "Đơn hàng đã được cập nhật trạng thái" + Enum.GetName(typeof(OrderStatusId), (OrderStatusId)o.OrderStatusId) + "!";
                    Table table = await GetTable(o.TableId);
                    await expoSdkClient.SendNotification(waiterTokens,
                        $"{table.Name} - Đơn #FR{orderId.ToString().Substring(0, 5).ToUpper()}", msg,
                        data: JsonConvert.SerializeObject(new
                        {
                            type = NotificationType.FoodReady,
                            tableId = table.Id
                        }));
                }
                //save
                await _uow.SaveAsync();
                _uow.Dispose();

                return o;
            }
            catch
            {
                _uow.Dispose();
                throw;
            }
        }

        public async Task<Table> FinishOrdersOfTable(Guid tableId, DateTime finishedAt, int paymentMethodId)
        {
            try
            {
                // get served orders by tableId 
                List<Order> orders = await GetOrdersByTableIdAndOrderStatusId(tableId, (int) OrderStatusId.Serving).ToListAsync();
                
                // update order status to "finished"
                //update food status in the order to "cooked"
                if (orders == null || orders.Count == 0)
                {
                    throw new Exception("This table has no served orders!");
                }
                foreach (var order in orders)
                {
                    order.OrderStatusId = (int)OrderStatusId.Finished;
                    await UpdateFoodOrdersStatus(order.Id, (int)FoodOrderStatusId.Cooked);
                    _uow.OrderDAO.Update(order);
                }
                
                // update table status to "available"
                Table table = await UpdateTableStatus(tableId, (int)TableStatusId.Available);
                
                //create bill
                Bill bill = await CreateBill(await GetTotalPriceOfOrders(orders));
                
                //update bill id of order
                foreach (var order in orders)
                {
                    order.BillId = bill.Id;
                    _uow.OrderDAO.Update(order);
                }

                // update finished time and paymentMethod of the bill
                bill.FinishedAt = finishedAt.ToUniversalTime();
                bill.PaymentMethodId = paymentMethodId;
                _uow.BillDAO.Update(bill);

                await _uow.SaveAsync();
                _uow.Dispose();
                return table;
            }
            catch
            {
                _uow.Dispose();
                throw;
            }
        }
        public async Task<Order> GetOrderById(Guid Id)
        {
            return await _uow.OrderDAO.GetOrderById(Id);
        }
        public IQueryable<Order> GetOrdersByOrderStatusId(int? orderStatusId)
        {
            return _uow.OrderDAO.GetOrdersByStatusId(orderStatusId);
        }
        public IQueryable<Order> GetOrdersByTableId(Guid tableId)
        {
            return _uow.OrderDAO.GetOrdersByTableId(tableId);
        }
        public IQueryable<Order> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId)
        {
            return _uow.OrderDAO.GetOrdersByTableIdAndStatus(tableId, orderStatusId);
        }
        public async Task<float> GetTotalPriceOfOrders(List<Order> orders)
        {
            float totalPrice = 0;

            foreach (var order in orders)
            {
                totalPrice += await _uow.OrderDAO.GetTotalAmmountOfOrder(order.Id);
            }

            return totalPrice;
        }

        public async Task<List<Order>> GetOrdersByBillId(Guid billId)
        {
            return await _uow.OrderDAO.GetOrdersByBillId(billId).ToListAsync();
        }

        public IQueryable<Order> GetOrdersByTimeRangeAndStatus(DateTime startDate, DateTime endDate, int orderStatusId)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            return _uow.OrderDAO.GetOrdersByTimeRangeAndStatus(startDate, endDate, orderStatusId);
        }
        public IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);
            return _uow.OrderDAO.GetOrdersByTimeRange(startDate, endDate);
        }
    }
}
