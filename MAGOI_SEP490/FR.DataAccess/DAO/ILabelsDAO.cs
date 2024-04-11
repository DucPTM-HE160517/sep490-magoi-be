using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAO
{
    public interface ILabelsDAO
    {
        Task<Labels> GetLabelsById(int id);
    }
}
