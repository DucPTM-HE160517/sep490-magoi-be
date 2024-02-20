using FR.BusinessObjects.Models.ExpoNotification;
using FR.Services.IService;
using FR.Services.Service;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutations
    {
        public async Task<string> RegisterSession(ISessionService sessionService, string expoToken, string roleId)
        {
            sessionService.RegisterSession(expoToken, roleId);
            return $"Registered session for {roleId} with token {expoToken}";
        }
    }
}
