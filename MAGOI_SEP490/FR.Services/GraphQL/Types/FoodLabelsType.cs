using FR.BusinessObjects.Models;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class FoodLabelsType : ObjectType<FoodLabels>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodLabels> descriptor)
        {

        }
    }
}
