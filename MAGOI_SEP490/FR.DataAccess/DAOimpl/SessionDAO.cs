using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;

namespace FR.DataAccess.DAOimpl;

public class SessionDAO : BaseDAO<Session>, ISessionDAO
{
    public SessionDAO(DBContext context) : base(context)
    {
    }

    public IQueryable<string> GetExpoTokensByRoleId(string roleId)
    {
        return _context.Sessions.Where(s => s.Role == roleId).Select(s => s.ExpoToken);
    }

    public Task RegisterSession(string expoToken, string roleId)
    {
        return Task.Run(() =>
        {
            // Check if session already exists
            var session = _context.Sessions.FirstOrDefault(s => s.ExpoToken == expoToken);
            if (session != null)
            {
                return;
            }

            // Add new session
            _context.Sessions.Add(new Session()
            {
                ExpoToken = expoToken,
                Role = roleId
            });

            _context.SaveChanges();
        });
    }

    //public void RegisterSession(string expoToken, string roleId)
    //{
    //    Check if session already exists
    //    var session = _context.Sessions.FirstOrDefault(s => s.ExpoToken == expoToken);
    //    if (session != null)
    //    {
    //        return;
    //    }

    //    _context.Sessions.Add(new Session()
    //    {
    //        ExpoToken = expoToken,
    //        Role = roleId
    //    });
    //    _context.SaveChanges();
    //}
    //public List<string> GetExpoTokensByRoleId(string roleId)
    //{
    //    return _context.Sessions.Where(s => s.Role == roleId).Select(s => s.ExpoToken).ToList();
    //}
}