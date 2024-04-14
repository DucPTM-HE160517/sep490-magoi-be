using FR.BusinessObjects.Models;
using FR.Services.IService;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class FeedbackType : ObjectType<Feedback>
    {
        protected override void Configure(IObjectTypeDescriptor<Feedback> descriptor)
        {
            descriptor.Description("Feedback of the bill");
            descriptor.Field(f => f.Id)
                .Type<UuidType>()
                .Name("id")
                .Description("The ID of the feedback");
            descriptor.Field(f => f.ServingScore)
                .Type<IntType>()
                .Name("servingScore")
                .Description("The serving score given by customer");
            descriptor.Field(f => f.FoodScore)
                .Type<IntType>()
                .Name("foodScore")
                .Description("The food score given by customer");
            descriptor.Field(f => f.Comment)
                .Type<StringType>()
                .Name("comment")
                .Description("The comment given by customer");
            descriptor.Field(f => f.BillId)
                .Type<UuidType>()
                .Name("billId")
                .Description("The bill Id of the feedback");
            descriptor.Field("Bill")
                .Type<BillType>()
                .Name("bill")
                .Resolve(async context =>
                {
                    var feedback = context.Parent<Feedback>();
                    return await context.Service<IBillService>().GetBillById(feedback.BillId);
                })
                .Description("The bill of the feedback");
        }
    }
}
