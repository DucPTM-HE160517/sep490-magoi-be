using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

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

    public async Task RegisterSession(string expoToken, string roleId)
    {
        // Check if session already exists
        var session = await _context.Sessions.FirstOrDefaultAsync(s => s.ExpoToken == expoToken);
        if (session != null)
        {
            return;
        }

        // Add new session
        await AddAsync(new Session()
        {
            ExpoToken = expoToken,
            Role = roleId
        });

        //_context.SaveChanges();
    }
}