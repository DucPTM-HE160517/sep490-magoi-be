using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _context;
        private ConcurrentDictionary<Type, object> _daos;

        public IBaseDAO<T> DAO<T>() where T : BaseModel
        {
            return _daos.GetOrAdd(typeof(T), _ => new BaseDAO<T>(_context)) as IBaseDAO<T> ?? default!;
        }

        public void Dispose() => _context.Dispose();

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
