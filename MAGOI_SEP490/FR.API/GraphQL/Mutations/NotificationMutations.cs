using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<string> RegisterSession(ISessionService sessionService, string expoToken, string roleId)
        {
            sessionService.RegisterSession(expoToken, roleId);
            return $"Registered session for {roleId} with token {expoToken}";
        }
    }
}
