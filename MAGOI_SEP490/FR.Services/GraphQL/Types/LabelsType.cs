using FR.BusinessObjects.Models;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class LabelsType : ObjectType<Labels>
    {
        protected override void Configure(IObjectTypeDescriptor<Labels> descriptor)
        {

        }
    }
}
