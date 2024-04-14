using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<Bill> GetBillsByDate(IBillService billService, DateTime billDate) 
            => billService.GetBillsByDate(billDate);
        public async Task<Bill> Bill(IBillService billService, Guid billId) 
            => await billService.GetBillById(billId);
    }
}
