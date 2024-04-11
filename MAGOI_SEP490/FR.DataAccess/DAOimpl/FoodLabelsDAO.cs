using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;

namespace FR.DataAccess.DAOimpl
{
    public class FoodLabelsDAO : BaseDAO<FoodLabels>, IFoodLabelsDAO
    {
        public FoodLabelsDAO(DBContext context) : base(context)
        {
        }
    }
}
