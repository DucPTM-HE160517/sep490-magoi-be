using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;
using FR.Services.Service;

namespace FR.API.GraphQL.Types
{

    public class FeedbacksWithAverageType : ObjectType<FeedbacksWithAverage>
    {
        protected override void Configure(IObjectTypeDescriptor<FeedbacksWithAverage> descriptor)
        {
            descriptor.Field(f => f.AverageServingScore)
                .Type<FloatType>()
                .Name("averageService")
                .Description("The average service score");

            descriptor.Field(f => f.AverageFoodScore)
                .Type<FloatType>()
                .Name("averageFood")
                .Description("The average food score");

            descriptor.Field(f => f.Feedbacks)
                .Type<ListType<FeedbackType>>()
                .Name("feedbacks")
                .Description("The list of feedbacks");
        }
    }

}
