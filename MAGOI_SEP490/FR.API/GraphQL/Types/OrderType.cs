using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class OrderType : ObjectType<Order>
    {
        protected override void Configure(IObjectTypeDescriptor<Order> descriptor)
        {

        }
    }
}
