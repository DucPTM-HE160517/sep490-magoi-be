using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace FR.DataAccess.DAO
{
    public interface ISessionDAO
    {
        Task RegisterSession(string expoToken, string roleId);
        IQueryable<string> GetExpoTokensByRoleId(string roleId);
    }
}
