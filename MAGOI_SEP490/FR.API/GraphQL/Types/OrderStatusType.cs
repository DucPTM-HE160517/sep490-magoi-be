using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class OrderStatusType : ObjectType<OrderStatus>
    {
        protected override void Configure(IObjectTypeDescriptor<OrderStatus> descriptor)
        {

        }
    }
}
