using FR.Infrastructure.Errors;

namespace FR.Services.GraphQL.Payload.Errors
{
    public static partial class Errors
    {
        public static class Feedback
        {
            public static Error InvalidInput
                => new(ErrorCode.INVALID_INPUT.ToString(), "Invalid input!");
        }
    }
}
