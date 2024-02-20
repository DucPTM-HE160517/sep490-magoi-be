namespace FR.Services.IService;

public interface ISessionService
{
    void RegisterSession(string expoToken, string roleId);
    List<string> GetExpoTokensByRoleId(string roleId);
}