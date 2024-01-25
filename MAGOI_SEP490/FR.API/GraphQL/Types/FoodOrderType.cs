using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class FoodOrderType : ObjectType<FoodOrder>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodOrder> descriptor)
        {

        }
    }
}
