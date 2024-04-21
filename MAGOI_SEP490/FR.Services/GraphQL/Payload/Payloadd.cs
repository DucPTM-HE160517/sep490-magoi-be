using FR.BusinessObjects;
using FR.Services.GraphQL.Payload.Errors;

namespace FR.Services.GraphQL.Payload
{
    public class Payloadd<T> where T : BaseModel
    {
        public T? Value { get; }
        public Error? Error { get; }

        public Payloadd(T value)
        {
            Value = value;
        }

        public Payloadd(Error error)
        {
            Error = error;
        }
    }
}
