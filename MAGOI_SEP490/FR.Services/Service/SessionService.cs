using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Services.IService;

namespace FR.Services.Service;

public class SessionService : ISessionService
{
    private readonly ISessionDAO _dao;
    private readonly IUnitOfWork _uow;
    public SessionService(IUnitOfWork uow)
    {
        _uow = uow;
        _dao = ((UnitOfWork)uow).Session;
    }

    public void RegisterSession(string expoToken, string roleId)
    {
        _dao.RegisterSession(expoToken, roleId);
    }

    public IQueryable<string> GetExpoTokensByRoleId(string roleId)
    {
        return _dao.GetExpoTokensByRoleId(roleId);
    }
}