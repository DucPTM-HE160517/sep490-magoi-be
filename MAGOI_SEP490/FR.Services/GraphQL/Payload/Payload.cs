namespace FR.Services.GraphQL.Payload
{
    public abstract class Payload
    {
        public UserError? Error { get; }
        protected Payload(UserError? error = null)
        {
            Error = error;
        }
    }

    public record UserError(string message, string error_code);
}
