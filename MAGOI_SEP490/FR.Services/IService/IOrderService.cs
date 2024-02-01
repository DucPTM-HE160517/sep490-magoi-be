﻿using FR.BusinessObjects.Models;
using FR.Services.GraphQL.InputTypes;

namespace FR.Services.IService
{
    public interface IOrderService
    {
        Order AddOrder(OrderInput order);
        Order GetOrderById(Guid Id);
        List<Order> GetOrdersByTableId(Guid tableId);
        void DeleteOrder(Order order);
        List<Order> GetOrdersByOrderStatusId(int? orderStatusId);
    }
}
