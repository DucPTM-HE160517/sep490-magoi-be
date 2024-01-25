using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class FeedbackType : ObjectType<Feedback>
    {
        protected override void Configure(IObjectTypeDescriptor<Feedback> descriptor)
        {

        }
    }
}
