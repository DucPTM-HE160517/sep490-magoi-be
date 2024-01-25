using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class BillType : ObjectType<Bill>
    {
        protected override void Configure(IObjectTypeDescriptor<Bill> descriptor)
        {

        }
    }
}
