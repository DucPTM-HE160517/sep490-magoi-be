using FR.Infrastructure.Errors;

namespace FR.Services.GraphQL.Payload.Errors
{
    public static partial class Errors
    {
        public static class Food
        {
            public static Error NotFound
                => new(ErrorCode.NOT_FOUND.ToString(), "Food not found!");
            public static Error InvalidInput(string? message)
                => new(ErrorCode.INVALID_INPUT.ToString(), $"Invalid input! {message}");
            public static Error UpdateFailed(string? message)
                => new(ErrorCode.UPDATE_FAILED.ToString(), $"Update failed! {message}");
        }
    }
}
