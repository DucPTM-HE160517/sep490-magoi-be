using MAGOI.BusinessObjects.Models;

namespace MAGOI.API.GraphQL.Types
{
    public class RestaurantType : ObjectType<Restaurant>
    {
        protected override void Configure(IObjectTypeDescriptor<Restaurant> descriptor)
        {
            descriptor.Description("The restaurant");
            descriptor.Field(f => f.RestaurantId)
                .Type<IntType>()
                .Name("ID")
                .Description("The ID of the Restaurant");
            descriptor.Field(f => f.Name)
                .Type<StringType>()
                .Name("Name")
                .Description("Name of the Restaurant");
            descriptor.Field(f => f.Address)
                .Type<StringType>()
                .Name("Address")
                .Description("The address of the Restaurant");
            descriptor.Field(f => f.Hotline)
                .Type<StringType>()
                .Name("Hotline")
                .Description("The hotline of the Restaurant");
            descriptor.Field(f => f.Email)
                .Type<StringType>()
                .Name("Email")
                .Description("The Email of the Restaurant");
        }
    }
}
