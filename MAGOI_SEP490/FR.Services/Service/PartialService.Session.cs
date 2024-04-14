using FR.Services.IService;

namespace FR.Services.Service;

public partial class Service : ISessionService
{
    public void RegisterSession(string expoToken, string roleId)
    {
        _uow.SessionDAO.RegisterSession(expoToken, roleId);
    }

    public IQueryable<string> GetExpoTokensByRoleId(string roleId)
    {
        return _uow.SessionDAO.GetExpoTokensByRoleId(roleId);
    }
}