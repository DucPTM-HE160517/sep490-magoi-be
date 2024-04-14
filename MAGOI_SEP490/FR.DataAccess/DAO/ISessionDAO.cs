using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface ISessionDAO : IBaseDAO<Session>
    {
        Task RegisterSession(string expoToken, string roleId);
        IQueryable<string> GetExpoTokensByRoleId(string roleId);
    }
}
