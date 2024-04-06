using FR.BusinessObjects.Models;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class AverageFeedback
    {
        public float AverageServingScore { get; set; }
        public float AverageFoodScore { get; set; }
        public List<Feedback> Feedbacks { get; set; }
    }
    public class AverageFeedbackType : ObjectType<AverageFeedback>
    {
        protected override void Configure(IObjectTypeDescriptor<AverageFeedback> descriptor)
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
