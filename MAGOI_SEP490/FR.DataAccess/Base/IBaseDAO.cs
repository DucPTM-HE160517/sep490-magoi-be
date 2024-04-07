using FR.BusinessObjects.Models.Base;

namespace FR.DataAccess.Base
{
    public interface IBaseDAO<T> where T : ModelBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}
