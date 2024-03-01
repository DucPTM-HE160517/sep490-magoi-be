using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class PaymentMethodType : ObjectType<PaymentMethod>
    {
        protected override void Configure(IObjectTypeDescriptor<PaymentMethod> descriptor)
        {
            descriptor.Description("The payment method");
            descriptor.Field(f => f.Id)
                .Type<IntType>()
                .Name("id")
                .Description("The ID of the payment method");
            descriptor.Field(f => f.Method)
                .Type<StringType>()
                .Name("method")
                .Description("The name of the method");
        }
    }
}
