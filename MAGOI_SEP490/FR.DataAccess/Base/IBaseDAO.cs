using FR.BusinessObjects.Models;

namespace FR.DataAccess.Base
{
    public interface IBaseDAO<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(T entity);
    }
}
