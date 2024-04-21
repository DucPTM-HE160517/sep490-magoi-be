using FR.BusinessObjects.Models.VietQR;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<BankingResponse> GetBankQR(IBankService bankService, 
            string tableName, float totalAmount) 
            => await bankService.GetQRAsync(tableName, totalAmount);
    }
}
