using FR.BusinessObjects.Models;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Bill> GetBillsByDate(IBillService billService, DateTime billDate) => billService.GetBillsByDate(billDate).ToList();
        public async Task<Bill> Bill(IBillService billService, Guid billId) =>await billService.GetBillById(billId);
    }
}
