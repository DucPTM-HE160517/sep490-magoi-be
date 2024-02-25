﻿using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Payload
{
    public class UpdateOrderStatusPayload : Payload
    {
        public Order? Order { get; }
        public UpdateOrderStatusPayload(Order order)
        {
            Order = order;
        }

        public UpdateOrderStatusPayload(UserError error) : base(error) { }
    }
}
