using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAO
{
    public interface ILabelsDAO
    {
        Task<Labels> GetById(int id);
    }
}
