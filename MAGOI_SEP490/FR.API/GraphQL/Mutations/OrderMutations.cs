using CloudinaryDotNet.Actions;
using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;
using FR.Services.GraphQL.Payload;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;
using HotChocolate.Subscriptions;
using Newtonsoft.Json;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        //add order
        public async Task<Order> AddOrder(
            OrderInput orderInput, List<FoodOrderInput> foodListInput,
            IOrderService orderService, [Service] ITopicEventSender eventSender,
            CancellationToken cancellationToken
            )
        {
            Order order = await orderService.AddOrder(orderInput, foodListInput);
            await eventSender.SendAsync(nameof(AddOrder), order, cancellationToken);
            return order;
        }

        //update order status
        public async Task<Order> UpdateOrderStatus(
            IOrderService orderService, IExpoNotificationService expoSdkClient,
            Guid orderId, int orderStatusId, bool sendNotification = false)
            => await orderService.UpdateOrderStatus(expoSdkClient, orderId, orderStatusId, sendNotification);

        //finish all orders of the table and return bill
        public async Task<Table> FinishOrdersOfTable(
            IOrderService orderService,
            Guid tableId, DateTime finishedAt, int paymentMethodId)
            => await orderService.FinishOrdersOfTable(tableId, finishedAt, paymentMethodId);
    }
}