using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class FoodCharacteristicsType : ObjectType<FoodCharacteristics>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodCharacteristics> descriptor)
        {

        }
    }
}
