using FR.BusinessObjects.Models;

namespace FR.DataAccess.Base
{
    public interface IBaseDAO<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
