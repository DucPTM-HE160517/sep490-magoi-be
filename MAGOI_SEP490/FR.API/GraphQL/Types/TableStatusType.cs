using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Types
{
    public class TableStatusType : ObjectType<TableStatus>
    {
        protected override void Configure(IObjectTypeDescriptor<TableStatus> descriptor)
        {
            descriptor.Description("The status of the table");
            descriptor.Field(f => f.Id)
                .Type<IntType>()
                .Name("id")
                .Description("The ID of the status");
            descriptor.Field(f => f.Status)
                .Type<StringType>()
                .Name("status")
                .Description("The name of the status");
        }
    }
}
