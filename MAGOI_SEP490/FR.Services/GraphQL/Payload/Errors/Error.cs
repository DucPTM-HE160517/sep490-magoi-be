namespace FR.Services.GraphQL.Payload.Errors
{
    public readonly record struct Error
    {
        //
        // Summary:
        //     Gets the unique error code.
        public string Code { get; }

        //
        // Summary:
        //     Gets the error description.
        public string Description { get; }

        public Error(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
