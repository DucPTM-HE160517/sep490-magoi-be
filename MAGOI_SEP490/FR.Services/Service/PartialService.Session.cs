using FR.DataAccess.DAO;
using FR.DataAccess.UOW;
using FR.Services.IService;

namespace FR.Services.Service;

public partial class Service : ISessionService
{
    public void RegisterSession(string expoToken, string roleId)
    {
        _dao.RegisterSession(expoToken, roleId);
    }

    public IQueryable<string> GetExpoTokensByRoleId(string roleId)
    {
        return _dao.GetExpoTokensByRoleId(roleId);
    }
}