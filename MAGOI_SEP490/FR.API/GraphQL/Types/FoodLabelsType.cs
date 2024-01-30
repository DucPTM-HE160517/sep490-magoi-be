using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class FoodLabelsType : ObjectType<FoodLabels>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodLabels> descriptor)
        {

        }
    }
}
