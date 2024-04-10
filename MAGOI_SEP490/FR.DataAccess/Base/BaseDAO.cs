using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.Base
{
    public class BaseDAO<T> : IBaseDAO<T> where T : BaseModel
    {
        protected readonly DBContext _context;
        public BaseDAO(DBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }
        public void DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public void UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
