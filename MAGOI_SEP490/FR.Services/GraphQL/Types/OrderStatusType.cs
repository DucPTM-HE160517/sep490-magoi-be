using FR.BusinessObjects.Models;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class OrderStatusType : ObjectType<OrderStatus>
    {
        protected override void Configure(IObjectTypeDescriptor<OrderStatus> descriptor)
        {

        }
    }
}
