using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Types
{
    public class TableType : ObjectType<Table>
    {
        protected override void Configure(IObjectTypeDescriptor<Table> descriptor)
        {
            descriptor.Description("The table in the restaurant");
            descriptor.Field(f => f.Id)
                .Type<IntType>()
                .Name("id")
                .Description("The ID of the table");
            descriptor.Field(f => f.Name)
                .Type<StringType>()
                .Name("name")
                .Description("The name of the table");
            descriptor.Field(f => f.StatusId)
                .Type<IntType>()
                .Name("statusId")
                .Description("The status's id of the table");
            descriptor.Field("Status")
                .Type<TableStatusType>()
                .Name("status")
                .Resolve(context =>
                {
                    var table = context.Parent<Table>();
                    return context.Service<ITableStatusService>().GetTableStatusById(table.StatusId);

                })
                .Description("The status of the table");
        }
    }
}
