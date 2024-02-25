using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Bill> GetBillsByDate(IBillService billService, DateTime billDate) => billService.GetBillsByDate(billDate);
    }
}
