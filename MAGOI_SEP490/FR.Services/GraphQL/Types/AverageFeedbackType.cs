using FR.BusinessObjects.Models;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class AverageFeedback
    {
        public float AverageServingScore { get; set; }
        public float AverageFoodScore { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        public int[] ServingScoreStats { get; set; }
        public int[] FoodScoreStats { get; set; }
    }
    public class AverageFeedbackType : ObjectType<AverageFeedback>
    {
        protected override void Configure(IObjectTypeDescriptor<AverageFeedback> descriptor)
        {
            descriptor.Field(f => f.AverageServingScore)
                .Type<DecimalType>()
                .Name("averageService")
                .Description("The average service score");

            descriptor.Field(f => f.AverageFoodScore)
                .Type<DecimalType>()
                .Name("averageFood")
                .Description("The average food score");

            descriptor.Field(f => f.Feedbacks)
                .Type<ListType<FeedbackType>>()
                .Name("feedbacks")
                .Description("The list of feedbacks");

            descriptor.Field(f => f.ServingScoreStats)
                .Type<ListType<IntType>>()
                .Name("servingScoreStats")
                .Description("Statistics of feedback's serving score");

            descriptor.Field(f => f.FoodScoreStats)
                .Type<ListType<IntType>>()
                .Name("foodScoreStats")
                .Description("Statistics of feedback's food score");
        }
    }

}
