using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.Base
{
    public class BaseDAO<T> : IBaseDAO<T> where T : ModelBase
    {
        protected readonly DBContext _context;
        public BaseDAO(DBContext context)
        {
            _context = context;
        }
        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public virtual async Task<T?> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public virtual async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public virtual async Task<T> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);

            return entity;
        }
        public virtual async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }
    }
}
