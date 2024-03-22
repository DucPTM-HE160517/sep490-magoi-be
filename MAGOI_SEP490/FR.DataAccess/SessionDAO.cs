using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess;

public class SessionDAO
{
    private readonly DBContext _context;

    public SessionDAO(DBContext context)
    {
        _context = context;
    }
    public void RegisterSession(string expoToken, string roleId)
    {
        //Check if session already exists
        var session = _context.Sessions.FirstOrDefault(s => s.ExpoToken == expoToken);
        if (session != null)
        {
            return;
        }

        _context.Sessions.Add(new Session()
        {
            ExpoToken = expoToken,
            Role = roleId
        });
        _context.SaveChanges();
    }
    public List<string> GetExpoTokensByRoleId(string roleId)
    {
        return _context.Sessions.Where(s => s.Role == roleId).Select(s => s.ExpoToken).ToList();
    }
}