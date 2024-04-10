using FR.DataAccess.DAOimpl;
using FR.Services.IService;

namespace FR.Services.Service;

public class SessionService : ISessionService
{
    private readonly SessionDAO _dao;

    public SessionService(SessionDAO dao)
    {
        _dao = dao;
    }

    public void RegisterSession(string expoToken, string roleId)
    {
        _dao.RegisterSession(expoToken, roleId);
    }

    public List<string> GetExpoTokensByRoleId(string roleId)
    {
        return _dao.GetExpoTokensByRoleId(roleId);
    }
}