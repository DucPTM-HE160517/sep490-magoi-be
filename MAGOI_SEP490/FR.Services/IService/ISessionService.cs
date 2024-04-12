namespace FR.Services.IService;

public interface ISessionService
{
    void RegisterSession(string expoToken, string roleId);
    IQueryable<string> GetExpoTokensByRoleId(string roleId);
}