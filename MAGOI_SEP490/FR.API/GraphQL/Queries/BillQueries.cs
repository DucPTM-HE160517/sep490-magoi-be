using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Bill> GetBillsByDate(IBillService billService, DateTime billDate) => billService.GetBillsByDate(billDate);
        public Bill Bill(IBillService billService, Guid billId) => billService.GetBillById(billId);
    }
}
