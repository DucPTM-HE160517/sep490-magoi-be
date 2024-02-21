using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<string> GetBankQR(IBankService bankService) => await bankService.GetQRAsync();
    }
}
